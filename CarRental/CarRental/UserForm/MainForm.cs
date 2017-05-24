using CarRental.Models.Contract;
using CarRental.SharedForms;
using CarRental.SQL.Client;
using CarRental.SQL.Client.SqlClient;
using System.Windows.Forms;

namespace CarRental.UserForm
{
    public partial class MainForm : Form
    {
        private readonly IClient<Contract> _contractsClient = new ContractClient();

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
