using System;
using System.Windows.Forms;

namespace CarRental.Forms
{
    public partial class RentBack : Form
    {
        public RentBack()
        {
            InitializeComponent();
        }

        private void btnCarCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RentBack_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserControlRentManager.AddEditIsOpen = false;
        }
    }
}
