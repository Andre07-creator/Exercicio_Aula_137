using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio_Aula_137.Entites;
namespace Exercicio_Aula_137
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            Console.Write("Enter number of data: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Enter #{i} data: ");
                Console.Write(" is he Physical or Corporate(p/c)?: ");
                char answer = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double annualincome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (answer == 'p')
                {
                    Console.Write("Exepenses Health: ");
                    double expensiveshealth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PhysicalPerson(expensiveshealth, name, annualincome));
                }
                else
                {
                    Console.Write("Number employees: ");
                    int numemployees = int.Parse(Console.ReadLine());
                    list.Add(new CorporatePerson(numemployees, name, annualincome));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAX PAID:");

            foreach (Person p in list)
            {
                Console.WriteLine(p.Name + " - $ " + p.TaxCalc().ToString("F2", CultureInfo.InvariantCulture));
            }
            double total = 0;
            foreach (Person p in list)
            {
                total += p.TaxCalc();
            }
            Console.WriteLine();
            Console.Write("TOTAL TAXES: " + total.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
        }
    }
}
