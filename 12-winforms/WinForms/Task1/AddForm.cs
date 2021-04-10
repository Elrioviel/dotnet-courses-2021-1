using System;
using System.Windows.Forms;

namespace Task1
{
    public partial class AddForm : Form
    {
        public User addedUser;
        
        public AddForm()
        {
            InitializeComponent();
        }
        public AddForm(User user)
        {
            FirstNameTextBox.Text = user.FirstName;
            LastNameTextBox.Text = user.LastName;
            BirthDateTimePicker1.Value = user.BirthDate;
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            BirthDateTimePicker1.MinDate = new DateTime(1950, 1, 01);
            BirthDateTimePicker1.MaxDate = DateTime.Today;
        }

        private void AddFormBtn_Click(object sender, EventArgs e)
        {
            if (FirstNameTextBox.Text == "" || LastNameTextBox.Text == "")
            {
                MessageBox.Show("Can't add empty entries");
            }
            else
            {
                var addedFirstName =  FirstNameTextBox.Text;
                var addedLastName =  LastNameTextBox.Text;
                var addedBirthDate =  BirthDateTimePicker1.Value;
                MainForm.idUser++;
                var userAwards = EditForm.selectedAward;
                addedUser = new User(MainForm.idUser, addedFirstName, addedLastName, addedBirthDate, userAwards);
                DialogResult = DialogResult.OK;
            }
        }


        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
