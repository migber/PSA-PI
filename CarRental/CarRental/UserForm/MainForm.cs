using System.Windows.Forms;
using CarRental.Models.Contract;
using CarRental.Models.Vehicle;
using CarRental.SharedForms;

using CarRental.SQL.Client;

namespace CarRental.UserForm
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            SqlClient.GetVehiclesList();

            InitializeComponent();
        }

        public void RefreshAllData()
        {
            contractsList1.UpdateContracts();
            vehiclesList1.UpdateVehicles();
        }

        private void NewContract_Click(object sender, System.EventArgs e)
        {
            using (var form = new ContractForm())
            {
                form.SetDataBindings();
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Contract.Contracts.Add(form.Contract);

                    RefreshAllData();
                }
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
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
    }
}
