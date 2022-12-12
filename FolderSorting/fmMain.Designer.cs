namespace FolderSorting
{
    partial class fmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.btnFolders = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblLastSort = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.messageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foldersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFolders
            // 
            this.btnFolders.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFolders.FlatAppearance.BorderSize = 0;
            this.btnFolders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolders.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFolders.ForeColor = System.Drawing.Color.White;
            this.btnFolders.Location = new System.Drawing.Point(206, 57);
            this.btnFolders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFolders.Name = "btnFolders";
            this.btnFolders.Size = new System.Drawing.Size(105, 29);
            this.btnFolders.TabIndex = 2;
            this.btnFolders.Text = "Список папок";
            this.btnFolders.UseVisualStyleBackColor = false;
            this.btnFolders.Click += new System.EventHandler(this.btnFolders_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMessage.ForeColor = System.Drawing.Color.Green;
            this.lblMessage.Location = new System.Drawing.Point(13, 9);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(188, 21);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Сортировка включена";
            // 
            // lblLastSort
            // 
            this.lblLastSort.AutoSize = true;
            this.lblLastSort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastSort.ForeColor = System.Drawing.Color.Gray;
            this.lblLastSort.Location = new System.Drawing.Point(14, 30);
            this.lblLastSort.Name = "lblLastSort";
            this.lblLastSort.Size = new System.Drawing.Size(184, 15);
            this.lblLastSort.TabIndex = 3;
            this.lblLastSort.Text = "Последняя сортировка: никогда";
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.Gray;
            this.btnSort.Enabled = false;
            this.btnSort.FlatAppearance.BorderSize = 0;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSort.ForeColor = System.Drawing.Color.White;
            this.btnSort.Location = new System.Drawing.Point(12, 57);
            this.btnSort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(186, 29);
            this.btnSort.TabIndex = 5;
            this.btnSort.Text = "Отсортировать в ручную";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.cmsNotify;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Folder Sorting";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // cmsNotify
            // 
            this.cmsNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messageToolStripMenuItem,
            this.sortToolStripMenuItem,
            this.foldersToolStripMenuItem,
            this.showToolStripMenuItem,
            this.autorunToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
            this.cmsNotify.Name = "cmsNotify";
            this.cmsNotify.ShowImageMargin = false;
            this.cmsNotify.Size = new System.Drawing.Size(186, 173);
            // 
            // messageToolStripMenuItem
            // 
            this.messageToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.messageToolStripMenuItem.Name = "messageToolStripMenuItem";
            this.messageToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 1, 0, 10);
            this.messageToolStripMenuItem.Size = new System.Drawing.Size(185, 31);
            this.messageToolStripMenuItem.Text = "Сортировка включена";
            this.messageToolStripMenuItem.Click += new System.EventHandler(this.messageToolStripMenuItem1_Click);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.sortToolStripMenuItem.Text = "Отсортировать";
            this.sortToolStripMenuItem.Click += new System.EventHandler(this.sortToolStripMenuItem_Click);
            // 
            // foldersToolStripMenuItem
            // 
            this.foldersToolStripMenuItem.Name = "foldersToolStripMenuItem";
            this.foldersToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.foldersToolStripMenuItem.Text = "Список папок";
            this.foldersToolStripMenuItem.Click += new System.EventHandler(this.foldersToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.showToolStripMenuItem.Text = "Показать";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // autorunToolStripMenuItem
            // 
            this.autorunToolStripMenuItem.Checked = true;
            this.autorunToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autorunToolStripMenuItem.Name = "autorunToolStripMenuItem";
            this.autorunToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.autorunToolStripMenuItem.Text = "Автозапуск: Вкл";
            this.autorunToolStripMenuItem.Click += new System.EventHandler(this.autorunToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.closeToolStripMenuItem.Text = "Выход";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(324, 100);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lblLastSort);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnFolders);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Folder Sorting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmMain_FormClosing);
            this.cmsNotify.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFolders;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblLastSort;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip cmsNotify;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foldersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorunToolStripMenuItem;
    }
}

