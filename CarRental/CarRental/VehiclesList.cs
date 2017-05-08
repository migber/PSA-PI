using CarRental.Models.Vehicle;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CarRental
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

            using (var editingForm = new VehicleForm(selectedVehicle))
            {
                editingForm.SetDataBindings();
                var result = editingForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    int editedVehicleIndex = Vehicle.Vehicles.IndexOf(Vehicle.Vehicles.FirstOrDefault(v => v.Id == editingForm.EditedVehicle.Id));
                    Vehicle.Vehicles[editedVehicleIndex] = editingForm.EditedVehicle;

                    objectListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                    var a = objectListView1.Parent.Parent.Parent.Parent as MainForm;
                    a.RefreshAllData();
                }
            }
        }
    }
}
