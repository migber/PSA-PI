using System.Linq;
using System.Windows.Forms;
using CarRental.Models.Vehicle;
using CarRental.UserForm;

namespace CarRental.SharedForms
{
    public partial class VehiclesList : UserControl
    {
        public VehiclesList()
        {
            InitializeComponent();

            objectListView1.AddObjects(Vehicle.InitialVehiclesList());
            objectListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public void UpdateVehicles()
        {
            objectListView1.Objects = Vehicle.Vehicles;
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
                        int editedVehicleIndex = Vehicle.Vehicles.IndexOf(Vehicle.Vehicles.FirstOrDefault(v => v.Id == editingForm.Vehicle.Id));
                        Vehicle.Vehicles[editedVehicleIndex] = editingForm.Vehicle;

                        objectListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                        var a = objectListView1.Parent.Parent.Parent.Parent as MainForm;
                        a.RefreshAllData();
                    }
                }
            }
        }
    }
}
