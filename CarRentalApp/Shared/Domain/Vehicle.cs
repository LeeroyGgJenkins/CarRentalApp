using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApp.Shared.Domain
{
    public class Vehicle : BaseDomainModel
    {
        public int Year { get; set; }
        //Entity Frameworks Automatically created a relationship with the Model table Id row
        public int ModelId { get; set; }
        //Creates a join without having to write it down can get everything out of Model
        public virtual Model Model { get; set; }
        public int MakeId { get; set; }
        public virtual Make Make { get; set; }
        public int ColourId { get; set; }
        public virtual Colour Colour { get; set; }
        public string vin { get; set; }
        public string LicensePlateNumber { get; set; }
        public double RentalRate { get; set; }
        public virtual List<Booking> Bookings { get; set; }


    }
}
