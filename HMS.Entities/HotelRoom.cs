using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities
{
    internal class HotelRoom
    {
        public int ID { get; set; }

        public int AccomodationTypeID { get; set; }
        public AccomodationType accomodationType { get; set; }
        public string RoonNo { get; set; }


    }
}
