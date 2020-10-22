using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Manager : Employee
    {
        public override int Experience { get; set; }
        public override string Fullname { get; set; }
        public override void Work()
        {
            Console.WriteLine(Fullname + ": (сбор заказов)");
        }
        public void GiveATask()
        {
            Console.WriteLine(Fullname + ": (дает задание)");
        }
        public Manager()
        {
            Fullname = "n/a";
        }
        public Manager(string fullname, int experience)
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
