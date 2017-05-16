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

        private void button1_Click(object sender, EventArgs e)
        {
            InitializeForm<AdminForm.AdminForm>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InitializeForm<WorkerForm.WorkerForm>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InitializeForm<MainForm>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InitializeForm<GuestForm.GuestForm>();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InitializeForm<DriverForm.DriverForm>();
        }

        private void InitializeForm<T>() where T : Form, new()
        {
            Hide();
            var form = new T();
            form.Closed += (s, args) => Show();
            form.Show();
        }
    }
}
