using CarRental.SharedForms;
using CarRental.SQL.Client;
using System;
using System.Windows.Forms;

namespace CarRental.AdminForm
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new VehicleForm())
            {
                form.SetDataBindings();
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    SqlClient.AddVehicle(form.Vehicle);

                    RefreshAllData();
                }
            }
        }

        public void RefreshAllData()
        {
            vehiclesList1.UpdateVehicles();
        }
    }
}
