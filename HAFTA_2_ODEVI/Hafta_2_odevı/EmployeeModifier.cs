using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace _2.hafta
{
    internal class EmployeeModifier
    {
        List<Employee> employees;

        public EmployeeModifier()
        {
            employees = new List<Employee>();
        }

        public void Create(Employee employee)
        {
            employees.Add(employee);
            Console.WriteLine(" Item added ");
        }

        public void Delete(int id)
        {
            var deleteEmp = employees.FirstOrDefault(x => x._id == id);

            if (deleteEmp == null)
            {
                Console.WriteLine(" Item not found ");

            }




            else
            {
                employees.Remove(deleteEmp);
                Console.WriteLine(id + " Item deleted ");
            }




        }

        public void ReadList()
        {
            foreach (var emp in employees)
            {
                Console.WriteLine("id: " + emp._id);
            }
        }

    }
}
