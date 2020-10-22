using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Brigadier : Employee
    {
        public override int Experience { get; set; }
        public override string Fullname { get; set; }
        public override void Work()
        {
            Console.WriteLine(Fullname + ": (закупка материалов)");
        }
        public void CheckWorker()
        {
            Console.WriteLine(Fullname + ": (проверяет работу)");
        }
        public Brigadier()
        {
            Fullname = "n/a";
        }
        public Brigadier(string fullname, int experience)
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
