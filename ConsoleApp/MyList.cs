using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class MyList<Employee> : List<Employee>
    {
        public static MyList<Employee> operator +(MyList<Employee> myList, Employee employee)
        {
            myList.Add(employee);
            return myList;
        }
        public static MyList<Employee> operator -(MyList<Employee> myList, Employee employee)
        {
            myList.Remove(employee);
            return myList;
        }
        public int GetCountEmployeers(MyList<Employee> employees)
        {
            return employees.Count;
        }
    }
}
