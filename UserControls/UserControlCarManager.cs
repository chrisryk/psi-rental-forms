using CarRental.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core;
using System.Linq;
using System.Windows.Forms;

namespace CarRental
{
    public partial class UserControlCarManager : UserControl
    {
        private event Action<IEnumerable> SearchClicked = (c) => { };
        private event Action AddCarClicked = () => { };
        private event Action<Cars> EditCarClicked = (c) => { };
        private event Action<IEnumerable> DeleteCarClicked = (c) => { };
        private CarAddEdit carAddEdit;
        public static bool AddEditIsOpen { get; set; }
        //private IList<int> yearsCollection;
        public UserControlCarManager()
        {
            InitializeComponent();

            SearchClicked += DisplaySearchResult;
            AddCarClicked += OpenAddEditWindow;
            EditCarClicked += (c) => OpenAddEditWindow(c);
            DeleteCarClicked += (c) => DeleteData(c);

            AddEditIsOpen = false;

            if (FormLogin.UserRole == Role.Advisor)
            {
                btnAddCar.Enabled = false;
                btnEditCar.Enabled = false;
                btnDeleteCar.Enabled = false;
            }

            try
            {
                cbRateFrom.Value = (int)RentalDatabase.DB.Cars.Select(c => c.daily_rate).Min();
                cbRateTo.Value = (int)RentalDatabase.DB.Cars.Select(c => c.daily_rate).Max();
            }
            catch (EntityException ex)
            {
                MessageBox.Show("Database connection failed", "Alert!");
                MessageBox.Show(ex.StackTrace, "Info!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured.", "Alert!");
                MessageBox.Show(ex.StackTrace, "Info!");
                throw;
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
                if (value == "ADD")
                {
                    AddCarClicked.Invoke();
                    AddEditIsOpen = true;
                }
                else if (value == "EDIT")
                {
                    int selectedId;
                    try
                    {
                        selectedId = Convert.ToInt32(dgvCars.SelectedRows[0].Cells["ID"].Value);
                        var selectedCar = RentalDatabase.DB.Cars.Where(c => c.id == selectedId).FirstOrDefault();
                        EditCarClicked.Invoke(selectedCar);
                        AddEditIsOpen = true;
                    }
                    catch
                    {
                        MessageBox.Show("Select row to edit.");
                    }
                }
            }
        }
        private void OpenAddEditWindow()
        {
            carAddEdit = new CarAddEdit();
            carAddEdit.StartPosition = FormStartPosition.CenterScreen;
            carAddEdit.Show();
        }
        private void OpenAddEditWindow(Cars car)
        {
            carAddEdit = new CarAddEdit(car);
            carAddEdit.StartPosition = FormStartPosition.CenterScreen;
            carAddEdit.Show();
        }
        private void btnShowCars_Click(object sender, EventArgs e)
        {
            var data = from c in RentalDatabase.DB.Cars
                       select new { ID = c.id, CAR = c.year + " " + c.manufacturer + " " + c.model, INSURANCE = c.insurance, RATE = c.daily_rate };

            var listOfCars = data.ToList();

            SearchClicked.Invoke(listOfCars);
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

            var listOfCars = data.ToList();

            SearchClicked.Invoke(listOfCars);
        }
        private void DisplaySearchResult(IEnumerable data)
        {
            try
            {
                dgvCars.DataSource = data;
                dgvCars.Columns[0].Visible = false;

            }
            catch (EntityException ex)
            {
                MessageBox.Show("Database connection failed", "Alert!");
                MessageBox.Show(ex.StackTrace, "Info!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured.", "Alert!");
                MessageBox.Show(ex.StackTrace, "Info!");
                throw;
            }
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            var selectedCarsIds = GetIndexes(dgvCars.SelectedRows);

            if (selectedCarsIds.Count() == 0)
            {
                MessageBox.Show("Select row(s) to delete.", "Info!");
                return;
            }

            var userAnswer = MessageBox.Show("Data will be removed, proceed?", "Warning!", MessageBoxButtons.YesNo);

            if (userAnswer == DialogResult.No)
            {
                return;
            }

            DeleteCarClicked.Invoke(selectedCarsIds);
        }
        private void DeleteData(IEnumerable data)
        {
            try
            {
                var userSecondAnswer = MessageBox.Show("Removing this item will result rents and invoices removal, proceed?", "Warning!", MessageBoxButtons.YesNo);

                if (userSecondAnswer == DialogResult.Yes)
                {
                    foreach (int id in data)
                    {

                        var rentsToDelete = RentalDatabase.DB.Rents.Where(r => r.car_id == id).Select(r => r.id);

                        foreach (var rent in rentsToDelete)
                        {
                            var invoiceToDelete = RentalDatabase.DB.Invoices.Where(i => i.rent_id == rent).FirstOrDefault();
                            RentalDatabase.DB.Invoices.Remove(invoiceToDelete);

                            var rentTodelete = RentalDatabase.DB.Rents.Where(r => r.id == rent).FirstOrDefault();
                            RentalDatabase.DB.Rents.Remove(rentTodelete);
                        }

                        var carToDelete = RentalDatabase.DB.Cars.Where(c => c.id == id).FirstOrDefault();
                        RentalDatabase.DB.Cars.Remove(carToDelete);
                    }

                    RentalDatabase.DB.SaveChanges();
                    MessageBox.Show("Data deleted.", "Info!");
                }
            }
            catch (EntityException ex)
            {
                MessageBox.Show("Database connection failed", "Alert!");
                MessageBox.Show(ex.StackTrace, "Info!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured.", "Alert!");
                MessageBox.Show(ex.StackTrace, "Info!");
                throw;
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
