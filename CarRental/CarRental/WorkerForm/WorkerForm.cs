using CarRental.SharedForms;
using CarRental.SQL.Client;
using System;
using System.Windows.Forms;

namespace CarRental.WorkerForm
{
    public partial class WorkerForm : Form
    {
        public WorkerForm()
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
