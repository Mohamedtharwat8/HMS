using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities
{
    internal class Booking
    {

        public int ID { get; set; }

        public int AccomodationID { get; set; }

        public Accomodation accomodation { get; set; }

        public DateTime FromDate { get; set; }

        public int Duration { get; set; }


    }
}
