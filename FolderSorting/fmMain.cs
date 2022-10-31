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
        string mainPath = Settings.Default.mainPath;
        DateTime currentDate = DateTime.Now;
        IMonth Month = new IMonth();

        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(allowShowDisplay ? value : allowShowDisplay);
        }

        private void showForm()
        {
            allowShowDisplay = true;
            Show();
        }

        public fmMain()
        {
            InitializeComponent();
            Month.initialize();
            sort();
        }

        private bool isSortable()
        {
            DateTime lastSort = Settings.Default.lastSort;
            tbxFolderPath.Text = mainPath;
            setLastSort(lastSort);
            btnSort.Enabled = false;

            if (mainPath == "")
            {
                setMessage("Не указана папка", Color.DarkRed);
                return false;
            }
            else
            {
                if (Directory.Exists(mainPath))
                {
                    setMessage("Сортировка включена", Color.Green);
                    btnSort.Enabled = true;
                    return true;
                }
                else
                {
                    setMessage("Папка не существует", Color.DarkRed);
                    return false;
                }
            }
        }

        private void sort()
        {
            if (!isSortable())
            {
                showForm();
                return;
            };

            List<IFile> files = new IFile().getFiles(mainPath);
            List<IDirectory> directories = new IDirectory().getDirectories(mainPath);

            foreach (IFile file in files)
            {
                moveFileToMonthFolder(file);
            }

            foreach (IDirectory directory in directories)
            {
                moveDirectoryToMonthFolder(directory);
            }

            DateTime lastSort = DateTime.Now;
            setLastSort(lastSort);
        }

        private string createMonthFolder(DateTime dateTime)
        {
            string monthName = dateTime.ToString("MMMM");
            int monthId = Month.getMonthId(monthName);
            string folderName = monthId + ". " + monthName + " " + dateTime.Year;
            string folderPath = Path.Combine(mainPath, folderName);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            return folderPath;
        }

        private string createArchiveFolder(string year)
        {
            string folderPath = Path.Combine(mainPath, "Архив " + year);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            return folderPath;
        }

        private void moveFileToMonthFolder(IFile file)
        {
            string folderPath = createMonthFolder(file.Date);
            string newFilePath = Path.Combine(folderPath, file.Name);

            if (File.Exists(newFilePath))
            {
                newFilePath = Path.Combine(folderPath, Guid.NewGuid() + file.Name);
            }

            File.Move(file.FilePath, newFilePath);
        }

        private void moveDirectoryToMonthFolder(IDirectory directory)
        {
            if (directory.Name.Contains("Архив")) return;

            if (Month.isMonthFolder(directory.Name))
            {
                string year = directory.DirectoryPath.Split(' ').Last();

                if (year == currentDate.Year.ToString()) return;

                string archiveFolderPath = createArchiveFolder(year);
                Directory.Move(directory.DirectoryPath, Path.Combine(archiveFolderPath, directory.Name));
                return;
            }

            string folderPath = createMonthFolder(directory.Date);
            string newDirectoryPath = Path.Combine(folderPath, directory.Name);

            if (Directory.Exists(newDirectoryPath))
            {
                newDirectoryPath = Path.Combine(folderPath, Guid.NewGuid() + directory.Name);
            }

            Directory.Move(directory.DirectoryPath, newDirectoryPath);
        }

        private void selectMainPath()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    mainPath = folderBrowserDialog.SelectedPath;
                    Settings.Default.mainPath = folderBrowserDialog.SelectedPath;
                    Settings.Default.Save();

                    isSortable();
                }
            }
        }

        private void setMessage(string msg, Color color)
        {
            lblMessage.Text = msg;
            lblMessage.ForeColor = color;

            messageToolStripMenuItem.Text = msg;
            messageToolStripMenuItem.ForeColor = color;
        }

        private void setLastSort(DateTime lastSort)
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            selectMainPath();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            sort();
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
            showForm();
        }

        private void sortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sort();
        }

        private void messageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showForm();
        }
    }
}
