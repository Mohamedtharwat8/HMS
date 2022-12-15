using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities
{
    public class AccomodationPackage
    {
        public int Id { get; set; }
        public int AccomodationTypeId { get; set; }
        public AccomodationType AccomodationType { get; set; }

        public int NoOfRooms { get; set; }
        public decimal ChargesPerNight { get; set; }

    }
}
