
namespace Task1
{
    partial class AddAward
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
            this.titleAwardtxt = new System.Windows.Forms.TextBox();
            this.descriptionAwardtxt = new System.Windows.Forms.TextBox();
            this.AddawardFBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Award\'s title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description (optional)";
            // 
            // titleAwardtxt
            // 
            this.titleAwardtxt.Location = new System.Drawing.Point(138, 34);
            this.titleAwardtxt.Name = "titleAwardtxt";
            this.titleAwardtxt.Size = new System.Drawing.Size(141, 27);
            this.titleAwardtxt.TabIndex = 2;
            // 
            // descriptionAwardtxt
            // 
            this.descriptionAwardtxt.Location = new System.Drawing.Point(213, 121);
            this.descriptionAwardtxt.Name = "descriptionAwardtxt";
            this.descriptionAwardtxt.Size = new System.Drawing.Size(265, 27);
            this.descriptionAwardtxt.TabIndex = 3;
            // 
            // AddawardFBtn
            // 
            this.AddawardFBtn.Location = new System.Drawing.Point(357, 196);
            this.AddawardFBtn.Name = "AddawardFBtn";
            this.AddawardFBtn.Size = new System.Drawing.Size(121, 43);
            this.AddawardFBtn.TabIndex = 4;
            this.AddawardFBtn.Text = "Add award";
            this.AddawardFBtn.UseVisualStyleBackColor = true;
            this.AddawardFBtn.Click += new System.EventHandler(this.AddawardFBtn_Click_1);
            // 
            // AddAward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 275);
            this.ControlBox = false;
            this.Controls.Add(this.AddawardFBtn);
            this.Controls.Add(this.descriptionAwardtxt);
            this.Controls.Add(this.titleAwardtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddAward";
            this.Text = "Add award";
            this.Load += new System.EventHandler(this.AddAward_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleAwardtxt;
        private System.Windows.Forms.TextBox descriptionAwardtxt;
        private System.Windows.Forms.Button AddawardFBtn;
    }
}