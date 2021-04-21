using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Entities;

namespace WinFormsApp
{
    public partial class AwardsAdd : Form
    {
        #region Variables
        private string _awardTitle;
        private string _awardDescription;

        public string AwardTitle
        {
            get
            {
                return _awardTitle;
            }
        }
        public string AwardDescription
        {
            get
            {
                return _awardDescription;
            }
        }
        #endregion
        public AwardsAdd()
        {
            InitializeComponent();
        }
        public AwardsAdd(Awards award)
        {
            InitializeComponent();
            this._awardTitle = award.Title;
            this._awardDescription = award.Description;

        }

        private void AwardsAdd_Load(object sender, EventArgs e)
        {
            awardTitletxt.Text = _awardTitle;
            awardsDescriptiontxt.Text = _awardDescription;
        }

        private void SaveAwardbtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren() == true)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private void AwardTitletxt_Validating(object sender, CancelEventArgs e)
        {
            string input = awardTitletxt.Text.Trim();
            if (String.IsNullOrEmpty(input) == true)
            {
                errorProvider.SetError(awardTitletxt, "Invalid data entries!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(awardTitletxt, String.Empty);
                e.Cancel = false;
            }
        }

        private void AwardTitletxt_Validated(object sender, EventArgs e)
        {
            _awardTitle = awardTitletxt.Text.Trim();
        }

        private void AwardsDescriptiontxt_Validating(object sender, CancelEventArgs e)
        {
            string input = awardsDescriptiontxt.Text.Trim();
            if (String.IsNullOrEmpty(input) == true)
            {
                errorProvider.SetError(awardsDescriptiontxt, "Invalid data entries!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(awardsDescriptiontxt, String.Empty);
                e.Cancel = false;
            }
        }

        private void AwardsDescriptiontxt_Validated(object sender, EventArgs e)
        {
            _awardDescription = awardsDescriptiontxt.Text.Trim();
        }
    }
}
