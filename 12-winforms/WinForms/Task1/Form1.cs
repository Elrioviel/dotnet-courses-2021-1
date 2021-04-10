using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Task1
{
    public partial class MainForm : Form
    {
        private BindingList<User> _user;
        public static BindingList<Awards> _award;
        private BindingSource _userSource = new BindingSource();
        private BindingSource _awardSource = new BindingSource();
        public static int idUser = 0;
        public static int idAward = 0;
        public static int currentID;

        public MainForm()
        {
            InitializeComponent();
        }

        private void UserTab_Click(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddForm addUser = new AddForm();
            if (addUser.ShowDialog() == DialogResult.OK)
            {
                _user.Add(addUser.addedUser);
                _userSource.ResetBindings(false);
            }
        }

        private void AddAwardBtn_Click(object sender, EventArgs e)
        {
            AddAward addAward = new AddAward();
            if (addAward.ShowDialog() == DialogResult.OK)
            {
                _award.Add(addAward.addedAward);
                _awardSource.ResetBindings(false);
            }
        }

        private void ExitBtn2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _user = new BindingList<User>();
            _userSource.DataSource = _user;
            userDataGridView.DataSource = _userSource;
            _award = new BindingList<Awards>();
            _awardSource.DataSource = _award;
            awardsDataGridView.DataSource = _awardSource;
            
        }

       

        private void RemoveUserBtn_Click(object sender, EventArgs e)
        {
            if (userDataGridView.SelectedCells.Count > 0)
            {
                DialogResult confirmation = MessageBox.Show("Are you sure of deleting user?", "Confirmation", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                   
                   _user.RemoveAt(userDataGridView.SelectedRows[0]. Index);
                   _userSource.DataSource = _user;
                }
            }
            else
            {
                 MessageBox.Show("Select user to delete!");
            }
        }

        private void userDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (_user != null)
            {
                var user = _userSource.Current as User;
                EditForm editedUser = new EditForm(user);
                int CurrentID = user.ID;
                if (editedUser.ShowDialog() == DialogResult.OK)
                {
                    _user.Remove(user);
                    _userSource.DataSource = _user;
                    _userSource.ResetBindings(true);
                    _user.Add(editedUser.editedUser);
                    editedUser.editedUser.ID = CurrentID;
                    _userSource.ResetBindings(false);
                }
            }
        }
        
        private void RemoveAwardBtn_Click(object sender, EventArgs e)
        {
            if (awardsDataGridView.SelectedCells.Count>0)
            {
                DialogResult confirmation = MessageBox.Show("Are you sure of removing award?", "Confirmation", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    var award = _awardSource.Current as Awards;
                    _award.RemoveAt(award.ID - 1);
                    _awardSource.DataSource = _award;

                }
            }
            else
            {
                MessageBox.Show("Select award to remove!");
            }
        }

        private void awardsDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (_award != null)
            {
                var award = _awardSource.Current as Awards;
                AddAward editedAward = new AddAward(award);
                int CurrentID = award.ID;
                if (editedAward.ShowDialog() == DialogResult.OK)
                {
                    _award.Remove(award);
                    _awardSource.DataSource = _award;
                    _awardSource.ResetBindings(true);
                    _award.Add(editedAward.addedAward);
                    editedAward.addedAward.ID = CurrentID;
                    _awardSource.ResetBindings(false);
                }
            }
        }

        private void userAwardbtn_Click(object sender, EventArgs e)
        {
            EditForm awardUser = new EditForm();
        }

        private void aSortBtn_Click(object sender, EventArgs e)
        {
            var sortedList = new BindingList<User>(_user.OrderBy(x => x.Age).ToList());
            _userSource.DataSource = sortedList;
            userDataGridView.DataSource = _userSource;
        }
        
        
    }
}
