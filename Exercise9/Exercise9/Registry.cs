using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Registry
    {
        public List<Employee> MyEmp { get; private set; }

        //Constructor
        public Registry()
        {
            MyEmp = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            MyEmp.Add(employee);
            
        }
        public void RemoveEmployee(Employee employe)
        {
            MyEmp.Remove(employe);
        }
        public int EmployeeInStore
        {
        get{ return MyEmp.Count; }
        }
         public List<Employee> GetAllEmployee()
        { return MyEmp ;
        }
    }
}
