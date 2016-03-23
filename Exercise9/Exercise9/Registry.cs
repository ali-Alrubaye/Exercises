using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Registry
    {
        public List<Employee> employeesList;
        private Logger _logger;

        //Constructor
        public Registry()
        {
            employeesList = new List<Employee>();
        }

        public Registry(Logger logger) : this()
        {
            _logger = logger;
        }

        public void AddEmployee(Employee newEmployee)
        {
            employeesList.Add(newEmployee);

        }

        public List<Employee> GetAllEmp()
        { return employeesList; }

        public void RemoveEmployee(string ssn)
        {

            foreach (var item in employeesList)
            {
                if (item.Ssn == ssn)
                {
                    employeesList.Remove(item);
                    _logger.Log("Removing employee from list:" + item);
                    break;
                }
            }
        }
        public override string ToString()
        {
            if (!employeesList.Any())
            {
                return "Registry contains no employees.";
            }

            string result = "";
            foreach (var employee in employeesList)
            {
                result += employee.ToString();
            }
            return result;
        }
    }
}
