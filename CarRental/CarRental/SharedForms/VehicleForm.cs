using System;
using System.Linq;
using System.Windows.Forms;
using CarRental.Models.Vehicle;

namespace CarRental.SharedForms
{
    public partial class VehicleForm : Form
    {
        public Vehicle Vehicle;
        private readonly Vehicle _vehicle = new Vehicle();

        public VehicleForm(Vehicle vehicle)
            :this()
        {
            _vehicle = vehicle;

            SizeBox.SelectedItem = _vehicle.Size;
            StatusBox.SelectedItem = _vehicle.Status;
        }

        public VehicleForm()
        {
            InitializeComponent();
            StatusBox.Items.AddRange(Enum.GetValues(typeof(VehicleStatus)).Cast<object>().ToArray());
            SizeBox.Items.AddRange(Enum.GetValues(typeof(VehicleSize)).Cast<object>().ToArray());
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
            Vehicle = _vehicle;
            Vehicle.Size = (VehicleSize)SizeBox.SelectedItem;
            Vehicle.Status = (VehicleStatus)StatusBox.SelectedItem;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
