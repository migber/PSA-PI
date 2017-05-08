using System.Windows.Forms;
using CarRental.Models.Contract;
using CarRental.Models.Vehicle;

namespace CarRental
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
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
                    Vehicle.Vehicles.Add(form.Vehicle);

                    RefreshAllData();
                }
            }
        }
    }
}
