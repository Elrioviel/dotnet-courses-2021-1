using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Department.BLL;
using Entities;

namespace WinFormsApp
{
    public partial class MainForm : Form
    {
        private UsersBL users;
        public static AwardsBL awards;
        private BindingSource usersSource = new BindingSource();
        private BindingSource awardsSource = new BindingSource();

        public MainForm(UsersBL usersbl, AwardsBL awardsbl)
        {
            InitializeComponent();
            users = usersbl;
            awards = awardsbl;


        }

        private void FileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            usersSource.DataSource = users.InitList();
            awardsSource.DataSource = awards.InitList();
            ctlUsers.DataSource = usersSource;
            ctlAwards.DataSource = awardsSource;   
        }
        private void DisplayUsers()
        {
            ctlUsers.DataSource = null;
            ctlUsers.DataSource = users.GetList();
        }
        private void DisplayAwards()
        {
            ctlAwards.DataSource = null;
            ctlAwards.DataSource = awardsSource;
        }
        private void FileRegister_Click(object sender, EventArgs e)
        {
            if (ctlTab.SelectedTab == ctlUsersPage)
            {
                RegisterNewUser();
            }
            if (ctlTab.SelectedTab == ctlAwardsPage)
            {
                RegisterNewAward();
            }
        }
        private void RegisterNewUser()
        {
            UserAdd addUser = new UserAdd();
            if (addUser.ShowDialog(this) == DialogResult.OK)
            {
                users.Add(addUser.FirstName, addUser.LastName, addUser.BirthDate);
                DisplayUsers();
            }
        }
        private void RegisterNewAward()
        {
            AwardsAdd addAward = new AwardsAdd();
            if (addAward.ShowDialog(this) == DialogResult.OK)
            {
                awards.Add(addAward.AwardTitle, addAward.AwardDescription);
                DisplayAwards();
            }
        }
        private void EditCurrentUser()
        {
            List<Awards> awardsToUser = new List<Awards>();
                User user = usersSource.Current as User;
                UserEdit editedUser = new UserEdit(user);

                if (editedUser.ShowDialog() == DialogResult.OK)
                {
                    users.Remove(user);
                    usersSource.DataSource = users.GetList();
                    usersSource.ResetBindings(true);
                   
                    foreach (var item in awards)
                    { 
                        foreach (var element in editedUser.UsersAward)
                        {
                            if (item.Title == element)
                                awardsToUser.Add(item);
                        }
                    }
                    users.AddUserAndAward(editedUser.EditedFirstName, editedUser.EditedLastName, editedUser.EditedBirthDate, awardsToUser);
                    usersSource.ResetBindings(false);
                    DisplayUsers();
                }    
        }
        private void EditCurrentAward()
        {
            Awards award = awardsSource.Current as Awards;
            User user = usersSource.Current as User;

            AwardsAdd editedAward = new AwardsAdd(award);
            if (editedAward.ShowDialog() == DialogResult.OK)
            {
                awardsSource.ResetBindings(true);
                user.AwardsUser.Remove(award);
                user.AddAward(editedAward.AwardTitle, editedAward.AwardDescription);

                awards.Remove(award);
                awardsSource.DataSource = awards.GetList();
                awardsSource.ResetBindings(true);
                awards.Add(editedAward.AwardTitle, editedAward.AwardDescription);
                awardsSource.ResetBindings(false);
                usersSource.ResetBindings(false);
                MessageBox.Show("Awards updated for users!");
            }
        }
        private void FileEdit_Click(object sender, EventArgs e)
        {
            if (ctlTab.SelectedTab == ctlUsersPage)
            {
                EditCurrentUser();
            }
            if (ctlTab.SelectedTab == ctlAwardsPage)
            {
                EditCurrentAward();
            }
        }
        private void FileRemove_Click(object sender, EventArgs e)
        {
            if (ctlTab.SelectedTab == ctlUsersPage)
            {
                RemoveCurrentUser();
            }
            if (ctlTab.SelectedTab == ctlAwardsPage)
            {
                RemoveCurrentAward();
            }
        }

        private void RemoveCurrentAward()
        {
            
            if (ctlAwards.SelectedCells.Count>0)
            {
                DialogResult confirmation = MessageBox.Show("Are you sure you want to remove this award?", "Confirmation", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    var award = awardsSource.Current as Awards;
                    User user = usersSource.Current as User;

                    awardsSource.ResetBindings(true);
                    user.AwardsUser.Remove(award);
                    awards.Remove(award);
                    awardsSource.DataSource = awards.GetList();
                    DisplayAwards();
                    DisplayUsers();
                    usersSource.ResetBindings(false);
                }
            }
        }

        private void RemoveCurrentUser()
        {
            throw new NotImplementedException();
        }

        private void SortUserascbtn_Click(object sender, EventArgs e)
        {
            usersSource.ResetBindings(true);
            var userSorted = users.SortUserByAgeAsc();
            usersSource.DataSource = userSorted;
            ctlUsers.DataSource = usersSource;
            usersSource.ResetBindings(false);

        }

        private void SortAwardsascbtn_Click(object sender, EventArgs e)
        {
            awardsSource.ResetBindings(true);
            var awardsSorted = awards.SortAwardByTitleAsc();
            awardsSource.DataSource = awardsSorted;
            ctlAwards.DataSource = awardsSource;
            awardsSource.ResetBindings(false);
        }

        private void SortAwardsdescbtn_Click(object sender, EventArgs e)
        {
            awardsSource.ResetBindings(true);
            var awardsSortedDesc = awards.SortAwardsByTitleDesc();
            awardsSource.DataSource = awardsSortedDesc;
            ctlAwards.DataSource = awardsSource;
            awardsSource.ResetBindings(false);
        }

        private void SortUserdescbtn_Click(object sender, EventArgs e)
        {
            usersSource.ResetBindings(true);
            var userSortedDesc = users.SortUserByAgeDesc();
            usersSource.DataSource = userSortedDesc;
            ctlUsers.DataSource = usersSource;
            usersSource.ResetBindings(false);
        }

        private void ctlUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
