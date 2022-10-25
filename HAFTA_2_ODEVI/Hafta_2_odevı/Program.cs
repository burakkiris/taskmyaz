using System;


namespace _2.hafta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(1, "Jeff", "Bezos");
            Employee employee1 = new Employee(2, "Elon", "Musk");
            Employee employee2 = new Employee(3, "Mark", "Zuckerberg");
            Employee employee3 = new Employee(4, "Bill", "Gates");


            EmployeeModifier employeeManager = new EmployeeModifier();

            employeeManager.Create(employee1);
            employeeManager.Create(employee3);
            employeeManager.Delete(3);
            employeeManager.Delete(325);
            employeeManager.ReadList();



        }
    }
}