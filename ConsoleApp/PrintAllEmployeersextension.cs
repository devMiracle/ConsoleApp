using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class PrintAllEmployeersextension
    {
        public static void PrintAll(MyList<Employee> emp)
        {
            foreach (var item in emp)
            {
                Console.WriteLine("Fullname: " + item.GetGeneric().Fullname + ", Experience: " + item.GetGeneric().Experience + " years."); 
            }
        }
    }
}
