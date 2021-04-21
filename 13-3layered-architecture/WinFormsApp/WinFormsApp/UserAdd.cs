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
    public partial class UserAdd : Form
    {
        #region Variables
        private string _firstName;
        private string _lastName;
        DateTime _birthDate;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
        }
        public DateTime BirthDate
        {
            get
            {
                return _birthDate;
            }
        }
        #endregion
        public UserAdd()
        {
            InitializeComponent();
        }
        public UserAdd(User user)
        {
            InitializeComponent();
            this._firstName = user.FirstName;
            this._lastName = user.LastName;
            this.birthDatepicker.Value = user.BirthDate;
        }
        private void UserAdd_Load(object sender, EventArgs e)
        {
            firstNametxt.Text = _firstName;
            lastNametxt.Text = _lastName;
        }

        private void AddUserbtn_Click(object sender, EventArgs e)
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

        private void FirstNametxt_Validating(object sender, CancelEventArgs e)
        {
            string input = firstNametxt.Text;
            if (String.IsNullOrEmpty(input) == true)
            {
                errorProvider.SetError(firstNametxt, "Invalid data entries!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(firstNametxt, String.Empty);
                e.Cancel = false;
            }
        }

        private void LastNametxt_Validating(object sender, CancelEventArgs e)
        {
            string input = lastNametxt.Text;
            if (String.IsNullOrEmpty(input) == true)
            {
                errorProvider.SetError(lastNametxt, "invalid data entries!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(lastNametxt, String.Empty);
                e.Cancel = false;
            }
        }

        private void FirstNametxt_Validated(object sender, EventArgs e)
        {
            _firstName = firstNametxt.Text.Trim();
        }

        private void LastNametxt_Validated(object sender, EventArgs e)
        {
            _lastName = lastNametxt.Text.Trim();
        }
    }
}
