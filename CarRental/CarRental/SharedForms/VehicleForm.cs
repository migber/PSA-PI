using System;
using System.Linq;
using System.Windows.Forms;
using CarRental.Models.Vehicle;
using CarRental.SQL.Client;

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
            /*if (BrandBox.Text != string.Empty)
            {
                MessageBox.Show("Please enter a value to Brand!");
                return;
            }
            else if (ModelBox.Text != string.Empty)
            {
                MessageBox.Show("Please enter a value to Model!");
                return;
            }
            else if (ColorBox.Text != string.Empty)
            {
                MessageBox.Show("Please enter a value to Color!");
                return;
            }
            else if (TypeBox.Text != string.Empty)
            {
                MessageBox.Show("Please enter a value to Type!");
                return;
            }
            else if (WearBox.Text != string.Empty)
            {
                MessageBox.Show("Please enter a value to Wear!");
                return;
            }
            else if (CostValue.Value <= 0)
            {
                MessageBox.Show("Please enter a value to Cost!");
                return;
            }
            else if (YearValue.Value <= 0)
            {
                MessageBox.Show("Please enter a value to Year!");
                return;
            }
            else
            {
                BrandBox.DataBindings.Add("Text", _vehicle, "Brand");
                ModelBox.DataBindings.Add("Text", _vehicle, "Model");
                ColorBox.DataBindings.Add("Text", _vehicle, "Color");
                TypeBox.DataBindings.Add("Text", _vehicle, "Type");
                WearBox.DataBindings.Add("Text", _vehicle, "Wear");
                CostValue.DataBindings.Add("Value", _vehicle, "Cost");
                YearValue.DataBindings.Add("Value", _vehicle, "Year");
            }
            */

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
            if (!ValidateData())
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

        private bool ValidateData()
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
