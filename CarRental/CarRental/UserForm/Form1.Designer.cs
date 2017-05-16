using CarRental.SharedForms;

namespace CarRental.UserForm
{
    partial class MainForm
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
            this.contractsList = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.vehiclesList1 = new CarRental.SharedForms.VehiclesList();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.contractsList1 = new CarRental.SharedForms.ContractsList();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.NewContract = new System.Windows.Forms.Button();
            this.contractsList.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contractsList
            // 
            this.contractsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contractsList.Controls.Add(this.tabPage1);
            this.contractsList.Controls.Add(this.tabPage2);
            this.contractsList.Controls.Add(this.tabPage3);
            this.contractsList.Location = new System.Drawing.Point(12, 72);
            this.contractsList.Name = "contractsList";
            this.contractsList.SelectedIndex = 0;
            this.contractsList.Size = new System.Drawing.Size(816, 428);
            this.contractsList.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.vehiclesList1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(808, 402);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vehicles List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // vehiclesList1
            // 
            this.vehiclesList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vehiclesList1.Location = new System.Drawing.Point(3, 6);
            this.vehiclesList1.Margin = new System.Windows.Forms.Padding(2);
            this.vehiclesList1.Name = "vehiclesList1";
            this.vehiclesList1.Size = new System.Drawing.Size(799, 390);
            this.vehiclesList1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.contractsList1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(808, 402);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Contracts List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // contractsList1
            // 
            this.contractsList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contractsList1.Location = new System.Drawing.Point(0, 0);
            this.contractsList1.Margin = new System.Windows.Forms.Padding(2);
            this.contractsList1.Name = "contractsList1";
            this.contractsList1.Size = new System.Drawing.Size(806, 402);
            this.contractsList1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(808, 402);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // NewContract
            // 
            this.NewContract.Location = new System.Drawing.Point(19, 13);
            this.NewContract.Name = "NewContract";
            this.NewContract.Size = new System.Drawing.Size(110, 23);
            this.NewContract.TabIndex = 4;
            this.NewContract.Text = "New Contract";
            this.NewContract.UseVisualStyleBackColor = true;
            this.NewContract.Click += new System.EventHandler(this.NewContract_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(840, 512);
            this.Controls.Add(this.NewContract);
            this.Controls.Add(this.contractsList);
            this.Name = "MainForm";
            this.Text = "User Form";
            this.contractsList.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl contractsList;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private VehiclesList vehiclesList1;
        private System.Windows.Forms.TabPage tabPage2;
        private ContractsList contractsList1;
        private System.Windows.Forms.Button NewContract;
        //private System.Windows.Forms.Button NewVehicle;
    }
}

