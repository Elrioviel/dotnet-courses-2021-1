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
    public partial class UserEdit : Form
    {
        public User editedUser;
        public UserEdit()
        {
            InitializeComponent();
        }
        public UserEdit(User user) : this()
        {
            editFirstNametxt.Text = user.FirstName;
            editLastNametxt.Text = user.LastName;
            editBirthDatepicker.Value = user.BirthDate;
        }
        private void UserEdit_Load(object sender, EventArgs e)  //Not sure//
        {
            var passedAwards = MainForm.awards;
            foreach (Awards award in passedAwards.GetList())
            {
                awardListCheckbox.Items.Add(award.Title);
            }
        }

        private void EditFirstNametxt_Validating(object sender, CancelEventArgs e)
        {
            string input = editFirstNametxt.Text.Trim();
            if (String.IsNullOrEmpty(input) == true)
            {
                errorProvider.SetError(editFirstNametxt, "Invalid!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(editLastNametxt, String.Empty);
                e.Cancel = false;
            }
        }

        private void EditLastNametxt_Validating(object sender, CancelEventArgs e)
        {
            string input = editLastNametxt.Text.Trim();
            if (String.IsNullOrEmpty(input) == true)
            {
                errorProvider.SetError(editLastNametxt, "Invalid!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(editLastNametxt, String.Empty);
                e.Cancel = false;
            }
        }

        private void EditFirstNametxt_Validated(object sender, EventArgs e)
        {
            var editedFirstName = editFirstNametxt.Text.Trim();
        }

        private void EditLastNametxt_Validated(object sender, EventArgs e)
        {
            var editedLastName = editLastNametxt.Text.Trim();
        }

        private void SaveUserbtn_Click(object sender, EventArgs e)
        {
            
        }

    }
}
