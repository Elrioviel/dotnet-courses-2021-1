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
            if (awardTitletxt.Text == "")
            {
                MessageBox.Show("Award must have a title!");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void AwardTitletxt_Validated(object sender, EventArgs e)
        {
            _awardTitle = awardTitletxt.Text.Trim();
        }


        private void AwardsDescriptiontxt_Validated(object sender, EventArgs e)
        {
            _awardDescription = awardsDescriptiontxt.Text.Trim();
        }

    }
}
