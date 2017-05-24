using CarRental.Models.Contract;
using CarRental.Models.Customer;
using CarRental.SQL.Client;
using System;
using System.Linq;
using System.Windows.Forms;
using CarRental.Models.Vehicle;
using CarRental.SQL.Client.MemoryClient;
using CarRental.SQL.Client.SqlClient;
using CarRental.Models;

namespace CarRental.SharedForms
{
    public partial class ContractForm : Form
    {
        public readonly Contract Contract = new Contract();
        private readonly IClient<Vehicle> _vehicleClient = new VehicleClient();
        private readonly IClient<Customer> _customerClient = new CustomerClient();

        public ContractForm()
        {
            InitializeComponent();

            ContractStatusBox.Items.AddRange(Enum.GetValues(typeof(ContractStatus)).Cast<object>().ToArray());
            PaymentMethodBox.Items.AddRange(Enum.GetValues(typeof(PaymentMethod)).Cast<object>().ToArray());

            VehicleBox.Items.AddRange(_vehicleClient.Read().Select(c => c.DisplayName).ToArray());
            CustomerBox.Items.AddRange(_customerClient.Read().Select(c => c.DisplayName).ToArray());
        }

        public ContractForm(Contract contract)
            : this()
        {
            Contract = contract;
            CustomerBox.SelectedItem = CustomerBox.Items.Cast<string>()
                .FirstOrDefault(c => c == Contract.Customer.DisplayName);
            VehicleBox.SelectedItem = VehicleBox.Items.Cast<string>()
                .FirstOrDefault(c => c == _vehicleClient.Read().FirstOrDefault(v => v.Id == Contract.VehicleId).DisplayName);

            PaymentMethodBox.SelectedItem = Contract.PaymentMethod;
            ContractStatusBox.SelectedItem = Contract.ContractStatus;
        }

        public void SetDataBindings()
        {
            PriceBox.DataBindings.Add("Value", Contract, "Price");
            DiscountBox.DataBindings.Add("Value", Contract, "Discount");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!DataIsValid())
            {
                return;
            }

            Contract.Customer = _customerClient.Read().FirstOrDefault(c => c.DisplayName == CustomerBox.Text);
            Contract.PickupDate = PickupDate.Value;
            Contract.ReturnDate = ReturnDate.Value;
            Contract.ContractDate = DateTime.Today;
            Contract.VehicleId = _vehicleClient.Read().FirstOrDefault(c => c.DisplayName == VehicleBox.Text).Id;
            Contract.DiscountSum = (Contract.Discount + 100) * Contract.Price / 100;
            Contract.PaymentMethod = (PaymentMethod)PaymentMethodBox.SelectedItem;
            Contract.ContractStatus = (ContractStatus)ContractStatusBox.SelectedItem;

            DialogResult = DialogResult.OK;
            Close();
        }

        private bool DataIsValid()
        {
            int dtcm = DateTime.Compare(Contract.PickupDate, Contract.ReturnDate);
            if (PriceBox.Value < 1 ||
                String.IsNullOrEmpty(VehicleBox.Text) ||
                String.IsNullOrEmpty(PaymentMethodBox.Text) ||
                String.IsNullOrEmpty(ContractStatusBox.Text) ||
                String.IsNullOrEmpty(CustomerBox.Text) || dtcm >= 0)
            {
                MessageBox.Show(@"Some fields are incorrect or missing.", @"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}