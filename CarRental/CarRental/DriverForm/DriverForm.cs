using System.Windows.Forms;

namespace CarRental.DriverForm
{
    public partial class DriverForm : Form
    {
        public DriverForm()
        {
            InitializeComponent();
        }

        public void RefreshAllData()
        {
            vehiclesList1.UpdateVehicles();
        }
    }
}
