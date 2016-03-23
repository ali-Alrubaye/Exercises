using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Employee
    {
        
            //  properties 
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Ssn { get; set; }
            public string Wage { get; set; }

            //Constructor 
            public Employee(string firstName, string lastName, string ssn, string wage)
            {
                FirstName = firstName;
                LastName = lastName;
                Ssn = ssn;
                Wage = wage;
            }

            public void PrintEmployee()
            {

                Console.WriteLine($"{FirstName}  {LastName} {Ssn} {Wage}");
            }
            public Employee(string ssn)
            {
                Ssn = ssn;
            }


            public override string ToString()
            {
                return $"{FirstName}\t{LastName}\t{Ssn}\t{Wage}";
            }
        
    }
}
