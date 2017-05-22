using System;
using System.Linq;
using System.Windows.Forms;
using CarRental.Models.Vehicle;

namespace CarRental.SharedForms
{
    public partial class VehicleForm : Form
    {
        //public Vehicle Vehicle;
        public readonly Vehicle Vehicle = new Vehicle();
        public VehicleForm()
        {
            InitializeComponent();

            StatusBox.Items.AddRange(Enum.GetValues(typeof(VehicleStatus)).Cast<object>().ToArray());
            SizeBox.Items.AddRange(Enum.GetValues(typeof(VehicleSize)).Cast<object>().ToArray());

        }
        public VehicleForm(Vehicle vehicle)
            : this()
        {
            Vehicle = vehicle;

            SizeBox.SelectedItem = Vehicle.Size;
            StatusBox.SelectedItem = Vehicle.Status;
        }



        public void SetDataBindings()
        {
            BrandBox.DataBindings.Add("Text", Vehicle, "Brand");
            ModelBox.DataBindings.Add("Text", Vehicle, "Model");
            ColorBox.DataBindings.Add("Text", Vehicle, "Color");
            TypeBox.DataBindings.Add("Text", Vehicle, "Type");
            WearBox.DataBindings.Add("Text", Vehicle, "Wear");
            CostValue.DataBindings.Add("Value", Vehicle, "Cost");
            YearValue.DataBindings.Add("Value", Vehicle, "Year");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!DataIsValid())
            {
                return;
            }

            Vehicle.Brand = BrandBox.Text;
            Vehicle.Model = ModelBox.Text;
            Vehicle.Color = ColorBox.Text;
            Vehicle.Type = TypeBox.Text;
            Vehicle.Wear = WearBox.Text;
            Vehicle.Cost = (int)CostValue.Value;
            Vehicle.Year = (int)YearValue.Value;

            Vehicle.Size = (VehicleSize)SizeBox.SelectedItem;
            Vehicle.Status = (VehicleStatus)StatusBox.SelectedItem;

            DialogResult = DialogResult.OK;
            Close();
        }

        private bool DataIsValid()
        {
            if (
                String.IsNullOrEmpty(BrandBox.Text) ||
                String.IsNullOrEmpty(ModelBox.Text) ||
                String.IsNullOrEmpty(ColorBox.Text) ||
                String.IsNullOrEmpty(TypeBox.Text) ||
                String.IsNullOrEmpty(WearBox.Text) ||
                CostValue.Value <= 0 ||
                YearValue.Value <= 0)
            {
                MessageBox.Show(@"Some fields are incorrect or missing.", @"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
