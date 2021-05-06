
namespace Task1
{
    partial class AwardUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserIDcheckedList = new System.Windows.Forms.CheckedListBox();
            this.awardTitleCheckedlist = new System.Windows.Forms.CheckedListBox();
            this.awardUserbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User\'s ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Award\'s Title:";
            // 
            // UserIDcheckedList
            // 
            this.UserIDcheckedList.FormattingEnabled = true;
            this.UserIDcheckedList.Location = new System.Drawing.Point(177, 36);
            this.UserIDcheckedList.Margin = new System.Windows.Forms.Padding(2);
            this.UserIDcheckedList.Name = "UserIDcheckedList";
            this.UserIDcheckedList.Size = new System.Drawing.Size(158, 79);
            this.UserIDcheckedList.TabIndex = 2;
            this.UserIDcheckedList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.UserIDcheckedList_ItemCheck);
            // 
            // awardTitleCheckedlist
            // 
            this.awardTitleCheckedlist.FormattingEnabled = true;
            this.awardTitleCheckedlist.Location = new System.Drawing.Point(177, 191);
            this.awardTitleCheckedlist.Margin = new System.Windows.Forms.Padding(2);
            this.awardTitleCheckedlist.Name = "awardTitleCheckedlist";
            this.awardTitleCheckedlist.Size = new System.Drawing.Size(158, 79);
            this.awardTitleCheckedlist.TabIndex = 3;
            // 
            // awardUserbtn
            // 
            this.awardUserbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.awardUserbtn.Location = new System.Drawing.Point(240, 320);
            this.awardUserbtn.Margin = new System.Windows.Forms.Padding(2);
            this.awardUserbtn.Name = "awardUserbtn";
            this.awardUserbtn.Size = new System.Drawing.Size(120, 41);
            this.awardUserbtn.TabIndex = 4;
            this.awardUserbtn.Text = "Add award(s)";
            this.awardUserbtn.UseVisualStyleBackColor = true;
            this.awardUserbtn.Click += new System.EventHandler(this.AwardUserbtn_Click);
            // 
            // AwardUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 378);
            this.Controls.Add(this.awardUserbtn);
            this.Controls.Add(this.awardTitleCheckedlist);
            this.Controls.Add(this.UserIDcheckedList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AwardUser";
            this.Text = "Award user";
            this.Load += new System.EventHandler(this.AwardUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox UserIDcheckedList;
        private System.Windows.Forms.CheckedListBox awardTitleCheckedlist;
        private System.Windows.Forms.Button awardUserbtn;
    }
}