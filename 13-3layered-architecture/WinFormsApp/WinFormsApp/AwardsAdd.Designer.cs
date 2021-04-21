
namespace WinFormsApp
{
    partial class AwardsAdd
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
            this.awardTitletxt = new System.Windows.Forms.TextBox();
            this.awardsDescriptiontxt = new System.Windows.Forms.TextBox();
            this.saveAwardbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Award\'s name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Award\'s description:";
            // 
            // awardTitletxt
            // 
            this.awardTitletxt.Location = new System.Drawing.Point(320, 52);
            this.awardTitletxt.Name = "awardTitletxt";
            this.awardTitletxt.Size = new System.Drawing.Size(261, 27);
            this.awardTitletxt.TabIndex = 2;
            this.awardTitletxt.Validating += new System.ComponentModel.CancelEventHandler(this.AwardTitletxt_Validating);
            this.awardTitletxt.Validated += new System.EventHandler(this.AwardTitletxt_Validated);
            // 
            // awardsDescriptiontxt
            // 
            this.awardsDescriptiontxt.Location = new System.Drawing.Point(320, 167);
            this.awardsDescriptiontxt.Name = "awardsDescriptiontxt";
            this.awardsDescriptiontxt.Size = new System.Drawing.Size(261, 27);
            this.awardsDescriptiontxt.TabIndex = 3;
            this.awardsDescriptiontxt.Text = "(optional)";
            this.awardsDescriptiontxt.Validating += new System.ComponentModel.CancelEventHandler(this.AwardsDescriptiontxt_Validating);
            this.awardsDescriptiontxt.Validated += new System.EventHandler(this.AwardsDescriptiontxt_Validated);
            // 
            // saveAwardbtn
            // 
            this.saveAwardbtn.Location = new System.Drawing.Point(424, 297);
            this.saveAwardbtn.Name = "saveAwardbtn";
            this.saveAwardbtn.Size = new System.Drawing.Size(156, 48);
            this.saveAwardbtn.TabIndex = 4;
            this.saveAwardbtn.Text = "Save";
            this.saveAwardbtn.UseVisualStyleBackColor = true;
            this.saveAwardbtn.Click += new System.EventHandler(this.SaveAwardbtn_Click);
            // 
            // AwardsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 380);
            this.Controls.Add(this.saveAwardbtn);
            this.Controls.Add(this.awardsDescriptiontxt);
            this.Controls.Add(this.awardTitletxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AwardsAdd";
            this.Text = "AwardsAdd";
            this.Load += new System.EventHandler(this.AwardsAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox awardTitletxt;
        private System.Windows.Forms.TextBox awardsDescriptiontxt;
        private System.Windows.Forms.Button saveAwardbtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}