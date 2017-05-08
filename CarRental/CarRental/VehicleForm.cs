using System;
using System.Linq;
using System.Windows.Forms;
using CarRental.Models.Vehicle;

namespace CarRental
{
    public partial class VehicleForm : Form
    {
        public Vehicle EditedVehicle;
        private readonly Vehicle _vehicle;

        public VehicleForm(Vehicle vehicle)
        {
            _vehicle = vehicle;
            InitializeComponent();
            StatusBox.Items.AddRange(Enum.GetValues(typeof(VehicleStatus)).Cast<object>().ToArray());
            SizeBox.Items.AddRange(Enum.GetValues(typeof(VehicleSize)).Cast<object>().ToArray());

            SizeBox.SelectedItem = _vehicle.Size;
            StatusBox.SelectedItem = _vehicle.Status;
        }

        public void SetDataBindings()
        {
            BrandBox.DataBindings.Add("Text", _vehicle, "Brand");
            ModelBox.DataBindings.Add("Text", _vehicle, "Model");
            ColorBox.DataBindings.Add("Text", _vehicle, "Color");
            TypeBox.DataBindings.Add("Text", _vehicle, "Type");
            WearBox.DataBindings.Add("Text", _vehicle, "Wear");
            CostValue.DataBindings.Add("Value", _vehicle, "Cost");
            YearValue.DataBindings.Add("Value", _vehicle, "Year");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditedVehicle = _vehicle;
            EditedVehicle.Size = (VehicleSize)SizeBox.SelectedItem;
            EditedVehicle.Status = (VehicleStatus)StatusBox.SelectedItem;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
