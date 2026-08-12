using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    public class Employee
    {
        private int age;
        private string name;
        private int salary;

        public Employee(string name, int age, int salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }
        public override string ToString() => $"Name: {name}\nAge: {age}\nSalary: {salary}";
    }
}
