using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Iclonable
{
    internal class Employee :ICloneable , IComparable
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public decimal Salary { get; set; }
        public Employee()
        {
        }
       public Employee(Employee employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            Salary = employee.Salary;
        }

        public Employee(int id, string? name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"ID = {Id}  NAME = {Name}  SALARY = {Salary}";
        }

        public object Clone ()
        {
            Id = Id;   
            Name = Name;
            Salary = Salary;
            return this ;
        }

        public int CompareTo(object? obj)
        {
            Employee emp = obj as Employee;
            if (this.Salary > emp.Salary )
                return 1;
            else if (this.Salary < emp.Salary)
                return -1;
            else 
                return 0;
        }
    }
}
