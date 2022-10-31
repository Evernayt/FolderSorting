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
            this.tbxFolderPath = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblLastSort = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.messageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxFolderPath
            // 
            this.tbxFolderPath.BackColor = System.Drawing.Color.White;
            this.tbxFolderPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxFolderPath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxFolderPath.ForeColor = System.Drawing.Color.Black;
            this.tbxFolderPath.Location = new System.Drawing.Point(13, 61);
            this.tbxFolderPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxFolderPath.Name = "tbxFolderPath";
            this.tbxFolderPath.ReadOnly = true;
            this.tbxFolderPath.Size = new System.Drawing.Size(185, 25);
            this.tbxFolderPath.TabIndex = 1;
            this.tbxFolderPath.TabStop = false;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(206, 59);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(105, 29);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Выбрать папку";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
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
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSort.ForeColor = System.Drawing.Color.White;
            this.btnSort.Location = new System.Drawing.Point(12, 92);
            this.btnSort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(299, 29);
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
            this.showToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
            this.cmsNotify.Name = "cmsNotify";
            this.cmsNotify.ShowImageMargin = false;
            this.cmsNotify.Size = new System.Drawing.Size(186, 107);
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
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.showToolStripMenuItem.Text = "Показать";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
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
            this.ClientSize = new System.Drawing.Size(324, 134);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lblLastSort);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.tbxFolderPath);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folder Sorting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmMain_FormClosing);
            this.cmsNotify.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxFolderPath;
        private System.Windows.Forms.Button btnSelect;
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
    }
}

