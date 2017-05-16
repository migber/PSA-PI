namespace CarRental.SharedForms
{
    partial class ContractsList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.Price = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.CarBrand = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.CustomerName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Date = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Discount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PaymentMethod = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Status = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.Price);
            this.objectListView1.AllColumns.Add(this.CarBrand);
            this.objectListView1.AllColumns.Add(this.CustomerName);
            this.objectListView1.AllColumns.Add(this.Date);
            this.objectListView1.AllColumns.Add(this.Discount);
            this.objectListView1.AllColumns.Add(this.PaymentMethod);
            this.objectListView1.AllColumns.Add(this.Status);
            this.objectListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Price,
            this.CarBrand,
            this.CustomerName,
            this.Date,
            this.Discount,
            this.PaymentMethod,
            this.Status});
            this.objectListView1.FullRowSelect = true;
            this.objectListView1.Location = new System.Drawing.Point(2, 2);
            this.objectListView1.Margin = new System.Windows.Forms.Padding(2);
            this.objectListView1.MultiSelect = false;
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.ShowGroups = false;
            this.objectListView1.Size = new System.Drawing.Size(626, 225);
            this.objectListView1.TabIndex = 2;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            // 
            // Price
            // 
            this.Price.AspectName = "Price";
            this.Price.CellPadding = null;
            this.Price.Text = "Price";
            // 
            // CarBrand
            // 
            this.CarBrand.AspectName = "Vehicle.DisplayName";
            this.CarBrand.CellPadding = null;
            this.CarBrand.Text = "CarBrand";
            this.CarBrand.Width = 75;
            // 
            // CustomerName
            // 
            this.CustomerName.AspectName = "Customer.DisplayName";
            this.CustomerName.CellPadding = null;
            this.CustomerName.Text = "CustomerName";
            this.CustomerName.Width = 110;
            // 
            // Date
            // 
            this.Date.AspectName = "ContractDate";
            this.Date.AspectToStringFormat = "{0:d}";
            this.Date.CellPadding = null;
            this.Date.Text = "Date";
            // 
            // Discount
            // 
            this.Discount.AspectName = "Discount";
            this.Discount.CellPadding = null;
            this.Discount.Text = "Discount";
            this.Discount.Width = 68;
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.AspectName = "PaymentMethod";
            this.PaymentMethod.CellPadding = null;
            this.PaymentMethod.Text = "PaymentMethod";
            this.PaymentMethod.Width = 125;
            // 
            // Status
            // 
            this.Status.AspectName = "ContractStatus";
            this.Status.CellPadding = null;
            this.Status.Text = "Status";
            // 
            // Edit
            // 
            this.Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Edit.Location = new System.Drawing.Point(632, 2);
            this.Edit.Margin = new System.Windows.Forms.Padding(2);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(56, 29);
            this.Edit.TabIndex = 3;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // ContractsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.objectListView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ContractsList";
            this.Size = new System.Drawing.Size(690, 226);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn Price;
        private BrightIdeasSoftware.OLVColumn CarBrand;
        private BrightIdeasSoftware.OLVColumn CustomerName;
        private BrightIdeasSoftware.OLVColumn Date;
        private BrightIdeasSoftware.OLVColumn Discount;
        private BrightIdeasSoftware.OLVColumn PaymentMethod;
        private BrightIdeasSoftware.OLVColumn Status;
        private System.Windows.Forms.Button Edit;
    }
}
