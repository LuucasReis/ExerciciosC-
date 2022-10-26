using System.Globalization;
using System.Linq;

namespace Linq2
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter with 'txt' file: ");
                string file = Console.ReadLine();
                //Entrar com seu caminho para o diretório... deixei o meu como exemplo
                string path = @"C:\Users\lucasfernando_frwk\Documents\ExercíciosC#\" + file + ".txt";
                List<Employee> employees = new List<Employee>();

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] lines = sr.ReadLine().Split(",");
                        string name = lines[0];
                        string email = lines[1];
                        double salary = double.Parse(lines[2], CultureInfo.InvariantCulture);
                        employees.Add(new Employee(name, email, salary));
                    }

                    Console.Write("Enter with the amount to filter: ");
                    double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    var result = employees.Where(x => x.Salary > amount).OrderBy(x => x.Email).Select(x => x.Email);
                    
                    Console.WriteLine("Email of people who has salary is more than $" + amount.ToString("F2", CultureInfo.InvariantCulture ) + ":");
                    foreach(var employee in result)
                    {
                        Console.WriteLine(employee);
                    }

                    var result2 = employees.Where(x => x.Name[0] == 'M').Select(x => x.Salary).Sum();
                    Console.WriteLine("Sum of employee's salary who has 'M' as first letter of they name: $" + result2);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}