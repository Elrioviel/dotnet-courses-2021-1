using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Entities;
using Department.BLL;

namespace WinFormsApp
{
    public partial class UserEdit : Form
    {


        #region Variables
        public UsersBL editedUser;
        private string _editedfirstName;
        private string _editedlastName;
        DateTime _editedbirthDate;
        private List<string> _usersAward = new List<string>(); 

        public string EditedFirstName
        {
            get
            {
                return _editedfirstName;
            }
        }
        public string EditedLastName
        {
            get
            {
                return _editedlastName;
            }
        }
        public DateTime EditedBirthDate
        {
            get
            {
                return _editedbirthDate;
            }
        }
        public List<string> UsersAward
        {
            get
            {
                return _usersAward;
            }
        }
        #endregion


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
        
        private void UserEdit_Load(object sender, EventArgs e)
        {
            var passedAwards = MainForm.awards;
            foreach (Awards award in passedAwards.GetList())
            {
                awardListCheckbox.Items.Add(award.Title);
            }
        }

        private void EditFirstNametxt_Validated(object sender, EventArgs e)
        {
            _editedfirstName = editFirstNametxt.Text.Trim();
        }

        private void EditLastNametxt_Validated(object sender, EventArgs e)
        {
            _editedlastName = editLastNametxt.Text.Trim();
        }

        private void SaveUserbtn_Click(object sender, EventArgs e)
        {
            if (editFirstNametxt.Text == "" || editLastNametxt.Text == "")
            {
                MessageBox.Show("Can't add empty entries");
            }
            else
            {
                if (awardListCheckbox.CheckedItems.Count != 0)
                {
                    foreach (var item in awardListCheckbox.CheckedItems)
                    {
                        _usersAward.Add(item.ToString());    
                    }
                }
                _editedfirstName = editFirstNametxt.Text;
                _editedlastName = editLastNametxt.Text;
                _editedbirthDate = editBirthDatepicker.Value;
                this.DialogResult = DialogResult.OK;
            }
                
        }

    }
}
