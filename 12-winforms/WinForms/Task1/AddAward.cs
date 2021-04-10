using System;
using System.Windows.Forms;

namespace Task1
{
    public partial class AddAward : Form
    {
        public Awards addedAward;
        public AddAward()
        {
            InitializeComponent();
        }
        public AddAward (Awards awards) : this()
        {
            titleAwardtxt.Text = awards.Title;
            descriptionAwardtxt.Text = awards.Description;
        }

        private void AddAward_Load(object sender, EventArgs e)
        {

        }


        private void titleAwardtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddawardFBtn_Click_1(object sender, EventArgs e)
        {

            if (titleAwardtxt.Text == "")
            {
                MessageBox.Show("Award must have a title!");
            }
            else
            {
                var addedTitle = titleAwardtxt.Text;
                var addedDescription = descriptionAwardtxt.Text;
                MainForm.idAward++;
                addedAward = new Awards(MainForm.idAward, addedTitle, addedDescription);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
