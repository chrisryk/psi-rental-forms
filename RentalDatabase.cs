using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    internal class RentalDatabase
    {
        public static RentalEntities DB = new RentalEntities();

        private RentalDatabase()
        {
            if (DB != null)
            {
                throw new Exception("Singleton constructed already.");
            }
        }
    }
}
