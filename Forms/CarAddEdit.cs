using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.Forms
{
    public partial class CarAddEdit : Form
    {
        public CarAddEdit()
        {
            InitializeComponent();
        }

        private void CarAddEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserControlCarManager.AddEditIsOpen = false;
        }
    }
}
