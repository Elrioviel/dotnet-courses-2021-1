
namespace Task1
{
    partial class MainForm
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.ctlFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlFileRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlFileEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlFileRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlAwardUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlTab = new System.Windows.Forms.TabControl();
            this.ctlUsersPage = new System.Windows.Forms.TabPage();
            this.sortUserascbtn = new System.Windows.Forms.Button();
            this.sortUserdescbtn = new System.Windows.Forms.Button();
            this.ctlUsers = new System.Windows.Forms.DataGridView();
            this.ctlAwardsPage = new System.Windows.Forms.TabPage();
            this.sortAwardsascbtn = new System.Windows.Forms.Button();
            this.sortAwardsdescbtn = new System.Windows.Forms.Button();
            this.ctlAwards = new System.Windows.Forms.DataGridView();
            this.ctlAwardsUserTab = new System.Windows.Forms.TabPage();
            this.deleteAward = new System.Windows.Forms.Button();
            this.ctlAwardsUser = new System.Windows.Forms.DataGridView();
            this.mainMenu.SuspendLayout();
            this.ctlTab.SuspendLayout();
            this.ctlUsersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlUsers)).BeginInit();
            this.ctlAwardsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlAwards)).BeginInit();
            this.ctlAwardsUserTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlAwardsUser)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlFile});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(43, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // ctlFile
            // 
            this.ctlFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlFileRegister,
            this.ctlFileEdit,
            this.ctlFileRemove,
            this.ctlAwardUsers,
            this.ctlFileExit});
            this.ctlFile.Name = "ctlFile";
            this.ctlFile.Size = new System.Drawing.Size(37, 20);
            this.ctlFile.Text = "File";
            // 
            // ctlFileRegister
            // 
            this.ctlFileRegister.Name = "ctlFileRegister";
            this.ctlFileRegister.Size = new System.Drawing.Size(133, 22);
            this.ctlFileRegister.Text = "Register";
            this.ctlFileRegister.Click += new System.EventHandler(this.FileRegister_Click);
            // 
            // ctlFileEdit
            // 
            this.ctlFileEdit.Name = "ctlFileEdit";
            this.ctlFileEdit.Size = new System.Drawing.Size(133, 22);
            this.ctlFileEdit.Text = "Edit";
            this.ctlFileEdit.Click += new System.EventHandler(this.FileEdit_Click);
            // 
            // ctlFileRemove
            // 
            this.ctlFileRemove.Name = "ctlFileRemove";
            this.ctlFileRemove.Size = new System.Drawing.Size(133, 22);
            this.ctlFileRemove.Text = "Remove";
            this.ctlFileRemove.Click += new System.EventHandler(this.FileRemove_Click);
            // 
            // ctlFileExit
            // 
            this.ctlFileExit.Name = "ctlFileExit";
            this.ctlFileExit.Size = new System.Drawing.Size(133, 22);
            this.ctlFileExit.Text = "Exit";
            this.ctlFileExit.Click += new System.EventHandler(this.FileExit_Click);
            // 
            // ctlAwardUsers
            // 
            this.ctlAwardUsers.Name = "ctlAwardUsers";
            this.ctlAwardUsers.Size = new System.Drawing.Size(133, 22);
            this.ctlAwardUsers.Text = "Award user";
            this.ctlAwardUsers.Click += new System.EventHandler(this.AwardUsers_Click);
            // 
            // ctlTab
            // 
            this.ctlTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlTab.Controls.Add(this.ctlUsersPage);
            this.ctlTab.Controls.Add(this.ctlAwardsPage);
            this.ctlTab.Controls.Add(this.ctlAwardsUserTab);
            this.ctlTab.Location = new System.Drawing.Point(0, 25);
            this.ctlTab.Margin = new System.Windows.Forms.Padding(2);
            this.ctlTab.Name = "ctlTab";
            this.ctlTab.SelectedIndex = 0;
            this.ctlTab.Size = new System.Drawing.Size(621, 353);
            this.ctlTab.TabIndex = 1;
            // 
            // ctlUsersPage
            // 
            this.ctlUsersPage.Controls.Add(this.sortUserascbtn);
            this.ctlUsersPage.Controls.Add(this.sortUserdescbtn);
            this.ctlUsersPage.Controls.Add(this.ctlUsers);
            this.ctlUsersPage.Location = new System.Drawing.Point(4, 22);
            this.ctlUsersPage.Margin = new System.Windows.Forms.Padding(2);
            this.ctlUsersPage.Name = "ctlUsersPage";
            this.ctlUsersPage.Padding = new System.Windows.Forms.Padding(2);
            this.ctlUsersPage.Size = new System.Drawing.Size(613, 327);
            this.ctlUsersPage.TabIndex = 0;
            this.ctlUsersPage.Text = "Users";
            this.ctlUsersPage.UseVisualStyleBackColor = true;
            // 
            // sortUserascbtn
            // 
            this.sortUserascbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sortUserascbtn.Location = new System.Drawing.Point(348, 266);
            this.sortUserascbtn.Margin = new System.Windows.Forms.Padding(2);
            this.sortUserascbtn.Name = "sortUserascbtn";
            this.sortUserascbtn.Size = new System.Drawing.Size(111, 28);
            this.sortUserascbtn.TabIndex = 2;
            this.sortUserascbtn.Text = "Sort: Asc";
            this.sortUserascbtn.UseVisualStyleBackColor = true;
            this.sortUserascbtn.Click += new System.EventHandler(this.SortUserascbtn_Click);
            // 
            // sortUserdescbtn
            // 
            this.sortUserdescbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sortUserdescbtn.Location = new System.Drawing.Point(470, 266);
            this.sortUserdescbtn.Margin = new System.Windows.Forms.Padding(2);
            this.sortUserdescbtn.Name = "sortUserdescbtn";
            this.sortUserdescbtn.Size = new System.Drawing.Size(110, 28);
            this.sortUserdescbtn.TabIndex = 1;
            this.sortUserdescbtn.Text = "Sort: Desc";
            this.sortUserdescbtn.UseVisualStyleBackColor = true;
            this.sortUserdescbtn.Click += new System.EventHandler(this.SortUserdescbtn_Click);
            // 
            // ctlUsers
            // 
            this.ctlUsers.AllowUserToAddRows = false;
            this.ctlUsers.AllowUserToDeleteRows = false;
            this.ctlUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlUsers.Location = new System.Drawing.Point(6, 6);
            this.ctlUsers.Margin = new System.Windows.Forms.Padding(2);
            this.ctlUsers.Name = "ctlUsers";
            this.ctlUsers.ReadOnly = true;
            this.ctlUsers.RowHeadersWidth = 51;
            this.ctlUsers.RowTemplate.Height = 24;
            this.ctlUsers.Size = new System.Drawing.Size(574, 246);
            this.ctlUsers.TabIndex = 0;
            // 
            // ctlAwardsPage
            // 
            this.ctlAwardsPage.Controls.Add(this.sortAwardsascbtn);
            this.ctlAwardsPage.Controls.Add(this.sortAwardsdescbtn);
            this.ctlAwardsPage.Controls.Add(this.ctlAwards);
            this.ctlAwardsPage.Location = new System.Drawing.Point(4, 22);
            this.ctlAwardsPage.Margin = new System.Windows.Forms.Padding(2);
            this.ctlAwardsPage.Name = "ctlAwardsPage";
            this.ctlAwardsPage.Padding = new System.Windows.Forms.Padding(2);
            this.ctlAwardsPage.Size = new System.Drawing.Size(613, 327);
            this.ctlAwardsPage.TabIndex = 1;
            this.ctlAwardsPage.Text = "Awards";
            this.ctlAwardsPage.UseVisualStyleBackColor = true;
            // 
            // sortAwardsascbtn
            // 
            this.sortAwardsascbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sortAwardsascbtn.Location = new System.Drawing.Point(349, 266);
            this.sortAwardsascbtn.Margin = new System.Windows.Forms.Padding(2);
            this.sortAwardsascbtn.Name = "sortAwardsascbtn";
            this.sortAwardsascbtn.Size = new System.Drawing.Size(111, 28);
            this.sortAwardsascbtn.TabIndex = 4;
            this.sortAwardsascbtn.Text = "Sort: Asc";
            this.sortAwardsascbtn.UseVisualStyleBackColor = true;
            this.sortAwardsascbtn.Click += new System.EventHandler(this.SortAwardsascbtn_Click);
            // 
            // sortAwardsdescbtn
            // 
            this.sortAwardsdescbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sortAwardsdescbtn.Location = new System.Drawing.Point(470, 266);
            this.sortAwardsdescbtn.Margin = new System.Windows.Forms.Padding(2);
            this.sortAwardsdescbtn.Name = "sortAwardsdescbtn";
            this.sortAwardsdescbtn.Size = new System.Drawing.Size(110, 28);
            this.sortAwardsdescbtn.TabIndex = 3;
            this.sortAwardsdescbtn.Text = "Sort: Desc";
            this.sortAwardsdescbtn.UseVisualStyleBackColor = true;
            this.sortAwardsdescbtn.Click += new System.EventHandler(this.SortAwardsdescbtn_Click);
            // 
            // ctlAwards
            // 
            this.ctlAwards.AllowUserToAddRows = false;
            this.ctlAwards.AllowUserToDeleteRows = false;
            this.ctlAwards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlAwards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlAwards.Location = new System.Drawing.Point(6, 5);
            this.ctlAwards.Margin = new System.Windows.Forms.Padding(2);
            this.ctlAwards.Name = "ctlAwards";
            this.ctlAwards.ReadOnly = true;
            this.ctlAwards.RowHeadersWidth = 51;
            this.ctlAwards.RowTemplate.Height = 24;
            this.ctlAwards.Size = new System.Drawing.Size(574, 249);
            this.ctlAwards.TabIndex = 0;
            // 
            // ctlAwardsUserTab
            // 
            this.ctlAwardsUserTab.Controls.Add(this.deleteAward);
            this.ctlAwardsUserTab.Controls.Add(this.ctlAwardsUser);
            this.ctlAwardsUserTab.Location = new System.Drawing.Point(4, 22);
            this.ctlAwardsUserTab.Margin = new System.Windows.Forms.Padding(2);
            this.ctlAwardsUserTab.Name = "ctlAwardsUserTab";
            this.ctlAwardsUserTab.Padding = new System.Windows.Forms.Padding(2);
            this.ctlAwardsUserTab.Size = new System.Drawing.Size(613, 327);
            this.ctlAwardsUserTab.TabIndex = 2;
            this.ctlAwardsUserTab.Text = "Awarded users";
            this.ctlAwardsUserTab.UseVisualStyleBackColor = true;
            // 
            // deleteAward
            // 
            this.deleteAward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteAward.Location = new System.Drawing.Point(450, 279);
            this.deleteAward.Name = "deleteAward";
            this.deleteAward.Size = new System.Drawing.Size(158, 30);
            this.deleteAward.TabIndex = 1;
            this.deleteAward.Text = "Remove award";
            this.deleteAward.UseVisualStyleBackColor = true;
            this.deleteAward.Click += new System.EventHandler(this.DeleteAward_Click);
            // 
            // ctlAwardsUser
            // 
            this.ctlAwardsUser.AllowUserToAddRows = false;
            this.ctlAwardsUser.AllowUserToDeleteRows = false;
            this.ctlAwardsUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlAwardsUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlAwardsUser.Location = new System.Drawing.Point(10, 7);
            this.ctlAwardsUser.Name = "ctlAwardsUser";
            this.ctlAwardsUser.ReadOnly = true;
            this.ctlAwardsUser.Size = new System.Drawing.Size(598, 266);
            this.ctlAwardsUser.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 388);
            this.Controls.Add(this.ctlTab);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.ctlAwardsUserTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctlAwardsUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem ctlFile;
        private System.Windows.Forms.ToolStripMenuItem ctlFileRegister;
        private System.Windows.Forms.ToolStripMenuItem ctlFileEdit;
        private System.Windows.Forms.ToolStripMenuItem ctlFileRemove;
        private System.Windows.Forms.ToolStripMenuItem ctlFileExit;
        private System.Windows.Forms.TabControl ctlTab;
        private System.Windows.Forms.TabPage ctlUsersPage;
        private System.Windows.Forms.Button sortUserascbtn;
        private System.Windows.Forms.Button sortUserdescbtn;
        private System.Windows.Forms.DataGridView ctlUsers;
        private System.Windows.Forms.TabPage ctlAwardsPage;
        private System.Windows.Forms.DataGridView ctlAwards;
        private System.Windows.Forms.Button sortAwardsascbtn;
        private System.Windows.Forms.Button sortAwardsdescbtn;
        private System.Windows.Forms.ToolStripMenuItem ctlAwardUsers;
        private System.Windows.Forms.TabPage ctlAwardsUserTab;
        private System.Windows.Forms.DataGridView ctlAwardsUser;
        private System.Windows.Forms.Button deleteAward;
    }
}

