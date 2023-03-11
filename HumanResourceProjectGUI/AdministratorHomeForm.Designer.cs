namespace HumanResourceProjectGUI
{
    partial class AdministratorHomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            employeeToolStripMenuItem = new ToolStripMenuItem();
            createNewToolStripMenuItem = new ToolStripMenuItem();
            AllHumanResourceView = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AllHumanResourceView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, employeeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logOutToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(152, 26);
            logOutToolStripMenuItem.Text = "Log out...";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // employeeToolStripMenuItem
            // 
            employeeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createNewToolStripMenuItem });
            employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            employeeToolStripMenuItem.Size = new Size(89, 24);
            employeeToolStripMenuItem.Text = "Employee";
            // 
            // createNewToolStripMenuItem
            // 
            createNewToolStripMenuItem.Name = "createNewToolStripMenuItem";
            createNewToolStripMenuItem.Size = new Size(178, 26);
            createNewToolStripMenuItem.Text = "Create New...";
            // 
            // AllHumanResourceView
            // 
            AllHumanResourceView.AllowUserToOrderColumns = true;
            AllHumanResourceView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllHumanResourceView.Dock = DockStyle.Fill;
            AllHumanResourceView.Location = new Point(0, 28);
            AllHumanResourceView.Name = "AllHumanResourceView";
            AllHumanResourceView.RowHeadersWidth = 51;
            AllHumanResourceView.RowTemplate.Height = 29;
            AllHumanResourceView.Size = new Size(800, 422);
            AllHumanResourceView.TabIndex = 1;
            // 
            // AdministratorHomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AllHumanResourceView);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AdministratorHomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdministratorHomeForm";
            WindowState = FormWindowState.Maximized;
            FormClosed += AdministratorHomeForm_FormClosed;
            Load += AdministratorHomeForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AllHumanResourceView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem employeeToolStripMenuItem;
        private ToolStripMenuItem createNewToolStripMenuItem;
        private DataGridView AllHumanResourceView;
    }
}