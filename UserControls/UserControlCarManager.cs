using CarRental.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class UserControlCarManager : UserControl
    {
        public static bool AddEditIsOpen { get; set; }
        public UserControlCarManager()
        {
            InitializeComponent();
            AddEditIsOpen = false;
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            var value = (sender as Button).Text;

            if (!AddEditIsOpen)
            {
                CarAddEdit carAddEdit = new CarAddEdit();
                carAddEdit.StartPosition = FormStartPosition.CenterScreen;

                if (value == "ADD")
                {
                    carAddEdit.Show();
                }
                else if (value == "EDIT")
                {
                    carAddEdit.Show();
                }
                
                AddEditIsOpen = true;
            }
        }
    }
}
