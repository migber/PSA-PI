using System.Windows.Forms;
using CarRental.Models.Contract;

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

                    contractsList1.UpdateContracts();
                    RefreshAllData();
                }
            }
        }
    }
}
