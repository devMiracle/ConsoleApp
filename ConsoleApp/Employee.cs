using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public abstract class Employee
    {
        public abstract int Experience { get; set; }
        public abstract string Fullname { get; set; }
        public abstract void Work();
        public abstract void Print();
        public abstract Employee GetGeneric();
    }
}
