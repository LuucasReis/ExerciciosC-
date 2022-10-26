using Interfaces1.Entities;
using System.Globalization;
namespace Interfaces1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data: ");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/mm/yyy hh:mm): ");
            DateTime start = DateTime.Parse(Console.ReadLine());
            Console.Write("Return (dd/mm/yyy hh:mm): ");
            DateTime finish = DateTime.Parse(Console.ReadLine());

            CarRental carRental = new CarRental(model,start, finish);

            Console.Write("Enter price per Hour: ");
            double priceperHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per Day: ");
            double priceperDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRentalService rentalService = new CarRentalService(priceperHour, priceperDay,new BrasilTaxService());

            rentalService.ProcessInvoice(carRental);
            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);
        }
    }
}