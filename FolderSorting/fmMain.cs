using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using FolderSorting.models;
using System.Linq;
using FolderSorting.Properties;
using System.Drawing;

namespace FolderSorting
{
    public partial class fmMain : Form
    {
        private bool allowShowDisplay = false;
        List<ISortingFolder> sortingFolders = new List<ISortingFolder>();
        DateTime currentDate = DateTime.Now;
        IMonth Month = new IMonth();

        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(allowShowDisplay ? value : allowShowDisplay);
        }

        private void ShowForm()
        {
            allowShowDisplay = true;
            Show();
        }

        public fmMain()
        {
            InitializeComponent();

            Rectangle workingArea = Screen.GetWorkingArea(this);
            Location = new Point(workingArea.Right - Width - 10, workingArea.Bottom - Height - 10);

            Month.initialize();
            SortFolders();
        }

        private bool IsSortable()
        {
            DateTime lastSort = Settings.Default.lastSort;
            SetLastSort(lastSort);

            if (Settings.Default.folders == null || Settings.Default.folders.Count == 0)
            {
                btnSort.Enabled = false;
                sortToolStripMenuItem.Enabled = false;
                btnFolders.Text = "Добавить папки";
                SetMessage("Не указаны папки для сортировки", Color.DarkRed);
                ShowForm();
                return false;
            }
            else
            {
                btnSort.Enabled = true;
                sortToolStripMenuItem.Enabled = true;
                btnFolders.Text = "Список папок";
                sortingFolders = Settings.Default.folders;
                return true;
            }
        }

        private void SortCheck()
        {
            int unsortedCount = 0;
            int maxCount = sortingFolders.Count;

            foreach (ISortingFolder sortingFolder in sortingFolders)
            {
                if (!sortingFolder.IsSorted)
                {
                    unsortedCount++;
                }
            }

            if (unsortedCount == maxCount)
            {
                SetMessage("Не удалось отсортировать папки", Color.DarkRed);
            }
            else if (unsortedCount > 0)
            {
                SetMessage($"Есть неотсортированные папки: {unsortedCount}/{maxCount}", Color.Orange);
            }
            else
            {
                SetMessage("Сортировка включена", Color.Green);
            }
        }

        private void SortFolders()
        {
            if (!IsSortable()) return;

            foreach (ISortingFolder sortingFolder in sortingFolders)
            {
                if (!Directory.Exists(sortingFolder.DirectoryPath))
                {
                    sortingFolder.IsSorted = false;
                    sortingFolder.Erorr = "Папка не существует";
                    break;
                }

                List<IFile> files = new IFile().getFiles(sortingFolder.DirectoryPath);
                List<IDirectory> directories = new IDirectory().getDirectories(sortingFolder.DirectoryPath);

                foreach (IFile file in files)
                {
                    MoveFileToMonthFolder(sortingFolder.DirectoryPath, file);
                }

                foreach (IDirectory directory in directories)
                {
                    MoveDirectoryToMonthFolder(sortingFolder.DirectoryPath, directory);
                }

                sortingFolder.IsSorted = true;
                sortingFolder.Erorr = "";
            }

            DateTime lastSort = DateTime.Now;
            SetLastSort(lastSort);

            Settings.Default.folders = sortingFolders;
            Settings.Default.Save();

            SortCheck();
        }

        private string CreateMonthFolder(string path, DateTime dateTime)
        {
            string monthName = dateTime.ToString("MMMM");
            int monthId = Month.getMonthId(monthName);
            string folderName = monthId + ". " + monthName + " " + dateTime.Year;
            string folderPath = Path.Combine(path, folderName);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            return folderPath;
        }

        private string CreateArchiveFolder(string path, string year)
        {
            string folderPath = Path.Combine(path, "Архив " + year);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            return folderPath;
        }

        private void MoveFileToMonthFolder(string path, IFile file)
        {
            string folderPath = CreateMonthFolder(path, file.Date);
            string newFilePath = Path.Combine(folderPath, file.Name);

            if (File.Exists(newFilePath))
            {
                newFilePath = Path.Combine(folderPath, Guid.NewGuid() + file.Name);
            }

            File.Move(file.FilePath, newFilePath);
        }

        private void MoveDirectoryToMonthFolder(string path, IDirectory directory)
        {
            if (directory.Name.Contains("Архив")) return;

            if (Month.isMonthFolder(directory.Name))
            {
                string year = directory.DirectoryPath.Split(' ').Last();

                if (year == currentDate.Year.ToString()) return;

                string archiveFolderPath = CreateArchiveFolder(path, year);
                Directory.Move(directory.DirectoryPath, Path.Combine(archiveFolderPath, directory.Name));
                return;
            }

            string folderPath = CreateMonthFolder(path, directory.Date);
            string newDirectoryPath = Path.Combine(folderPath, directory.Name);

            if (Directory.Exists(newDirectoryPath))
            {
                newDirectoryPath = Path.Combine(folderPath, Guid.NewGuid() + directory.Name);
            }

            Directory.Move(directory.DirectoryPath, newDirectoryPath);
        }

        private void SetMessage(string msg, Color color)
        {
            lblMessage.Text = msg;
            lblMessage.ForeColor = color;

            messageToolStripMenuItem.Text = msg;
            messageToolStripMenuItem.ForeColor = color;
        }

        private void SetLastSort(DateTime lastSort)
        {
            if (lastSort.Year == 0001)
            {
                string msg = "Последняя сортировка: никогда";
                notifyIcon.Text = "Folder Sorting\n" + msg;
                lblLastSort.Text = msg;
            }
            else
            {
                string msg = "Последняя сортировка: " + lastSort.ToString("dd.MM.yyyy HH:mm");
                notifyIcon.Text = "Folder Sorting\n" + msg;
                lblLastSort.Text = msg;
                Settings.Default.lastSort = lastSort;
                Settings.Default.Save();
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            SortFolders();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                allowShowDisplay = true;
                Visible = !Visible;
            }
        }

        private void fmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            Environment.Exit(0);
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void sortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortFolders();
        }

        private void messageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void btnFolders_Click(object sender, EventArgs e)
        {
            using (fmFolders folders = new fmFolders())
            {
                folders.ShowDialog();
                SortFolders();
            }
        }

        private void foldersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (fmFolders folders = new fmFolders())
            {
                folders.ShowDialog();
                SortFolders();
            }
        }
    }
}
