using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjekt
{
    class Booking
    {

        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Duration { get; set; }
        public object Product { get; set; }

        public Booking(DateTime startDate, int duration, object product)
        {
            StartDate = startDate;
            Duration = duration;
            Product = product;
        }

        public Booking(int id, DateTime startDate, DateTime endDate, object product)
        {
            Id = id;
            StartDate = startDate;
            EndDate = endDate;
            Product = product;
        }

    }
}
