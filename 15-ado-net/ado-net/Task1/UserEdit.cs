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
using Department.BLL;

namespace Task1
{
    public partial class UserEdit : Form
    {
        #region Variables
        public UsersBL editedUser;
        private string _editedfirstName;
        private string _editedlastName;
        DateTime _editedbirthDate;
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
        
        #endregion
        public UserEdit()
        {
            InitializeComponent();
        }
        public UserEdit(User user) : this()
        {
            editedFirstNametxt.Text = user.FirstName;
            editedLastNametxt.Text = user.LastName;
            editedBirthdatepicker.Value = user.BirthDate;
        }

        private void UserEdit_Load(object sender, EventArgs e)
        {
        }

        private void EditedFirstNametxt_Validated(object sender, EventArgs e)
        {
            _editedfirstName = editedFirstNametxt.Text.Trim();
        }

        private void EditedLastNametxt_Validated(object sender, EventArgs e)
        {
            _editedlastName = editedLastNametxt.Text.Trim();
        }

        private void EditedBirthdatepicker_Validated(object sender, EventArgs e)
        {
            _editedbirthDate = editedBirthdatepicker.Value;
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (editedFirstNametxt.Text == "" || editedLastNametxt.Text == "")
            {
                MessageBox.Show("Can't add empty entries");
            }
            else
               
            _editedfirstName = editedFirstNametxt.Text;
            _editedlastName = editedLastNametxt.Text;
            _editedbirthDate = editedBirthdatepicker.Value;
            this.DialogResult = DialogResult.OK;
        }

    }
}
