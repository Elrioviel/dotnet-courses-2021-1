
namespace Task1
{
    partial class UserEdit
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
            this.label3 = new System.Windows.Forms.Label();
            this.editedFirstNametxt = new System.Windows.Forms.TextBox();
            this.editedLastNametxt = new System.Windows.Forms.TextBox();
            this.editedBirthdatepicker = new System.Windows.Forms.DateTimePicker();
            this.savebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name:*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last name:*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of birth:*";
            // 
            // editedFirstNametxt
            // 
            this.editedFirstNametxt.Location = new System.Drawing.Point(170, 43);
            this.editedFirstNametxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editedFirstNametxt.Name = "editedFirstNametxt";
            this.editedFirstNametxt.Size = new System.Drawing.Size(216, 20);
            this.editedFirstNametxt.TabIndex = 4;
            this.editedFirstNametxt.Validated += new System.EventHandler(this.EditedFirstNametxt_Validated);
            // 
            // editedLastNametxt
            // 
            this.editedLastNametxt.Location = new System.Drawing.Point(170, 113);
            this.editedLastNametxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editedLastNametxt.Name = "editedLastNametxt";
            this.editedLastNametxt.Size = new System.Drawing.Size(216, 20);
            this.editedLastNametxt.TabIndex = 5;
            this.editedLastNametxt.Validated += new System.EventHandler(this.EditedLastNametxt_Validated);
            // 
            // editedBirthdatepicker
            // 
            this.editedBirthdatepicker.Location = new System.Drawing.Point(170, 184);
            this.editedBirthdatepicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editedBirthdatepicker.MaxDate = new System.DateTime(2003, 12, 31, 0, 0, 0, 0);
            this.editedBirthdatepicker.MinDate = new System.DateTime(1951, 1, 1, 0, 0, 0, 0);
            this.editedBirthdatepicker.Name = "editedBirthdatepicker";
            this.editedBirthdatepicker.Size = new System.Drawing.Size(216, 20);
            this.editedBirthdatepicker.TabIndex = 6;
            this.editedBirthdatepicker.Value = new System.DateTime(2003, 12, 31, 0, 0, 0, 0);
            this.editedBirthdatepicker.Validated += new System.EventHandler(this.EditedBirthdatepicker_Validated);
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(277, 272);
            this.savebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(130, 43);
            this.savebtn.TabIndex = 8;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // UserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 346);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.editedBirthdatepicker);
            this.Controls.Add(this.editedLastNametxt);
            this.Controls.Add(this.editedFirstNametxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserEdit";
            this.Text = "Edit user";
            this.Load += new System.EventHandler(this.UserEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox editedFirstNametxt;
        private System.Windows.Forms.TextBox editedLastNametxt;
        private System.Windows.Forms.DateTimePicker editedBirthdatepicker;
        private System.Windows.Forms.Button savebtn;
    }
}