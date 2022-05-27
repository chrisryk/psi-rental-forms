using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class InvoiceDisplaySearch
    {
        public DateTime InvoiceDate { get; set; }
        public string Customer { get; set; }
        public string Car { get; set; }
        public DateTime? RentStart { get; set; }
        public DateTime? RentEnd { get; set; }
        public decimal TotalPrice { get; set; }
    }
}