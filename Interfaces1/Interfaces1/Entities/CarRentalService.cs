using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1.Entities
{
    public class CarRentalService
    {
        protected double PriceperHour { get; set; }
        protected double PriceperDay { get; set; }

        private ITaxService _taxService;

        public CarRentalService(double priceperHour, double priceperDay, ITaxService taxService)
        {
            PriceperHour = priceperHour;
            PriceperDay = priceperDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if(duration.TotalHours <= 12.0)
            {
                basicPayment = PriceperHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PriceperDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
