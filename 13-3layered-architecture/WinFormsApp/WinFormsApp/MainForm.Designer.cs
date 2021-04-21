
namespace WinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.ctlFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlFileRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlFileEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlFileRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlTab = new System.Windows.Forms.TabControl();
            this.ctlUsersPage = new System.Windows.Forms.TabPage();
            this.ctlUsers = new System.Windows.Forms.DataGridView();
            this.ctlAwardsPage = new System.Windows.Forms.TabPage();
            this.ctlAwards = new System.Windows.Forms.DataGridView();
            this.sortAwardsdescbtn = new System.Windows.Forms.Button();
            this.sortAwardsascbtn = new System.Windows.Forms.Button();
            this.sortUserascbtn = new System.Windows.Forms.Button();
            this.sortUserdescbtn = new System.Windows.Forms.Button();
            this.mainMenu.SuspendLayout();
            this.ctlTab.SuspendLayout();
            this.ctlUsersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlUsers)).BeginInit();
            this.ctlAwardsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlAwards)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlFile,
            this.ctlAbout});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(772, 28);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // ctlFile
            // 
            this.ctlFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlFileRegister,
            this.ctlFileEdit,
            this.ctlFileRemove,
            this.ctlFileExit});
            this.ctlFile.Name = "ctlFile";
            this.ctlFile.Size = new System.Drawing.Size(46, 24);
            this.ctlFile.Text = "File";
            // 
            // ctlFileRegister
            // 
            this.ctlFileRegister.Name = "ctlFileRegister";
            this.ctlFileRegister.Size = new System.Drawing.Size(146, 26);
            this.ctlFileRegister.Text = "Register";
            this.ctlFileRegister.Click += new System.EventHandler(this.FileRegister_Click);
            // 
            // ctlFileEdit
            // 
            this.ctlFileEdit.Name = "ctlFileEdit";
            this.ctlFileEdit.Size = new System.Drawing.Size(146, 26);
            this.ctlFileEdit.Text = "Edit";
            // 
            // ctlFileRemove
            // 
            this.ctlFileRemove.Name = "ctlFileRemove";
            this.ctlFileRemove.Size = new System.Drawing.Size(146, 26);
            this.ctlFileRemove.Text = "Remove";
            // 
            // ctlFileExit
            // 
            this.ctlFileExit.Name = "ctlFileExit";
            this.ctlFileExit.Size = new System.Drawing.Size(146, 26);
            this.ctlFileExit.Text = "Exit";
            this.ctlFileExit.Click += new System.EventHandler(this.FileExit_Click);
            // 
            // ctlAbout
            // 
            this.ctlAbout.Name = "ctlAbout";
            this.ctlAbout.Size = new System.Drawing.Size(64, 24);
            this.ctlAbout.Text = "About";
            // 
            // ctlTab
            // 
            this.ctlTab.Controls.Add(this.ctlUsersPage);
            this.ctlTab.Controls.Add(this.ctlAwardsPage);
            this.ctlTab.Location = new System.Drawing.Point(12, 31);
            this.ctlTab.Name = "ctlTab";
            this.ctlTab.SelectedIndex = 0;
            this.ctlTab.Size = new System.Drawing.Size(748, 376);
            this.ctlTab.TabIndex = 1;
            // 
            // ctlUsersPage
            // 
            this.ctlUsersPage.Controls.Add(this.sortUserascbtn);
            this.ctlUsersPage.Controls.Add(this.sortUserdescbtn);
            this.ctlUsersPage.Controls.Add(this.ctlUsers);
            this.ctlUsersPage.Location = new System.Drawing.Point(4, 29);
            this.ctlUsersPage.Name = "ctlUsersPage";
            this.ctlUsersPage.Padding = new System.Windows.Forms.Padding(3);
            this.ctlUsersPage.Size = new System.Drawing.Size(740, 343);
            this.ctlUsersPage.TabIndex = 0;
            this.ctlUsersPage.Text = "Users";
            this.ctlUsersPage.UseVisualStyleBackColor = true;
            // 
            // ctlUsers
            // 
            this.ctlUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlUsers.Location = new System.Drawing.Point(3, 3);
            this.ctlUsers.Name = "ctlUsers";
            this.ctlUsers.RowHeadersWidth = 51;
            this.ctlUsers.RowTemplate.Height = 29;
            this.ctlUsers.Size = new System.Drawing.Size(734, 272);
            this.ctlUsers.TabIndex = 0;
            // 
            // ctlAwardsPage
            // 
            this.ctlAwardsPage.Controls.Add(this.sortAwardsascbtn);
            this.ctlAwardsPage.Controls.Add(this.sortAwardsdescbtn);
            this.ctlAwardsPage.Controls.Add(this.ctlAwards);
            this.ctlAwardsPage.Location = new System.Drawing.Point(4, 29);
            this.ctlAwardsPage.Name = "ctlAwardsPage";
            this.ctlAwardsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ctlAwardsPage.Size = new System.Drawing.Size(740, 343);
            this.ctlAwardsPage.TabIndex = 1;
            this.ctlAwardsPage.Text = "Awards";
            this.ctlAwardsPage.UseVisualStyleBackColor = true;
            // 
            // ctlAwards
            // 
            this.ctlAwards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlAwards.Location = new System.Drawing.Point(3, 3);
            this.ctlAwards.Name = "ctlAwards";
            this.ctlAwards.RowHeadersWidth = 51;
            this.ctlAwards.RowTemplate.Height = 29;
            this.ctlAwards.Size = new System.Drawing.Size(734, 277);
            this.ctlAwards.TabIndex = 0;
            // 
            // sortAwardsdescbtn
            // 
            this.sortAwardsdescbtn.Location = new System.Drawing.Point(601, 297);
            this.sortAwardsdescbtn.Name = "sortAwardsdescbtn";
            this.sortAwardsdescbtn.Size = new System.Drawing.Size(120, 33);
            this.sortAwardsdescbtn.TabIndex = 1;
            this.sortAwardsdescbtn.Text = "Sort: Desc";
            this.sortAwardsdescbtn.UseVisualStyleBackColor = true;
            // 
            // sortAwardsascbtn
            // 
            this.sortAwardsascbtn.Location = new System.Drawing.Point(463, 297);
            this.sortAwardsascbtn.Name = "sortAwardsascbtn";
            this.sortAwardsascbtn.Size = new System.Drawing.Size(123, 33);
            this.sortAwardsascbtn.TabIndex = 2;
            this.sortAwardsascbtn.Text = "Sort: Asc";
            this.sortAwardsascbtn.UseVisualStyleBackColor = true;
            // 
            // sortUserascbtn
            // 
            this.sortUserascbtn.Location = new System.Drawing.Point(462, 292);
            this.sortUserascbtn.Name = "sortUserascbtn";
            this.sortUserascbtn.Size = new System.Drawing.Size(123, 33);
            this.sortUserascbtn.TabIndex = 4;
            this.sortUserascbtn.Text = "Sort: Asc";
            this.sortUserascbtn.UseVisualStyleBackColor = true;
            // 
            // sortUserdescbtn
            // 
            this.sortUserdescbtn.Location = new System.Drawing.Point(600, 292);
            this.sortUserdescbtn.Name = "sortUserdescbtn";
            this.sortUserdescbtn.Size = new System.Drawing.Size(120, 33);
            this.sortUserdescbtn.TabIndex = 3;
            this.sortUserdescbtn.Text = "Sort: Desc";
            this.sortUserdescbtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 430);
            this.Controls.Add(this.ctlTab);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Users & awards";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ctlTab.ResumeLayout(false);
            this.ctlUsersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctlUsers)).EndInit();
            this.ctlAwardsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctlAwards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem ctlFile;
        private System.Windows.Forms.ToolStripMenuItem ctlAbout;
        private System.Windows.Forms.ToolStripMenuItem ctlFileRegister;
        private System.Windows.Forms.ToolStripMenuItem ctlFileEdit;
        private System.Windows.Forms.ToolStripMenuItem ctlFileRemove;
        private System.Windows.Forms.ToolStripMenuItem ctlFileExit;
        private System.Windows.Forms.TabControl ctlTab;
        private System.Windows.Forms.TabPage ctlUsersPage;
        private System.Windows.Forms.TabPage ctlAwardsPage;
        private System.Windows.Forms.DataGridView ctlUsers;
        private System.Windows.Forms.DataGridView ctlAwards;
        private System.Windows.Forms.Button sortUserascbtn;
        private System.Windows.Forms.Button sortUserdescbtn;
        private System.Windows.Forms.Button sortAwardsascbtn;
        private System.Windows.Forms.Button sortAwardsdescbtn;
    }
}

