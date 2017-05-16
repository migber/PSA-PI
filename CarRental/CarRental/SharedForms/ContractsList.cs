using System.Linq;
using System.Windows.Forms;
using CarRental.SQL.Client;
using Contract = CarRental.Models.Contract.Contract;

namespace CarRental.SharedForms
{
    public partial class ContractsList : UserControl
    {
        public ContractsList()
        {
            InitializeComponent();

            var vehicles = SqlClient.GetVehiclesList();
            var contracts = Contract.InitialContractsList();
            contracts.ForEach(c => c.Vehicle = vehicles.FirstOrDefault(v => v.Id == c.VehicleId));
            objectListView1.AddObjects(contracts);
            
            objectListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public void UpdateContracts()
        {
            var vehicles = SqlClient.GetVehiclesList();
            var contracts = Contract.Contracts;
            contracts.ForEach(c => c.Vehicle = vehicles.FirstOrDefault(v => v.Id == c.VehicleId));

            objectListView1.Objects = contracts;
        }

        private void Edit_Click(object sender, System.EventArgs e)
        {
            var selectedContract = objectListView1.SelectedObject as Contract;

            if (selectedContract == null)
            {
                MessageBox.Show("You must select a contract", "Error");
            }
            else
            {
                using (var editingForm = new ContractForm(selectedContract))
                {
                    editingForm.SetDataBindings();
                    var result = editingForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        objectListView1.UpdateObject(editingForm.Contract);
                        objectListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    }
                }
            }

        }
    }
}
