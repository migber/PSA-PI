using System;
using System.Windows.Forms;
using CarRental.Models.Vehicle;

namespace CarRental
{
    public partial class VehicleEditingForm : Form
    {
        private Vehicle _vehicle;

        public VehicleEditingForm(Vehicle vehicle)
        {
            _vehicle = vehicle;

            InitializeComponent();
        }

        public void SetVehicleValues()
        {
            BrandBox.DataBindings.Add("Text", _vehicle, "Brand");
            ModelBox.DataBindings.Add("Text", _vehicle, "Model");
            ColorBox.DataBindings.Add("Text", _vehicle, "Color");
            TypeBox.DataBindings.Add("Text", _vehicle, "Type");
            WearBox.DataBindings.Add("Text", _vehicle, "Wear");
            CostValue.DataBindings.Add("Value", _vehicle, "Cost");
            YearValue.DataBindings.Add("Value", _vehicle, "Year");
            StatusBox.DataBindings.Add("Text", _vehicle, "Status");
            SizeBox.DataBindings.Add("Text", _vehicle, "Size");
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            ModelBox.DataBindings["Text"].WriteValue();

            editedVehicle = _vehicle;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
