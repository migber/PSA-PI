namespace CarRental.SharedForms
{
    partial class ContractForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PaymentMethodBox = new System.Windows.Forms.ComboBox();
            this.ContractStatusBox = new System.Windows.Forms.ComboBox();
            this.VehicleBox = new System.Windows.Forms.ComboBox();
            this.CustomerBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PickupDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.PriceBox = new System.Windows.Forms.NumericUpDown();
            this.DiscountBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PriceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price";
            // 
            // Discount
            // 
            this.Discount.AutoSize = true;
            this.Discount.Location = new System.Drawing.Point(128, 9);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(89, 17);
            this.Discount.TabIndex = 2;
            this.Discount.Text = "Discount (%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vehicle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Customer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Payment method";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Contract Status";
            // 
            // PaymentMethodBox
            // 
            this.PaymentMethodBox.FormattingEnabled = true;
            this.PaymentMethodBox.Location = new System.Drawing.Point(231, 30);
            this.PaymentMethodBox.Name = "PaymentMethodBox";
            this.PaymentMethodBox.Size = new System.Drawing.Size(142, 24);
            this.PaymentMethodBox.TabIndex = 12;
            // 
            // ContractStatusBox
            // 
            this.ContractStatusBox.FormattingEnabled = true;
            this.ContractStatusBox.Location = new System.Drawing.Point(379, 30);
            this.ContractStatusBox.Name = "ContractStatusBox";
            this.ContractStatusBox.Size = new System.Drawing.Size(100, 24);
            this.ContractStatusBox.TabIndex = 13;
            // 
            // VehicleBox
            // 
            this.VehicleBox.FormattingEnabled = true;
            this.VehicleBox.Location = new System.Drawing.Point(12, 82);
            this.VehicleBox.Name = "VehicleBox";
            this.VehicleBox.Size = new System.Drawing.Size(213, 24);
            this.VehicleBox.TabIndex = 14;
            // 
            // CustomerBox
            // 
            this.CustomerBox.FormattingEnabled = true;
            this.CustomerBox.Location = new System.Drawing.Point(258, 82);
            this.CustomerBox.Name = "CustomerBox";
            this.CustomerBox.Size = new System.Drawing.Size(223, 24);
            this.CustomerBox.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 16;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Pickup Date";
            // 
            // PickupDate
            // 
            this.PickupDate.Location = new System.Drawing.Point(12, 139);
            this.PickupDate.MaxDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.PickupDate.MinDate = new System.DateTime(2017, 5, 8, 0, 0, 0, 0);
            this.PickupDate.Name = "PickupDate";
            this.PickupDate.Size = new System.Drawing.Size(200, 22);
            this.PickupDate.TabIndex = 18;
            this.PickupDate.Value = new System.DateTime(2017, 5, 8, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Return Date";
            // 
            // ReturnDate
            // 
            this.ReturnDate.Location = new System.Drawing.Point(231, 139);
            this.ReturnDate.MaxDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.ReturnDate.MinDate = new System.DateTime(2017, 5, 8, 0, 0, 0, 0);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(200, 22);
            this.ReturnDate.TabIndex = 20;
            this.ReturnDate.Value = new System.DateTime(2017, 5, 8, 0, 0, 0, 0);
            // 
            // PriceBox
            // 
            this.PriceBox.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.PriceBox.Location = new System.Drawing.Point(15, 30);
            this.PriceBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(81, 22);
            this.PriceBox.TabIndex = 21;
            // 
            // DiscountBox
            // 
            this.DiscountBox.Location = new System.Drawing.Point(131, 30);
            this.DiscountBox.Name = "DiscountBox";
            this.DiscountBox.Size = new System.Drawing.Size(81, 22);
            this.DiscountBox.TabIndex = 22;
            // 
            // ContractCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 186);
            this.Controls.Add(this.DiscountBox);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.ReturnDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PickupDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CustomerBox);
            this.Controls.Add(this.VehicleBox);
            this.Controls.Add(this.ContractStatusBox);
            this.Controls.Add(this.PaymentMethodBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.label1);
            this.Name = "ContractCreationForm";
            this.Text = "ContractCreationForm";
            ((System.ComponentModel.ISupportInitialize)(this.PriceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox PaymentMethodBox;
        private System.Windows.Forms.ComboBox ContractStatusBox;
        private System.Windows.Forms.ComboBox VehicleBox;
        private System.Windows.Forms.ComboBox CustomerBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker PickupDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker ReturnDate;
        private System.Windows.Forms.NumericUpDown PriceBox;
        private System.Windows.Forms.NumericUpDown DiscountBox;
    }
}