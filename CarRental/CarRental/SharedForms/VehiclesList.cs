using System.Linq;
using CarRental.Models.Vehicle;
using CarRental.SQL.Client;
using CarRental.UserForm;
using System.Windows.Forms;
using CarRental.SQL.Client.SqlClient;

namespace CarRental.SharedForms
{
    public partial class VehiclesList : UserControl
    {
        private readonly IClient<Vehicle> _client = new VehicleClient();

        public VehiclesList()
        {
            InitializeComponent();

            objectListView1.AddObjects(_client.Read().ToList());
            objectListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public void UpdateVehicles()
        {
            objectListView1.Objects = _client.Read(); ;
            objectListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void Edit_Click(object sender, System.EventArgs e)
        {
            var selectedVehicle = objectListView1.SelectedObject as Vehicle;
            if (selectedVehicle == null)
            {
                MessageBox.Show("You must select a vehicle", "Error");
            }
            else
            {
                using (var editingForm = new VehicleForm(selectedVehicle))
                {
                    editingForm.SetDataBindings();
                    var result = editingForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        _client.Update(editingForm.Vehicle);

                        objectListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                        var a = objectListView1.Parent.Parent.Parent.Parent as MainForm;
                        a.RefreshAllData();
                    }
                }
            }
        }
    }
}
