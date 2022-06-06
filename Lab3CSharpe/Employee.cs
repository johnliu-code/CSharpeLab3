using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharpe
{
    // a. Créer la classe Salarié :
    class Employee
    {
        int employeeId;
        string name;
        float salaryHourRate;

        public Employee(int id, string _name, float salaryhourrate)
        {
            this.employeeId = id;
            this.name = _name;
            this.salaryHourRate = salaryhourrate;
        }

        public int EmployeeId { get { return employeeId; } }
        public string Name { get { return name; } }
        public float SalaryHourRate { get { return salaryHourRate; } }


        public override string ToString()
        {
            return base.ToString();
        }

        public void CalculateSalary(float hours)
        {
            float weekSalary = 0;
            float costratio = 0.19f;
            weekSalary = hours * salaryHourRate * (1 - costratio);
            Console.WriteLine("Week salary of " + name + " is : $" + weekSalary);
        }
    }
}
