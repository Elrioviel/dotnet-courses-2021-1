
namespace WinFormsApp
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
            this.editFirstNametxt = new System.Windows.Forms.TextBox();
            this.editLastNametxt = new System.Windows.Forms.TextBox();
            this.editBirthDatepicker = new System.Windows.Forms.DateTimePicker();
            this.saveUserbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.awardListCheckbox = new System.Windows.Forms.CheckedListBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "User\'s first name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "User\'s last name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(24, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "User\'s birth date:";
            // 
            // editFirstNametxt
            // 
            this.errorProvider.SetIconPadding(this.editFirstNametxt, 2);
            this.editFirstNametxt.Location = new System.Drawing.Point(261, 36);
            this.editFirstNametxt.Name = "editFirstNametxt";
            this.editFirstNametxt.Size = new System.Drawing.Size(274, 27);
            this.editFirstNametxt.TabIndex = 3;
            this.editFirstNametxt.Validating += new System.ComponentModel.CancelEventHandler(this.EditFirstNametxt_Validating);
            this.editFirstNametxt.Validated += new System.EventHandler(this.EditFirstNametxt_Validated);
            // 
            // editLastNametxt
            // 
            this.errorProvider.SetIconPadding(this.editLastNametxt, 2);
            this.editLastNametxt.Location = new System.Drawing.Point(261, 127);
            this.editLastNametxt.Name = "editLastNametxt";
            this.editLastNametxt.Size = new System.Drawing.Size(274, 27);
            this.editLastNametxt.TabIndex = 4;
            this.editLastNametxt.Validating += new System.ComponentModel.CancelEventHandler(this.EditLastNametxt_Validating);
            this.editLastNametxt.Validated += new System.EventHandler(this.EditLastNametxt_Validated);
            // 
            // editBirthDatepicker
            // 
            this.editBirthDatepicker.Location = new System.Drawing.Point(261, 225);
            this.editBirthDatepicker.MaxDate = new System.DateTime(2003, 12, 31, 0, 0, 0, 0);
            this.editBirthDatepicker.MinDate = new System.DateTime(1951, 1, 1, 0, 0, 0, 0);
            this.editBirthDatepicker.Name = "editBirthDatepicker";
            this.editBirthDatepicker.Size = new System.Drawing.Size(274, 27);
            this.editBirthDatepicker.TabIndex = 5;
            this.editBirthDatepicker.Value = new System.DateTime(2003, 12, 31, 0, 0, 0, 0);
            // 
            // saveUserbtn
            // 
            this.saveUserbtn.Location = new System.Drawing.Point(407, 429);
            this.saveUserbtn.Name = "saveUserbtn";
            this.saveUserbtn.Size = new System.Drawing.Size(169, 49);
            this.saveUserbtn.TabIndex = 6;
            this.saveUserbtn.Text = "Save";
            this.saveUserbtn.UseVisualStyleBackColor = true;
            this.saveUserbtn.Click += new System.EventHandler(this.SaveUserbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(24, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "User\'s award:";
            // 
            // awardListCheckbox
            // 
            this.awardListCheckbox.FormattingEnabled = true;
            this.awardListCheckbox.Location = new System.Drawing.Point(261, 325);
            this.awardListCheckbox.Name = "awardListCheckbox";
            this.awardListCheckbox.Size = new System.Drawing.Size(274, 26);
            this.awardListCheckbox.TabIndex = 8;
            //
            // errorProvider
            //
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // UserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 511);
            this.Controls.Add(this.awardListCheckbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveUserbtn);
            this.Controls.Add(this.editBirthDatepicker);
            this.Controls.Add(this.editLastNametxt);
            this.Controls.Add(this.editFirstNametxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserEdit";
            this.Text = "UserEdit";
            this.Load += new System.EventHandler(this.UserEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox editFirstNametxt;
        private System.Windows.Forms.TextBox editLastNametxt;
        private System.Windows.Forms.DateTimePicker editBirthDatepicker;
        private System.Windows.Forms.Button saveUserbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox awardListCheckbox;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}