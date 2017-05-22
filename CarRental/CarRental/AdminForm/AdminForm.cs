using CarRental.SharedForms;
using CarRental.SQL.Client;
using System;
using System.Windows.Forms;
using CarRental.Models.Vehicle;
using CarRental.SQL.Client.SqlClient;

namespace CarRental.AdminForm
{
    public partial class AdminForm : Form
    {
        private readonly IClient<Vehicle> _client = new VehicleClient();

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
                    _client.Create(form.Vehicle);

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
