using Demo.Iclonable;
using Demo.Icomparer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Demo.Icomparer
{
    internal class EmployeeById : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Employee employee = x as Employee;
            Employee employee1 = y as Employee;

            return employee?.Id.CompareTo(employee1?.Id) ?? (employee1 is null ? 0 : -1) ;
        }
    }
}
