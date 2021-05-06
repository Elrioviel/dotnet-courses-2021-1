
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
            this.desciptionAwardtxt = new System.Windows.Forms.TextBox();
            this.addAwardbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Award\'s title*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // titleAwardtxt
            // 
            this.titleAwardtxt.Location = new System.Drawing.Point(160, 39);
            this.titleAwardtxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.titleAwardtxt.Name = "titleAwardtxt";
            this.titleAwardtxt.Size = new System.Drawing.Size(171, 20);
            this.titleAwardtxt.TabIndex = 2;
            this.titleAwardtxt.Validated += new System.EventHandler(this.TitleAwardtxt_Validated);
            // 
            // desciptionAwardtxt
            // 
            this.desciptionAwardtxt.Location = new System.Drawing.Point(160, 122);
            this.desciptionAwardtxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.desciptionAwardtxt.Name = "desciptionAwardtxt";
            this.desciptionAwardtxt.Size = new System.Drawing.Size(255, 20);
            this.desciptionAwardtxt.TabIndex = 3;
            this.desciptionAwardtxt.Text = "(Optional)";
            this.desciptionAwardtxt.Validated += new System.EventHandler(this.DesciptionAwardtxt_Validated);
            // 
            // addAwardbtn
            // 
            this.addAwardbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addAwardbtn.Location = new System.Drawing.Point(323, 189);
            this.addAwardbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addAwardbtn.Name = "addAwardbtn";
            this.addAwardbtn.Size = new System.Drawing.Size(130, 39);
            this.addAwardbtn.TabIndex = 4;
            this.addAwardbtn.Text = "Add award";
            this.addAwardbtn.UseVisualStyleBackColor = true;
            this.addAwardbtn.Click += new System.EventHandler(this.AddAwardbtn_Click);
            // 
            // AddAward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 254);
            this.Controls.Add(this.addAwardbtn);
            this.Controls.Add(this.desciptionAwardtxt);
            this.Controls.Add(this.titleAwardtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox desciptionAwardtxt;
        private System.Windows.Forms.Button addAwardbtn;
    }
}