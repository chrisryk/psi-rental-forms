using System;

namespace CarRental
{
    public class RentDisplaySearch
    {
        public int RentId { get; set; }
        public string Customer { get; set; }
        public string Car { get; set; }
        public DateTime? RentStart { get; set; }
        public DateTime? RentEnd { get; set; }
    }
}
