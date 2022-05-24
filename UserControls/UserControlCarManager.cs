using CarRental.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CarRental
{
    public partial class UserControlCarManager : UserControl
    {
        public static bool AddEditIsOpen { get; set; }
        //private IList<int> yearsCollection;
        public UserControlCarManager()
        {
            InitializeComponent();
            AddEditIsOpen = false;

            try
            {
                cbRateFrom.Value = (int)RentalDatabase.DB.Cars.Select(c => c.daily_rate).Min();
                cbRateTo.Value = (int)RentalDatabase.DB.Cars.Select(c => c.daily_rate).Max();
            }
            catch (Exception e)
            {
                MessageBox.Show("Connection to database failed.", "Error!");
                MessageBox.Show(e.StackTrace, "Error!");
            }

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
                CarAddEdit carAddEdit;

                if (value == "ADD")
                {
                    carAddEdit = new CarAddEdit();
                    carAddEdit.StartPosition = FormStartPosition.CenterScreen;
                    carAddEdit.Show();
                    AddEditIsOpen = true;
                }
                else if (value == "EDIT")
                {
                    int selectedId;
                    try
                    {
                        selectedId = Convert.ToInt32(dgvCars.SelectedRows[0].Cells["ID"].Value);
                        var selectedCar = RentalDatabase.DB.Cars.Where(c => c.id == selectedId).FirstOrDefault();
                        carAddEdit = new CarAddEdit(selectedCar);
                        carAddEdit.StartPosition = FormStartPosition.CenterScreen;
                        carAddEdit.Show();
                        AddEditIsOpen = true;
                    }
                    catch
                    {
                        MessageBox.Show("Select row to edit.");
                    }
                }
            }
        }
        private void btnShowCars_Click(object sender, EventArgs e)
        {
            var data = from c in RentalDatabase.DB.Cars
                       select new { ID = c.id, CAR = c.year + " " + c.manufacturer + " " + c.model, INSURANCE = c.insurance, RATE = c.daily_rate };

            try
            {
                dgvCars.DataSource = data.ToList();
                dgvCars.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to database failed.", "Alert!");
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

            var data = from c in RentalDatabase.DB.Cars
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
                MessageBox.Show("Connection to database failed.", "Alert!");
                MessageBox.Show(ex.StackTrace);
            }

        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            var selectedCarIds = GetIndexes(dgvCars.SelectedRows);

            if (selectedCarIds.Count() == 0)
            {
                MessageBox.Show("Select row(s) to delete.", "Info!");
                return;
            }

            var userAnswer = MessageBox.Show("Data will be removed, proceed?", "Warning!", MessageBoxButtons.YesNo);

            if (userAnswer == DialogResult.No)
            {
                return;
            }

            try
            {
                foreach (var item in selectedCarIds)
                {
                    var carToDelete = RentalDatabase.DB.Cars.Where(c => c.id == item).FirstOrDefault();
                    RentalDatabase.DB.Cars.Remove(carToDelete);
                }

                RentalDatabase.DB.SaveChanges();
                var userSecondAnswer = MessageBox.Show("Removing this item will result rents and invoices removal, proceed?", "Warning!", MessageBoxButtons.YesNo);

                if (userSecondAnswer == DialogResult.Yes)
                {
                    foreach (var id in selectedCarIds)
                    {
                        var rentsToDelete = RentalDatabase.DB.Rents.Where(r => r.car_id == id).Select(r => r.id);
                        foreach (var rent in rentsToDelete)
                        {
                            var rentTodelete = RentalDatabase.DB.Rents.Where(r => r.id == rent).FirstOrDefault();
                            RentalDatabase.DB.Rents.Remove(rentTodelete);
                        }

                        var carToDelete = RentalDatabase.DB.Cars.Where(c => c.id == id).FirstOrDefault();
                        RentalDatabase.DB.Cars.Remove(carToDelete);
                    }
                    RentalDatabase.DB.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to database failed.", "Alert!");
                MessageBox.Show(ex.StackTrace, "Info!");
            }
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
