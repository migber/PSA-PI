using System;
using CarRental.Models.Vehicle;

namespace CarRental
{
    partial class VehicleEditingForm
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
            this.Brand = new System.Windows.Forms.Label();
            this.BrandBox = new System.Windows.Forms.TextBox();
            this.ModelBox = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.Label();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.Label();
            this.ColorBox = new System.Windows.Forms.TextBox();
            this.Color = new System.Windows.Forms.Label();
            this.WearBox = new System.Windows.Forms.TextBox();
            this.Wear = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.Status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SizeBox = new System.Windows.Forms.ComboBox();
            this.YearValue = new System.Windows.Forms.NumericUpDown();
            this.CostValue = new System.Windows.Forms.NumericUpDown();
            this.CostLabel = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.YearValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostValue)).BeginInit();
            this.SuspendLayout();
            // 
            // Brand
            // 
            this.Brand.AutoSize = true;
            this.Brand.Location = new System.Drawing.Point(6, 0);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(91, 32);
            this.Brand.TabIndex = 0;
            this.Brand.Text = "Brand";
            // 
            // BrandBox
            // 
            this.BrandBox.Location = new System.Drawing.Point(12, 35);
            this.BrandBox.Name = "BrandBox";
            this.BrandBox.Size = new System.Drawing.Size(206, 38);
            this.BrandBox.TabIndex = 1;
            // 
            // ModelBox
            // 
            this.ModelBox.Location = new System.Drawing.Point(12, 136);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(206, 38);
            this.ModelBox.TabIndex = 3;
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(6, 99);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(93, 32);
            this.Model.TabIndex = 2;
            this.Model.Text = "Model";
            // 
            // TypeBox
            // 
            this.TypeBox.Location = new System.Drawing.Point(296, 134);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(168, 38);
            this.TypeBox.TabIndex = 5;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(290, 99);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(78, 32);
            this.Type.TabIndex = 4;
            this.Type.Text = "Type";
            // 
            // ColorBox
            // 
            this.ColorBox.Location = new System.Drawing.Point(296, 35);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(168, 38);
            this.ColorBox.TabIndex = 7;
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.Location = new System.Drawing.Point(296, 0);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(83, 32);
            this.Color.TabIndex = 6;
            this.Color.Text = "Color";
            // 
            // WearBox
            // 
            this.WearBox.Location = new System.Drawing.Point(12, 241);
            this.WearBox.Name = "WearBox";
            this.WearBox.Size = new System.Drawing.Size(206, 38);
            this.WearBox.TabIndex = 9;
            // 
            // Wear
            // 
            this.Wear.AutoSize = true;
            this.Wear.Location = new System.Drawing.Point(6, 207);
            this.Wear.Name = "Wear";
            this.Wear.Size = new System.Drawing.Size(82, 32);
            this.Wear.TabIndex = 8;
            this.Wear.Text = "Wear";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(814, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 60);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StatusBox
            // 
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Items.AddRange(new object[] {
            "Free",
            "InUse",
            "UnderRepair"});
            this.StatusBox.Location = new System.Drawing.Point(550, 35);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(177, 39);
            this.StatusBox.TabIndex = 11;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(582, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(96, 32);
            this.Status.TabIndex = 12;
            this.Status.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(800, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Size";
            // 
            // SizeBox
            // 
            this.SizeBox.FormattingEnabled = true;
            this.SizeBox.Items.AddRange(new object[] {
            "XXS",
            "XS",
            "S",
            "M",
            "L",
            "XL",
            "XXL"});
            this.SizeBox.Location = new System.Drawing.Point(758, 35);
            this.SizeBox.Name = "SizeBox";
            this.SizeBox.Size = new System.Drawing.Size(177, 39);
            this.SizeBox.TabIndex = 13;
            // 
            // YearValue
            // 
            this.YearValue.Location = new System.Drawing.Point(639, 242);
            this.YearValue.Maximum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.YearValue.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.YearValue.Name = "YearValue";
            this.YearValue.Size = new System.Drawing.Size(135, 38);
            this.YearValue.TabIndex = 15;
            this.YearValue.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // CostValue
            // 
            this.CostValue.Location = new System.Drawing.Point(462, 242);
            this.CostValue.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.CostValue.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.CostValue.Name = "CostValue";
            this.CostValue.Size = new System.Drawing.Size(144, 38);
            this.CostValue.TabIndex = 16;
            this.CostValue.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(480, 207);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(73, 32);
            this.CostLabel.TabIndex = 17;
            this.CostLabel.Text = "Cost";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(664, 208);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(75, 32);
            this.Year.TabIndex = 18;
            this.Year.Text = "Year";
            // 
            // VehicleEditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 305);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.CostValue);
            this.Controls.Add(this.YearValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SizeBox);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WearBox);
            this.Controls.Add(this.Wear);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.ModelBox);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.BrandBox);
            this.Controls.Add(this.Brand);
            this.Name = "VehicleEditingForm";
            this.Text = "VehicleEditing";
            ((System.ComponentModel.ISupportInitialize)(this.YearValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Brand;
        private System.Windows.Forms.TextBox BrandBox;
        private System.Windows.Forms.TextBox ModelBox;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.TextBox TypeBox;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.TextBox ColorBox;
        private System.Windows.Forms.Label Color;
        private System.Windows.Forms.TextBox WearBox;
        private System.Windows.Forms.Label Wear;
        private System.Windows.Forms.Button button1;

        public Vehicle editedVehicle;
        private System.Windows.Forms.ComboBox StatusBox;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SizeBox;
        private System.Windows.Forms.NumericUpDown YearValue;
        private System.Windows.Forms.NumericUpDown CostValue;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label Year;
    }
}