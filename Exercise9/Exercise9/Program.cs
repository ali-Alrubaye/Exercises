using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();
            var registry = new Registry(logger);
            bool run = true;



            registry.AddEmployee(new Employee("Kalle", "Anka", "123", "456"));
            while (run)
            {

                Console.WriteLine("1. Add employee");
                Console.WriteLine("2. Remove employee");
                Console.WriteLine("3. Print entire registry");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter choice:");
                var menyChoice = int.Parse(Console.ReadLine());

                // Collect user input
                switch (menyChoice)
                {
                    case 1:
                        Console.WriteLine("Enter FirstName:");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Enter LastName");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("Enter Ssn");
                        string ssn = Console.ReadLine();
                        Console.WriteLine("Enter Wage");
                        string wage = Console.ReadLine();
                        var employee = new Employee(firstName, lastName, ssn, wage);
                        registry.AddEmployee(employee);

                        break;

                    case 2:
                        Console.WriteLine("Ssn");
                        var inputSsn = Console.ReadLine();
                        registry.RemoveEmployee(inputSsn);
                        break;
                    case 3:
                        Console.WriteLine(registry.ToString());
                        break;
                    case 4:
                        run = false;
                        break;
                }
                Console.ReadKey();
            }

        }
    }
}
