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
        private readonly UsersBL users;
        public static AwardsBL awards;
        public static int currentID;
        public MainForm()
        {
            users = new UsersBL();
            awards = new AwardsBL();
            InitializeComponent();
        }

        private void FileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ctlUsers.DataSource = users.InitList();
            ctlAwards.DataSource = awards.InitList();
        }
        private void DisplayUsers()
        {
            ctlUsers.DataSource = null;
            ctlUsers.DataSource = users.GetList();
        }
        private void DisplayAwards()
        {
            ctlAwards.DataSource = null;
            ctlAwards.DataSource = awards.GetList();
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
            
        }
    }
}
