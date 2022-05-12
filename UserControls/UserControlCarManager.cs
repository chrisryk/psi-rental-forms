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
        private RentalEntities db;
        public static bool AddEditIsOpen { get; set; }
        public static bool SearchIsOpen { get; set; }
        //private IList<int> ratesCollection;
        //private IList<int> yearsCollection;
        public UserControlCarManager()
        {
            InitializeComponent();
            AddEditIsOpen = false;
            SearchIsOpen = false;
            db = new RentalEntities();

            //ratesCollection = new List<int>();

            //for (int i = 50; i <= 500; i += 50)
            //{
            //    ratesCollection.Add(i.ToString());
            //}

            //cbRateFrom.DataSource = ratesCollection;
            cbRateFrom.SelectedIndex = 0;
            //cbRateTo.DataSource = ratesCollection;
            cbRateTo.SelectedIndex = cbRateTo.Items.Count - 1;

            //yearsCollection = new List<int>();

            //for (int i = 2000; i <= DateTimeOffset.Now.Year; i++)
            //{
            //    yearsCollection.Add(i);
            //}

            //cbYearFrom.DataSource = yearsCollection;
            cbYearFrom.SelectedIndex = 0;
            //cbYearTo.DataSource = yearsCollection;
            cbYearTo.SelectedIndex = cbYearTo.Items.Count - 1;
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

        private void btnShowCars_Click(object sender, EventArgs e)
        {
            var data = from c in db.Cars
                       select new { ID = c.id, CAR = c.manufacturer + " " + c.model, RATE = c.daily_rate };

            try
            {
                dgvCars.DataSource = data.ToList();
                dgvCars.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured.");
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btnSearchCar_Click(object sender, EventArgs e)
        {
            var manufacturer = tbCarManufacturer.Text.ToUpper();
            var model = tbCarModel.Text.ToUpper();
            var dailyRateFrom = Convert.ToInt32(cbRateFrom.Text);
            var dailyRateTo = Convert.ToInt32(cbRateTo.Text);
            var yearFrom = Convert.ToInt32(cbYearFrom.Text);
            var yearTo = Convert.ToInt32(cbYearTo.Text);

            var data = from c in db.Cars
                       where c.manufacturer.ToUpper().Contains(manufacturer)
                       where c.model.ToUpper().Contains(model)
                       where c.daily_rate >= dailyRateFrom && c.daily_rate <= dailyRateTo
                       where c.year >= yearFrom && c.year <= yearTo
                       select new { ID = c.id, MANUFACTURER = c.manufacturer, MODEL = c.model, YEAR = c.year, RATE = c.daily_rate };
            try
            {
                dgvCars.DataSource = data.ToList();
                dgvCars.Columns[0].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured.");
                MessageBox.Show(ex.StackTrace);
            }

        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            var dataToDelete = dgvCars.SelectedRows;
            var data = GetIndexes(dataToDelete);

            foreach (var item in data)
            {
                var carToDelete = db.Cars.Where(c => c.id == item).FirstOrDefault();
                db.Cars.Remove(carToDelete); 
            }

            db.SaveChanges();
        }

        private IEnumerable<int> GetIndexes(DataGridViewSelectedRowCollection data)
        {
            for (int i = 0; i < data.Count; i++)
            {
                yield return Convert.ToInt32(data[i].Cells["ID"].Value);
            }
        }
    }
}
