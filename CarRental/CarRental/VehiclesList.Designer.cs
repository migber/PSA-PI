namespace CarRental
{
    partial class VehiclesList
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
            this.Cost = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Brand = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Model = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Status = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.CarSize = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Year = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Type = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Color = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Wear = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.Cost);
            this.objectListView1.AllColumns.Add(this.Brand);
            this.objectListView1.AllColumns.Add(this.Model);
            this.objectListView1.AllColumns.Add(this.Status);
            this.objectListView1.AllColumns.Add(this.CarSize);
            this.objectListView1.AllColumns.Add(this.Year);
            this.objectListView1.AllColumns.Add(this.Type);
            this.objectListView1.AllColumns.Add(this.Color);
            this.objectListView1.AllColumns.Add(this.Wear);
            this.objectListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cost,
            this.Brand,
            this.Model,
            this.Status,
            this.CarSize,
            this.Year,
            this.Type,
            this.Color,
            this.Wear});
            this.objectListView1.FullRowSelect = true;
            this.objectListView1.Location = new System.Drawing.Point(3, 3);
            this.objectListView1.MultiSelect = false;
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.ShowGroups = false;
            this.objectListView1.Size = new System.Drawing.Size(634, 334);
            this.objectListView1.TabIndex = 2;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            // 
            // Cost
            // 
            this.Cost.AspectName = "Cost";
            this.Cost.CellPadding = null;
            this.Cost.Text = "Cost";
            // 
            // Brand
            // 
            this.Brand.AspectName = "Brand";
            this.Brand.CellPadding = null;
            this.Brand.Text = "Brand";
            // 
            // Model
            // 
            this.Model.AspectName = "Model";
            this.Model.CellPadding = null;
            this.Model.Text = "Model";
            // 
            // Status
            // 
            this.Status.AspectName = "Status";
            this.Status.CellPadding = null;
            this.Status.Text = "Status";
            // 
            // CarSize
            // 
            this.CarSize.AspectName = "Size";
            this.CarSize.CellPadding = null;
            this.CarSize.Text = "Size";
            // 
            // Year
            // 
            this.Year.AspectName = "Year";
            this.Year.CellPadding = null;
            this.Year.Text = "Year";
            // 
            // Type
            // 
            this.Type.AspectName = "Type";
            this.Type.CellPadding = null;
            this.Type.Text = "Type";
            // 
            // Color
            // 
            this.Color.AspectName = "Color";
            this.Color.CellPadding = null;
            this.Color.Text = "Color";
            // 
            // Wear
            // 
            this.Wear.AspectName = "Wear";
            this.Wear.CellPadding = null;
            this.Wear.Text = "Wear";
            // 
            // Edit
            // 
            this.Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Edit.Location = new System.Drawing.Point(656, 3);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(112, 57);
            this.Edit.TabIndex = 3;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // VehiclesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.objectListView1);
            this.Name = "VehiclesList";
            this.Size = new System.Drawing.Size(771, 340);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn Cost;
        private BrightIdeasSoftware.OLVColumn Brand;
        private BrightIdeasSoftware.OLVColumn Model;
        private BrightIdeasSoftware.OLVColumn Status;
        private BrightIdeasSoftware.OLVColumn CarSize;
        private BrightIdeasSoftware.OLVColumn Year;
        private BrightIdeasSoftware.OLVColumn Type;
        private BrightIdeasSoftware.OLVColumn Color;
        private BrightIdeasSoftware.OLVColumn Wear;
        private System.Windows.Forms.Button Edit;
    }
}
