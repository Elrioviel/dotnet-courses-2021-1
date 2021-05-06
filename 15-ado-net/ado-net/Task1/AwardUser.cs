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
    public partial class AwardUser : Form
    {
        public List<int> awardsForUser = new List<int>();
        public int awardedUser_ID;
        public AwardUser()
        {
            InitializeComponent();
            
        }
        
        private void AwardUser_Load(object sender, EventArgs e)
        {
            var passedAwards = MainForm.awards;
            foreach (Awards award in passedAwards.GetList())
            {
                awardTitleCheckedlist.Items.Add(award.AwardID);
            }
            var passedUsers = MainForm.users;
            foreach (User user in passedUsers.GetList())
            {
                UserIDcheckedList.Items.Add(user.ID);
            }
        }
        

        private void AwardUserbtn_Click(object sender, EventArgs e)
        {
            if (UserIDcheckedList.CheckedItems.Count > 1)
            {
                MessageBox.Show("Award users one at a time!");
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                if (awardTitleCheckedlist.CheckedItems.Count != 0)
                {
                    foreach (var awardItem in awardTitleCheckedlist.CheckedItems)
                    {
                        awardsForUser.Add(Convert.ToInt32(awardItem));
                    }
                    foreach (var item in UserIDcheckedList.CheckedItems)
                    {
                        awardedUser_ID = Convert.ToInt32(item);
                    }
                }
                this.DialogResult = DialogResult.OK;
            }
        }

        private void UserIDcheckedList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && UserIDcheckedList.CheckedItems.Count > 0)
            {
                UserIDcheckedList.ItemCheck -= UserIDcheckedList_ItemCheck;
                UserIDcheckedList.SetItemChecked(UserIDcheckedList.CheckedIndices[0], false);
                UserIDcheckedList.ItemCheck += UserIDcheckedList_ItemCheck;
            }
        }
    }
}
