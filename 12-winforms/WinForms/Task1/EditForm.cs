using System;
using System.Windows.Forms;


namespace Task1
{
    public partial class EditForm : Form
    {
        public User editedUser;
        public static string selectedAward = string.Empty;

        public EditForm()
        {
            InitializeComponent();
        }
        public EditForm(User user) : this()
        {
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            timePickerBirthDate.Value = user.BirthDate;

            
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            foreach (Awards awards in MainForm._award)
            {
                awardsCheckedListBox1.Items.Add(awards._title);
            }

        }

        
            private void saveBtn_Click(object sender, EventArgs e)
        {
            {
                if (txtFirstName.Text == "" || txtLastName.Text == "")
                {
                    MessageBox.Show("Can't add empty entries");
                }
                else
                {
                    if (awardsCheckedListBox1.CheckedItems.Count != 0)
                    {
                        for (int i = 0; i < awardsCheckedListBox1.CheckedItems.Count; i++)
                        {
                            selectedAward = selectedAward + awardsCheckedListBox1.CheckedItems[i].ToString() + " ";
                        }
                    }


                    var editedFirstName = txtFirstName.Text;
                    var editedLastName = txtLastName.Text;
                    var editedBirthDate = timePickerBirthDate.Value;
                    var currentUserId = MainForm.currentID;
                    var userAwards = selectedAward;
                    
                    editedUser = new User(currentUserId, editedFirstName, editedLastName, editedBirthDate, userAwards);
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void awardsCheckedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }
    }
}
