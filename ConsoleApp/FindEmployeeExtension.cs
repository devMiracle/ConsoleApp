using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class FindEmployeeExtension
    {
        public static bool Find(this List<Employee> empList, Employee emp)
        {
            Employee temp = empList.Find(e => e.Equals(emp));
            if (temp != null) return true;
            else return false;
        }
    }
}
