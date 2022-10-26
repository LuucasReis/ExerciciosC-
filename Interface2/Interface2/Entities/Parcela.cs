using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2.Entities
{
    public class Parcela
    {
        public DateTime Date { get; set; }
        public double Value { get; set; }

        public Parcela(DateTime date, double value)
        {
            Date = date;
            Value = value;
        }

        public override string ToString()
        {
            return Date.ToString("dd/MM/yyyy") + " - " + Value.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
