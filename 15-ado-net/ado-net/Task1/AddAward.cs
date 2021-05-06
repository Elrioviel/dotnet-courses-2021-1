using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace Task1
{
    public partial class AddAward : Form
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
        public AddAward()
        {
            InitializeComponent();
        }
        public AddAward(Awards award)
        {
            InitializeComponent();
            this._awardTitle = award.Title;
            this._awardDescription = award.Description;

        }
        private void AddAward_Load(object sender, EventArgs e)
        {
            titleAwardtxt.Text = _awardTitle;
            desciptionAwardtxt.Text = _awardDescription;
        }

        private void AddAwardbtn_Click(object sender, EventArgs e)
        {
            if (titleAwardtxt.Text == "")
            {
                MessageBox.Show("Award must have a title!");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void TitleAwardtxt_Validated(object sender, EventArgs e)
        {
            _awardTitle = titleAwardtxt.Text.Trim();
        }

        private void DesciptionAwardtxt_Validated(object sender, EventArgs e)
        {
            _awardDescription = desciptionAwardtxt.Text.Trim();
        }
    }
}
