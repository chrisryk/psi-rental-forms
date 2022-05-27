using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CarRental
{
    public static class InputValidation
    {
        public static bool Login(string userName, string userPassword) 
            => RentalDatabase.DB.Users.Where(u => u.name == userName && u.password == userPassword).Count() > 0;
        public static bool CarManufacturer(string manufacturer) => manufacturer.Length != 0;
        public static bool CarModel(string model) => model.Length != 0;
        public static bool CarYear(int year) => year <= DateTime.Now.Year;
        public static bool CarRate(decimal rate) => rate <= 5000 && rate > 0;
        public static bool CarVin(string vin) => new Regex("[a-z0-9]{17}", RegexOptions.IgnoreCase).IsMatch(vin);
        public static bool CarInsurance(DateTime date) => date > DateTime.Now && date <= DateTime.Now.AddYears(1);
        public static bool CustomerName(string name) => new Regex("^[a-z]{2,}$", RegexOptions.IgnoreCase).IsMatch(name);
        public static bool Email(string email) => new Regex(@"^[0-9a-z.]*@[0-9a-z]+\.[0-9a-z]{2,4}$", RegexOptions.IgnoreCase).IsMatch(email);
        public static bool Phone(string phone) => new Regex("^[0-9]{9}$").IsMatch(phone);
        public static bool CustomerLicence(string licence) => new Regex("^[0-9]{5}/[0-9]{2}/[0-9]{4}$").IsMatch(licence);
        public static bool RentDateBackFromFuture(DateTime date) => date > DateTimeOffset.UtcNow;
        public static bool RentDateBackEarlierThanStart(DateTime dateBack, DateTime? dateStart) => dateBack < dateStart;
    }
}
