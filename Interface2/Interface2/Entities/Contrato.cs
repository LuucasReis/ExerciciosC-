using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2.Entities
{
    public class Contrato
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        public List<Parcela> ParcelaList;

        public Contrato(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            ParcelaList = new List<Parcela>();
        }

        public void AddParcela(Parcela parcela)
        {
            ParcelaList.Add(parcela);
        }

    }
}
