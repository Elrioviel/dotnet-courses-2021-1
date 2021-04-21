
using System.ComponentModel;

namespace WinFormsApp
{
    partial class UserAdd
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
            this.firstNametxt = new System.Windows.Forms.TextBox();
            this.lastNametxt = new System.Windows.Forms.TextBox();
            this.birthDatepicker = new System.Windows.Forms.DateTimePicker();
            this.addUserbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of birth:";
            // 
            // firstNametxt
            // 
            this.firstNametxt.Location = new System.Drawing.Point(219, 43);
            this.firstNametxt.Name = "firstNametxt";
            this.firstNametxt.Size = new System.Drawing.Size(269, 27);
            this.firstNametxt.TabIndex = 3;
            this.firstNametxt.Validating += new System.ComponentModel.CancelEventHandler(this.FirstNametxt_Validating);
            this.firstNametxt.Validated += new System.EventHandler(this.FirstNametxt_Validated);
            // 
            // lastNametxt
            // 
            this.lastNametxt.Location = new System.Drawing.Point(219, 143);
            this.lastNametxt.Name = "lastNametxt";
            this.lastNametxt.Size = new System.Drawing.Size(269, 27);
            this.lastNametxt.TabIndex = 4;
            this.lastNametxt.Validating += new System.ComponentModel.CancelEventHandler(this.LastNametxt_Validating);
            this.lastNametxt.Validated += new System.EventHandler(this.LastNametxt_Validated);
            // 
            // birthDatepicker
            // 
            this.birthDatepicker.Location = new System.Drawing.Point(219, 247);
            this.birthDatepicker.MaxDate = new System.DateTime(2003, 12, 31, 0, 0, 0, 0);
            this.birthDatepicker.MinDate = new System.DateTime(1951, 1, 1, 0, 0, 0, 0);
            this.birthDatepicker.Name = "birthDatepicker";
            this.birthDatepicker.Size = new System.Drawing.Size(269, 27);
            this.birthDatepicker.TabIndex = 5;
            this.birthDatepicker.Value = new System.DateTime(2003, 12, 31, 0, 0, 0, 0);
            // 
            // addUserbtn
            // 
            this.addUserbtn.Location = new System.Drawing.Point(354, 386);
            this.addUserbtn.Name = "addUserbtn";
            this.addUserbtn.Size = new System.Drawing.Size(150, 50);
            this.addUserbtn.TabIndex = 6;
            this.addUserbtn.Text = "Add new user";
            this.addUserbtn.UseVisualStyleBackColor = true;
            this.addUserbtn.Click += new System.EventHandler(this.AddUserbtn_Click);
            // 
            // UserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 466);
            this.Controls.Add(this.addUserbtn);
            this.Controls.Add(this.birthDatepicker);
            this.Controls.Add(this.lastNametxt);
            this.Controls.Add(this.firstNametxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserAdd";
            this.Text = "New user";
            this.Load += new System.EventHandler(this.UserAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstNametxt;
        private System.Windows.Forms.TextBox lastNametxt;
        private System.Windows.Forms.DateTimePicker birthDatepicker;
        private System.Windows.Forms.Button addUserbtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}