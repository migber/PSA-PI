﻿using System;
using CarRental.Models.Contract;
using System.Linq;
using System.Windows.Forms;
using CarRental.Models;
using static CarRental.Models.Customer.Customer;
using static CarRental.Models.Vehicle.Vehicle;

namespace CarRental
{
    public partial class ContractForm : Form
    {
        public readonly Contract Contract = new Contract();

        public ContractForm()
        {
            InitializeComponent();

            ContractStatusBox.Items.AddRange(Enum.GetValues(typeof(ContractStatus)).Cast<object>().ToArray());
            PaymentMethodBox.Items.AddRange(Enum.GetValues(typeof(PaymentMethod)).Cast<object>().ToArray());

            VehicleBox.Items.AddRange(Vehicles.Select(c => c.DisplayName).ToArray());
            CustomerBox.Items.AddRange(Customers.Select(c => c.DisplayName).ToArray());
        }

        public ContractForm(Contract contract)
            : this()
        {
            Contract = contract;
            CustomerBox.SelectedItem = CustomerBox.Items.Cast<string>()
                .FirstOrDefault(c => c == Contract.Customer.DisplayName);
            VehicleBox.SelectedItem = VehicleBox.Items.Cast<string>()
                .FirstOrDefault(c => c == Contract.Vehicle.DisplayName);

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
            if (!ValidateData())
            {
                return;
            }

            Contract.Customer = Customers.FirstOrDefault(c => c.DisplayName == CustomerBox.Text);
            Contract.PickupDate = PickupDate.Value;
            Contract.ReturnDate = ReturnDate.Value;
            Contract.ContractDate = DateTime.Today;
            Contract.Vehicle = Vehicles.FirstOrDefault(c => c.DisplayName == VehicleBox.Text);
            Contract.DiscountSum = (Contract.Discount + 100) * Contract.Price / 100;
            Contract.PaymentMethod = (PaymentMethod) PaymentMethodBox.SelectedItem;
            Contract.ContractStatus = (ContractStatus) ContractStatusBox.SelectedItem;

            DialogResult = DialogResult.OK;
            Close();
        }

        private bool ValidateData()
        {
            if (PriceBox.Value < 1 ||
                String.IsNullOrEmpty(VehicleBox.Text) ||
                String.IsNullOrEmpty(PaymentMethodBox.Text) ||
                String.IsNullOrEmpty(ContractStatusBox.Text) ||
                String.IsNullOrEmpty(CustomerBox.Text))
            {
                MessageBox.Show(@"Some fields are incorrect or missing.", @"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}