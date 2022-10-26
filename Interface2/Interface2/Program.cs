using Interface2.Entities;
using Interface2.Services;
using System.Globalization;
namespace Interface2;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter contract data: ");
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Date: ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        Console.Write("Contract value: ");
        double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Contrato contrato = new Contrato(number, date, value);
        Console.Write("Enter the number of installments: ");
        int parcelas = int.Parse(Console.ReadLine());

        ContratoService contratoService = new ContratoService(parcelas, new PayPalService());
        contratoService.GenerateParcela(contrato);
        Console.WriteLine("Installments: ");
        foreach(var parcela in contrato.ParcelaList)
        {
            Console.WriteLine(parcela);
        }
    }
}