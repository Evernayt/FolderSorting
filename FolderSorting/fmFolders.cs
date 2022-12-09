using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FolderSorting.models;
using FolderSorting.Properties;

namespace FolderSorting
{
    public partial class fmFolders : Form
    {
        private List<ISortingFolder> sortingFolders = new List<ISortingFolder>();
        private ToolTip toolTip;

        public fmFolders()
        {
            InitializeComponent();

            Rectangle workingArea = Screen.GetWorkingArea(this);
            Location = new Point(workingArea.Right - Width - 10, workingArea.Bottom - Height - 154);

            dataGridView1.Columns["IsSorted"].DefaultCellStyle.NullValue = null;
            dataGridView1.Columns["Remove"].DefaultCellStyle.NullValue = null;
            dataGridView1.ShowCellToolTips = false;
        }

        private void fmFolders_Load(object sender, EventArgs e)
        {
            LoadAddedFolders();
        }

        private void LoadAddedFolders()
        {
            if (Settings.Default.folders == null) return;

            dataGridView1.Rows.Clear();
            sortingFolders = Settings.Default.folders;
            foreach (ISortingFolder sortingFolder in sortingFolders)
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells["IsSorted"].Value = sortingFolder.IsSorted ? Resources.check : Resources.warning;
                dataGridView1.Rows[rowIndex].Cells["Folder"].Value = sortingFolder.DirectoryPath;
                dataGridView1.Rows[rowIndex].Cells["Remove"].Value = Resources.close;
                dataGridView1.Rows[rowIndex].Cells["Error"].Value = sortingFolder.Erorr;
            }
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string folder = folderBrowserDialog.SelectedPath;

                    foreach (ISortingFolder sortingFolder in sortingFolders)
                    {
                        if (sortingFolder.DirectoryPath == folder)
                        {
                            return;
                        }
                    }

                    int rowIndex = dataGridView1.Rows.Add();
                    string error = "Еще не сортировалось";
                    dataGridView1.Rows[rowIndex].Cells["IsSorted"].Value = Resources.warning;
                    dataGridView1.Rows[rowIndex].Cells["Folder"].Value = folder;
                    dataGridView1.Rows[rowIndex].Cells["Remove"].Value = Resources.close;
                    dataGridView1.Rows[rowIndex].Cells["Error"].Value = error;

                    sortingFolders.Add(new ISortingFolder
                    {
                        DirectoryPath = folder,
                        IsSorted = false,
                        Erorr = error
                    });

                    Settings.Default.folders = sortingFolders;
                    Settings.Default.Save();
                }
            }
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            if (e.ColumnIndex == 0)
            {
                toolTip = new ToolTip();
                toolTip.SetToolTip(dataGridView1, row.Cells["Error"].Value.ToString());
            }
            else if (e.ColumnIndex == 2)
            {
                row.Cells[e.ColumnIndex].Value = Resources.close_hover;
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            if (e.ColumnIndex == 0)
            {
                if (toolTip != null)
                    toolTip.Dispose();
            }
            else if (e.ColumnIndex == 2)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                row.Cells[e.ColumnIndex].Value = Resources.close;
            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;

            if (e.ColumnIndex == 2)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                ISortingFolder sortingFolder = sortingFolders.Single(x => x.DirectoryPath == row.Cells["Folder"].Value.ToString());
                sortingFolders.Remove(sortingFolder);

                Settings.Default.folders = sortingFolders;
                Settings.Default.Save();

                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
            //Settings.Default.Reset();
            //MessageBox.Show(e.ColumnIndex.ToString());
        }
    }
}
