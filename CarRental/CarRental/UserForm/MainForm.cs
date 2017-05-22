using System.Windows.Forms;
using CarRental.Models.Contract;
using CarRental.Models.Vehicle;
using CarRental.SharedForms;

using CarRental.SQL.Client;
using CarRental.SQL.Client.MemoryClient;
using CarRental.SQL.Client.SqlClient;

namespace CarRental.UserForm
{
    public partial class MainForm : Form
    {
        private readonly IClient<Vehicle> vehiclesClient = new VehicleClient();
        private readonly IClient<Contract> _contractsClient = new ContractsClient();

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
                    _contractsClient.Create(form.Contract);

                    RefreshAllData();
                }
            }
        }
    }
}
