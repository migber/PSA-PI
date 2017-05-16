using CarRental.UserForm;
using System;
using System.Windows.Forms;

namespace CarRental.StartupForm
{
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var userForm = new MainForm();
            userForm.Closed += (s, args) => this.Close();
            userForm.Show();
        }
    }
}
