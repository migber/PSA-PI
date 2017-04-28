using CarRental.Models.Vehicle;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CarRental
{
    public partial class VehiclesList : UserControl
    {
        private IList<Vehicle> _vehicles = Vehicle.InitialVehiclesList();

        public VehiclesList()
        {
            InitializeComponent();

            objectListView1.AddObjects(_vehicles.ToList());
            objectListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void Edit_Click(object sender, System.EventArgs e)
        {
            var selectedVehicle = objectListView1.SelectedObject as Vehicle;

            using (var editingForm = new VehicleEditingForm(selectedVehicle))
            {
                editingForm.SetVehicleValues();
                var result = editingForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    objectListView1.UpdateObject(editingForm.editedVehicle);
                    objectListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
        }
    }
}
