using System.Windows.Forms;
using Contract = CarRental.Models.Contract.Contract;

namespace CarRental
{
    public partial class ContractsList : UserControl
    {
        public ContractsList()
        {
            InitializeComponent();

            objectListView1.AddObjects(Contract.InitialContractsList());
            objectListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public void UpdateContracts()
        {
            objectListView1.Objects = Contract.Contracts;
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
