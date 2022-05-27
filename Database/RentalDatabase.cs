using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CarRental
{
    public class RentalDatabase
    {
        public static RentalEntities DB = new RentalEntities();

        private RentalDatabase()
        {
            if (DB != null)
            {
                throw new Exception("Singleton constructed already.");
            }
        }
        public static string GetRole(string userName, string userPassword)
        {
            var role = from r in DB.Roles
                       join u in DB.Users
                       on r.id equals u.role_id
                       where u.name == userName
                       where u.password == userPassword
                       select r.role;

            return role.FirstOrDefault();
        }
        public static int GetMinCarDailyRate() => (int)DB.Cars.Select(c => c.daily_rate).Min();
        public static int GetMaxCarDailyRate() => (int)DB.Cars.Select(c => c.daily_rate).Max();
        public static int GetMinProductionYear() => (int)DB.Cars.Select(c => c.year).Min();
        public static int GetLatestInvoiceId() => (int)DB.Invoices.Select(i => i.id).Max();
        public static int GetLatestRentId() => (int)DB.Rents.Select(r => r.id).Max();
        public static IList<CarDisplayShow> ShowCars()
        {
            var data = from c in DB.Cars
                           select new CarDisplayShow()
                           {
                               Id = (int)c.id,
                               CarDetails = c.year + " " + c.manufacturer + " " + c.model,
                               Insurance = c.insurance,
                               DailyRate = c.daily_rate
                           };

            return data.ToList();
        }
        public static IList<CarDisplaySearch> SearchCars(string manufacturer, string model, int dailyRateFrom, int dailyRateTo, int yearFrom, int yearTo)
        {
            var data = from c in DB.Cars
                       where c.manufacturer.ToUpper().Contains(manufacturer)
                       where c.model.ToUpper().Contains(model)
                       where c.daily_rate >= dailyRateFrom && c.daily_rate <= dailyRateTo
                       where c.year >= yearFrom && c.year <= yearTo
                       select new CarDisplaySearch()
                       { 
                           Id = (int)c.id,
                           Manufacturer = c.manufacturer,
                           Model = c.model,
                           Year = (int)c.year,
                           DailyRate = c.daily_rate
                       };

            return data.ToList();
        }
        public static Cars GetCar(int carId) => DB.Cars.Where(c => c.id == carId).FirstOrDefault();
        public static decimal GetCarRate(int rentId)
        {
            var dailyRate = from c in DB.Cars
                           join r in DB.Rents
                           on c.id equals r.car_id
                           where r.id == rentId
                           select c.daily_rate;

            return dailyRate.FirstOrDefault();
        }
        public static int GetDaysInRent(int rentId) => (int)DB.Rents.Where(r => r.id == rentId)
                                                                    .Select(r => DbFunctions.DiffDays(r.date_start, r.date_back))
                                                                    .FirstOrDefault();

        public static void DeleteCars(IEnumerable selectedData)
        {
            foreach (int id in selectedData)
            {

                var rentsToDelete = DB.Rents.Where(r => r.car_id == id).Select(r => r.id);

                foreach (var rent in rentsToDelete)
                {
                    var invoiceToDelete = DB.Invoices.Where(i => i.rent_id == rent).FirstOrDefault();
                    DB.Invoices.Remove(invoiceToDelete);

                    var rentTodelete = DB.Rents.Where(r => r.id == rent).FirstOrDefault();
                    DB.Rents.Remove(rentTodelete);
                }

                var carToDelete = DB.Cars.Where(c => c.id == id).FirstOrDefault();
                DB.Cars.Remove(carToDelete);
            }

            DB.SaveChanges();
        }
        public static IList<CustomerDisplaySearch> SearchCustomers(string userName, string userSurname, string userEmail, string userPhone, string userLicence)
        {
            var data = from c in DB.Customers
                       where c.name.Contains(userName)
                       where c.surname.Contains(userSurname)
                       where c.email.Contains(userEmail)
                       where c.phone.Contains(userPhone)
                       where c.licence.Contains(userLicence)
                       select new CustomerDisplaySearch()
                       {
                           Id = (int)c.id,
                           Customer = c.name + " " + c.surname,
                           Email = c.email,
                           Phone = c.phone,
                           Licence = c.licence
                       };

            return data.ToList();
        }
        public static Customers GetCustomer(int customerId) => DB.Customers.Where(c => c.id == customerId).FirstOrDefault();
        public static void DeleteCustomers(IEnumerable selectedData)
        {
            foreach (int id in selectedData)
            {
                var invoicesToDelete = from i in DB.Invoices
                                       join r in DB.Rents
                                       on i.rent_id equals r.id
                                       join c in DB.Customers
                                       on r.customer_id equals c.id
                                       where c.id == id
                                       select i;

                foreach (var invoice in invoicesToDelete)
                {
                    DB.Invoices.Remove(invoice);
                }

                var rentsToDelete = DB.Rents.Where(r => r.customer_id == id);

                foreach (var rent in rentsToDelete)
                {
                    DB.Rents.Remove(rent);
                }

                var customerToDelete = DB.Customers.Where(c => c.id == id).FirstOrDefault();
                DB.Customers.Remove(customerToDelete);
            }

            DB.SaveChanges();
        }
        public static void SaveRentBack(int returndCarId, DateTime dateBack)
        {
            DB.Cars.Where(c => c.id == returndCarId).FirstOrDefault().rented = false;
            DB.SaveChanges();
        }
        public static IList<InvoiceDisplaySearch> SearchInvoices(int invoiceId, string customerSurname,
            string carManufacturer, string carModel, int rentId, DateTime invoiceDateFrom, DateTime invoiceDateTo)
        {
            var data = from i in DB.Invoices
                       join r in DB.Rents
                       on i.rent_id equals r.id
                       join c in DB.Cars
                       on r.car_id equals c.id
                       join cu in DB.Customers
                       on r.customer_id equals cu.id
                       where (invoiceId == 0) ? i.id >= 0 : i.id == invoiceId
                       where cu.surname.Contains(customerSurname)
                       where c.manufacturer.Contains(carManufacturer)
                       where c.model.Contains(carModel)
                       where (rentId == 0) ? i.rent_id >= 0 : i.rent_id == rentId
                       where i.date >= invoiceDateFrom
                       where i.date <= invoiceDateTo
                       select new InvoiceDisplaySearch()
                       {
                           InvoiceDate = i.date,
                           Customer = cu.surname + " " + cu.name,
                           Car = c.manufacturer + " " + c.model,
                           RentStart = r.date_start,
                           RentEnd = r.date_back,
                           TotalPrice = i.price
                       };

            return data.ToList();
        }
        public static IEnumerable<RentDisplaySearch> SearchRents(int rentId, string surname, string email,
            string phone, string licence, DateTime dateFrom, DateTime dateTo)
        {
            var rentData = from r in DB.Rents
                           join cr in DB.Cars
                           on r.car_id equals cr.id
                           join cu in DB.Customers
                           on r.customer_id equals cu.id
                           where (rentId == 0) ? r.id >= 0 : r.id == rentId
                           where cu.surname.Contains(surname)
                           where cu.email.Contains(email)
                           where cu.phone.Contains(phone)
                           where cu.licence.Contains(licence)
                           where r.date_start >= dateFrom
                           where r.date_start <= dateTo
                           select new RentDisplaySearch()
                           {
                               RentId = (int)r.id,
                               Customer = cu.surname + " " + cu.name,
                               Car = cr.manufacturer + " " + cr.model,
                               RentStart = r.date_start,
                               RentEnd = r.date_back
                           };

            return rentData.ToList();
        }
        public static bool ReturnDateNotNull(int rentId) => DB.Rents.Where(r => r.date_back != null && r.id == rentId).Count() > 0;
        public static bool InvoiceForRentExists(int rentId)
        {
            var invoices = from i in DB.Invoices
                           join r in DB.Rents
                           on i.rent_id equals r.id
                           where i.rent_id == rentId
                           select i;

            return invoices.Count() > 0;
        }
        public static Rents GetRent(int rentId) => DB.Rents.Where(r => r.id == rentId).FirstOrDefault();
    }
}
