using CarRental.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Windows.Forms;

namespace CarRental
{
    public partial class UserControlCarManager : UserControl
    {
        private event Action<IEnumerable> SearchClicked = (c) => { };
        private CarAddEdit carAddEdit;
        public static bool AddEditIsOpen { get; set; }
        public UserControlCarManager()
        {
            InitializeComponent();

            SearchClicked += DisplaySearchResult;

            AddEditIsOpen = false;

            if (FormLogin.UserRole == Role.Advisor)
            {
                btnAddCar.Enabled = false;
                btnEditCar.Enabled = false;
                btnDeleteCar.Enabled = false;
            }

            InitializeRentValues();
            InitializeProductionYears();
        }
        private void InitializeRentValues()
        {
            try
            {
                cbRateFrom.Value = RentalDatabase.GetMinCarDailyRate();
                cbRateTo.Value = RentalDatabase.GetMaxCarDailyRate();
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
        private void InitializeProductionYears()
        {
            var minYear = RentalDatabase.GetMinProductionYear();

            for (int i = minYear; i <= DateTime.Now.Year; i++)
            {
                cbYearFrom.Items.Add(i);
                cbYearTo.Items.Add(i);
            }

            cbYearFrom.Text = cbYearFrom.Items[0].ToString();
            cbYearTo.Text = cbYearFrom.Items[cbYearFrom.Items.Count - 1].ToString();
        }
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            var value = (sender as Button).Text;

            if (!AddEditIsOpen)
            {
                if (value == "ADD")
                {
                    OpenAddEditWindow();
                    AddEditIsOpen = true;
                }
                else if (value == "EDIT")
                {
                    if (dgvCars.SelectedRows.Count != 1)
                    {
                        MessageBox.Show("Select one row to edit.");
                        return;
                    }

                    try
                    {
                        int selectedId = Convert.ToInt32(dgvCars.SelectedRows[0].Cells["ID"].Value);
                        var selectedCar = RentalDatabase.GetCar(selectedId);
                        OpenAddEditWindow(selectedCar);
                        AddEditIsOpen = true;
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
            var listOfCars = RentalDatabase.ShowCars();
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

            var listOfCars = RentalDatabase.SearchCars(manufacturer, model, dailyRateFrom, dailyRateTo, yearFrom, yearTo);
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

            DeleteCars(selectedCarsIds);
        }
        private void DeleteCars(IEnumerable selectedCars)
        {
            var userAnswer = MessageBox.Show("Data will be removed, proceed?", "Warning!", MessageBoxButtons.YesNo);

            if (userAnswer == DialogResult.No)
            {
                return;
            }

            var userAnswerConfirm = MessageBox.Show("Removing this item will result rents and invoices removal, proceed?", "Warning!", MessageBoxButtons.YesNo);

            if (userAnswerConfirm == DialogResult.No)
            {
                return;
            }

            try
            {
                RentalDatabase.DeleteCars(selectedCars);
                MessageBox.Show("Data deleted.", "Info!");
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