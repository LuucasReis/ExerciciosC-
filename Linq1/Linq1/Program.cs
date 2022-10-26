using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Linq1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the 'txt' file: ");
            string file = Console.ReadLine();
            //Passar o caminho para o diretório aqui... Deixei o meu como exemplo.
            string path = @"C:\Users\lucasfernando_frwk\Documents\ExercíciosC#\" + file + ".txt";
            List<Product> Produtos = new List<Product>();

            using(StreamReader sr = File.OpenText(path))
            {
                while(!sr.EndOfStream)
                {
                    string[] lines = sr.ReadLine().Split(",");
                    string name = lines[0];
                    double price = double.Parse(lines[1], CultureInfo.InvariantCulture);
                    Produtos.Add(new Product(name, price));
                }

                var result = Produtos.Select(x => x.Price).Average();
                Console.WriteLine("Avarage price: " + result.ToString("F2",CultureInfo.InvariantCulture));
                var result2 = Produtos.Where(x=> x.Price < result).OrderByDescending(x => x.Name).Select(x => x.Name);
                foreach(var item in result2)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}