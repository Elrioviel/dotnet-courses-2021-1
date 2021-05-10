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
    public partial class MainForm : Form
    {
        public static UsersBL users;
        public static AwardsBL awards;
        public static AwardsUserBL userAwardsBL;

        private BindingSource userAwardsSource = new BindingSource();
        private BindingSource usersSource = new BindingSource();
        private BindingSource awardsSource = new BindingSource();

        public MainForm(UsersBL usersbl, AwardsBL awardsbl, AwardsUserBL awardsUserbl)
        {
            InitializeComponent();
            userAwardsBL = awardsUserbl;
            users = usersbl;
            awards = awardsbl;
        }
        private void FileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            usersSource.DataSource = users.GetList();
            awardsSource.DataSource = awards.GetList();
            userAwardsSource.DataSource = userAwardsBL.GetList();

            ctlUsers.DataSource = usersSource;
            ctlAwards.DataSource = awardsSource;
            ctlAwardsUser.DataSource = userAwardsSource;
        }
        private void DisplayAwards()
        {
            ctlAwards.DataSource = null;
            ctlAwards.DataSource = awards.GetList();
            awardsSource.ResetBindings(false);
        }
        private void DisplayUsers()
        {
            ctlUsers.DataSource = null;
            ctlUsers.DataSource = users.GetList();
            usersSource.ResetBindings(false);
        }
        private void DisplayUsersAwards()
        {
            ctlAwardsUser.DataSource = null;
            ctlAwardsUser.DataSource = userAwardsBL.GetList();
            userAwardsSource.ResetBindings(false);
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
                usersSource.ResetBindings(true);
                users.Add(addUser.FirstName, addUser.LastName, addUser.BirthDate);
                usersSource.ResetBindings(false);
                DisplayUsers();
            }
        }
        private void RegisterNewAward()
        {
            AddAward addAward = new AddAward();
            if (addAward.ShowDialog(this) == DialogResult.OK)
            {
                awardsSource.ResetBindings(true);
                awards.Add(addAward.AwardTitle, addAward.AwardDescription);
                awardsSource.ResetBindings(false);
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
                int currentID = user.ID;
                users.Remove(currentID);
                usersSource.DataSource = users.GetList();
                usersSource.ResetBindings(true);

                users.Add(editedUser.EditedFirstName, editedUser.EditedLastName, editedUser.EditedBirthDate);
                usersSource.ResetBindings(false);
                DisplayUsers();
            }
        }
        private void EditCurrentAward()
        {
            Awards award = awardsSource.Current as Awards;
            

            AddAward editedAward = new AddAward(award);
            if (editedAward.ShowDialog() == DialogResult.OK)
            {
                
                int currentID = award.AwardID;
                string currentTitle = award.Title;
                var item = userAwardsBL.GetList().FirstOrDefault(o => o.Award_Title == currentTitle);

                awards.Remove(currentID);
                awardsSource.DataSource = awards.GetList();
                awardsSource.ResetBindings(true);
                awards.Add(editedAward.AwardTitle, editedAward.AwardDescription);
                awardsSource.ResetBindings(false);
                DisplayAwards();
                var updatedAward = awards.GetList().FirstOrDefault(o => o.Title == editedAward.AwardTitle);
                MessageBox.Show("Awards updated for users!");
                userAwardsSource.ResetBindings(true);
                var userWithAward = item.User_ID;
                userAwardsBL.Add(item.User_ID, currentID+1);
                DisplayUsersAwards();
                userAwardsSource.ResetBindings(false);

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

            if (ctlAwards.SelectedCells.Count > 0)
            {
                DialogResult confirmation = MessageBox.Show("Are you sure you want to remove this award?", "Confirmation", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    var award = awardsSource.Current as Awards;
                    awardsSource.ResetBindings(true);
                    int currentID = award.AwardID;
                    awards.Remove(currentID);
                    awardsSource.DataSource = awards.GetList();
                    DisplayAwards();
                    usersSource.ResetBindings(false);
                }
            }
        }
        private void RemoveCurrentUser()
        {
            if (ctlUsers.SelectedCells.Count > 0)
            {
                DialogResult confirmation = MessageBox.Show("Are you sure you want to remove this user?", "Confirmation", MessageBoxButtons.YesNo);
                {
                    if (confirmation == DialogResult.Yes)
                    {
                        var user = usersSource.Current as User;
                        usersSource.ResetBindings(true);
                        int currentID = user.ID;
                        users.Remove(currentID);
                        usersSource.DataSource = users.GetList();
                        DisplayUsers();
                        usersSource.ResetBindings(false);
                    }
                }
            }
        }
        private void RemoveAwardFromUser()
        {
            if (ctlAwardsUser.SelectedCells.Count > 0)
            {
                DialogResult confirmation = MessageBox.Show("Are you sure you want to remove this award?", "Confirmation", MessageBoxButtons.YesNo);
                {
                    if (confirmation == DialogResult.Yes)
                    {
                        var awardToRemove = userAwardsSource.Current as UserAwards;
                        userAwardsSource.ResetBindings(true);
                        int currentAwardID = awardToRemove.Award_ID;
                        int currentUserID = awardToRemove.User_ID;

                        userAwardsBL.Remove(currentAwardID, currentUserID);

                        userAwardsSource.DataSource = userAwardsBL.GetList();
                        DisplayUsersAwards();
                        userAwardsSource.ResetBindings(false);
                    }
                }
            }
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

        private void SortUserascbtn_Click(object sender, EventArgs e)
        {
            usersSource.ResetBindings(true);
            var userSorted = users.SortUserByAgeAsc();
            usersSource.DataSource = userSorted;
            ctlUsers.DataSource = usersSource;
            usersSource.ResetBindings(false);
        }

        private void SortUserdescbtn_Click(object sender, EventArgs e)
        {
            usersSource.ResetBindings(true);
            var userSortedDesc = users.SortUserByAgeDesc();
            usersSource.DataSource = userSortedDesc;
            ctlUsers.DataSource = usersSource;
            usersSource.ResetBindings(false);
        }
        private void AwardUsers_Click(object sender, EventArgs e)
        {
            
                AwardUsers();
            
        }
        private void AwardUsers()
        {
            AwardUser awardUser = new AwardUser();
            if (awardUser.ShowDialog(this) == DialogResult.OK)
            {
                int User_ID = awardUser.awardedUser_ID;
                foreach (var item in awardUser.awardsForUser)
                {
                    userAwardsBL.Add(User_ID, item);
                }
                DisplayUsersAwards();

            }
        }

        private void DeleteAward_Click(object sender, EventArgs e)
        {
            RemoveAwardFromUser();
        }

        
    }
}
