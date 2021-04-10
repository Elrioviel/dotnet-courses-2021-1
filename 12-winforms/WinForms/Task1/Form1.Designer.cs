
namespace Task1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.UserTab = new System.Windows.Forms.TabPage();
            this.aSortBtn = new System.Windows.Forms.Button();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.RemoveUserBtn = new System.Windows.Forms.Button();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.awardsTab = new System.Windows.Forms.TabPage();
            this.awardsDataGridView = new System.Windows.Forms.DataGridView();
            this.ExitBtn2 = new System.Windows.Forms.Button();
            this.RemoveAwardBtn = new System.Windows.Forms.Button();
            this.AddAwardBtn = new System.Windows.Forms.Button();
            this.userAwardbtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.UserTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.awardsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.awardsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.UserTab);
            this.tabControl1.Controls.Add(this.awardsTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(958, 582);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // UserTab
            // 
            this.UserTab.BackColor = System.Drawing.Color.AliceBlue;
            this.UserTab.Controls.Add(this.aSortBtn);
            this.UserTab.Controls.Add(this.userDataGridView);
            this.UserTab.Controls.Add(this.ExitBtn);
            this.UserTab.Controls.Add(this.RemoveUserBtn);
            this.UserTab.Controls.Add(this.AddUserBtn);
            this.UserTab.Location = new System.Drawing.Point(4, 29);
            this.UserTab.Name = "UserTab";
            this.UserTab.Padding = new System.Windows.Forms.Padding(3);
            this.UserTab.Size = new System.Drawing.Size(950, 549);
            this.UserTab.TabIndex = 0;
            this.UserTab.Text = "User";
            this.UserTab.Click += new System.EventHandler(this.UserTab_Click);
            // 
            // aSortBtn
            // 
            this.aSortBtn.Location = new System.Drawing.Point(363, 479);
            this.aSortBtn.Name = "aSortBtn";
            this.aSortBtn.Size = new System.Drawing.Size(165, 53);
            this.aSortBtn.TabIndex = 10;
            this.aSortBtn.Text = "Sort users by age";
            this.aSortBtn.UseVisualStyleBackColor = true;
            this.aSortBtn.Click += new System.EventHandler(this.aSortBtn_Click);
            // 
            // userDataGridView
            // 
            this.userDataGridView.AllowUserToOrderColumns = true;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Location = new System.Drawing.Point(15, 12);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.ReadOnly = true;
            this.userDataGridView.RowHeadersWidth = 51;
            this.userDataGridView.RowTemplate.Height = 29;
            this.userDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userDataGridView.Size = new System.Drawing.Size(918, 444);
            this.userDataGridView.TabIndex = 9;
            this.userDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.userDataGridView_CellMouseDoubleClick);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(787, 479);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(146, 53);
            this.ExitBtn.TabIndex = 8;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // RemoveUserBtn
            // 
            this.RemoveUserBtn.Location = new System.Drawing.Point(188, 479);
            this.RemoveUserBtn.Name = "RemoveUserBtn";
            this.RemoveUserBtn.Size = new System.Drawing.Size(146, 53);
            this.RemoveUserBtn.TabIndex = 7;
            this.RemoveUserBtn.Text = "Remove";
            this.RemoveUserBtn.UseVisualStyleBackColor = true;
            this.RemoveUserBtn.Click += new System.EventHandler(this.RemoveUserBtn_Click);
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Location = new System.Drawing.Point(15, 479);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(146, 53);
            this.AddUserBtn.TabIndex = 5;
            this.AddUserBtn.Text = "Add";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            this.AddUserBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // awardsTab
            // 
            this.awardsTab.BackColor = System.Drawing.Color.AliceBlue;
            this.awardsTab.Controls.Add(this.awardsDataGridView);
            this.awardsTab.Controls.Add(this.ExitBtn2);
            this.awardsTab.Controls.Add(this.RemoveAwardBtn);
            this.awardsTab.Controls.Add(this.AddAwardBtn);
            this.awardsTab.Location = new System.Drawing.Point(4, 29);
            this.awardsTab.Name = "awardsTab";
            this.awardsTab.Padding = new System.Windows.Forms.Padding(3);
            this.awardsTab.Size = new System.Drawing.Size(950, 549);
            this.awardsTab.TabIndex = 1;
            this.awardsTab.Text = "Awards";
            // 
            // awardsDataGridView
            // 
            this.awardsDataGridView.AllowUserToOrderColumns = true;
            this.awardsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.awardsDataGridView.Location = new System.Drawing.Point(17, 14);
            this.awardsDataGridView.Name = "awardsDataGridView";
            this.awardsDataGridView.ReadOnly = true;
            this.awardsDataGridView.RowHeadersWidth = 51;
            this.awardsDataGridView.RowTemplate.Height = 29;
            this.awardsDataGridView.Size = new System.Drawing.Size(918, 454);
            this.awardsDataGridView.TabIndex = 13;
            this.awardsDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.awardsDataGridView_CellMouseDoubleClick);
            // 
            // ExitBtn2
            // 
            this.ExitBtn2.Location = new System.Drawing.Point(789, 483);
            this.ExitBtn2.Name = "ExitBtn2";
            this.ExitBtn2.Size = new System.Drawing.Size(146, 53);
            this.ExitBtn2.TabIndex = 12;
            this.ExitBtn2.Text = "Exit";
            this.ExitBtn2.UseVisualStyleBackColor = true;
            this.ExitBtn2.Click += new System.EventHandler(this.ExitBtn2_Click);
            // 
            // RemoveAwardBtn
            // 
            this.RemoveAwardBtn.Location = new System.Drawing.Point(193, 483);
            this.RemoveAwardBtn.Name = "RemoveAwardBtn";
            this.RemoveAwardBtn.Size = new System.Drawing.Size(146, 53);
            this.RemoveAwardBtn.TabIndex = 11;
            this.RemoveAwardBtn.Text = "Remove";
            this.RemoveAwardBtn.UseVisualStyleBackColor = true;
            this.RemoveAwardBtn.Click += new System.EventHandler(this.RemoveAwardBtn_Click);
            // 
            // AddAwardBtn
            // 
            this.AddAwardBtn.Location = new System.Drawing.Point(17, 483);
            this.AddAwardBtn.Name = "AddAwardBtn";
            this.AddAwardBtn.Size = new System.Drawing.Size(146, 53);
            this.AddAwardBtn.TabIndex = 9;
            this.AddAwardBtn.Text = "Add";
            this.AddAwardBtn.UseVisualStyleBackColor = true;
            this.AddAwardBtn.Click += new System.EventHandler(this.AddAwardBtn_Click);
            // 
            // userAwardbtn
            // 
            this.userAwardbtn.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.userAwardbtn.FlatAppearance.BorderSize = 10;
            this.userAwardbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.userAwardbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userAwardbtn.Location = new System.Drawing.Point(990, 41);
            this.userAwardbtn.Name = "userAwardbtn";
            this.userAwardbtn.Size = new System.Drawing.Size(129, 47);
            this.userAwardbtn.TabIndex = 1;
            this.userAwardbtn.Text = "Award users";
            this.userAwardbtn.UseVisualStyleBackColor = true;
            this.userAwardbtn.Click += new System.EventHandler(this.userAwardbtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1167, 601);
            this.Controls.Add(this.userAwardbtn);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Users and awards";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.UserTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.awardsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.awardsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage UserTab;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button RemoveUserBtn;
        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.TabPage awardsTab;
        private System.Windows.Forms.Button ExitBtn2;
        private System.Windows.Forms.Button RemoveAwardBtn;
        private System.Windows.Forms.Button AddAwardBtn;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.DataGridView awardsDataGridView;
        private System.Windows.Forms.Button userAwardbtn;
        private System.Windows.Forms.Button aSortBtn;
    }
}

