using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Worker : Employee
    {
        public override int Experience { get ; set ; }
        public override string Fullname { get ; set ; }
        public override void Work()
        {
            Console.WriteLine(Fullname + ": (выпуск продукции)");
        }
        public Worker()
        {
            Fullname = "n/a";
        }
        public Worker(string fullname, int experience)
        {
            Fullname = fullname;
            Experience = experience;
        }
        public override void Print()
        {
            Console.WriteLine(Fullname + ", Experience: " + Experience + " years");
        }
        public override Employee GetGeneric()
        {
            return this;
        }
    }
}
