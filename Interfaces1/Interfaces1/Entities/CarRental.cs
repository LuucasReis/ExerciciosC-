using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1.Entities
{
    public class CarRental
    {
        public string Model { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Invoice Invoice { get; protected set; }

        public CarRental(string model, DateTime start, DateTime finish)
        {
            Model = model;
            Start = start;
            Finish = finish;
        }
    }
}
