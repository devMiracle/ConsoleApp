using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//Необходимо создать консольный проект в котором реализуются следующие классы:"Сотрудник", "Фирма".
//Фирма содержит список сотрудников типа "Рабочий", "Менеджер", "Бригадир"

//Необходимо реализовать такие возможности:
//-Все типы сотрудники имеют св-ва стаж и ФИО
//- Все типы сотрудников реализуют метод "Работа"
//Рабочий - (выпуск продукции)
//Менеджер - (сбор заказов)
//Бригадир - (закупка материалов)
//Так же имеют уникальные методы:
//Менеджер - дать задание(вывод на консоль сообщения о выдаче задания)
//Бригадир - проверка рабочих(вывод на консоль сообщения о выполнении проверки рабочих)

//- Перегрузка операторов + и - для добавления и удаления сотрудников в фирму, соответственно
//- При помощи экстеншена реализовать возможность узнать присутствует ли текущий экземпляр сотрудника в фирме(параметр)
//Внутри метода использовать LINQextension
//- Реализовать дженерик методы для получения всех сотрудников типа дженерик 
//- Реализовать получение кол-ва сотрудников типа дженерик
//- При помощи экстеншена реализовать вывод на экран списка сотрудников фирмы
//При разработке нужно соблюдать приндыпы ооп и солид.

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Firm firm = new Firm();
            Console.WriteLine("---------(работаем)--------");
            Worker emp1 = new Worker("Aleksey", 2);
            emp1.Work();
            Worker emp2 = new Worker("Maksim", 1);
            emp2.Work();
            Brigadier emp3 = new Brigadier("Ivan", 3);
            emp3.Work();
            emp3.CheckWorker();
            Worker emp4 = new Worker("Aleksandr", 4);
            emp4.Work();
            Manager emp5 = new Manager("Kirill", 2);
            emp5.Work();
            emp5.GiveATask();
            
            firm.employees += emp1;
            firm.employees += emp2;
            firm.employees += emp3;
            firm.employees += emp4;
            firm.employees += emp5;

            Console.WriteLine("---------(перед удалением)--------");
            firm.employees.Find(e => e.Fullname == "Aleksey")?.Print();
            firm.employees.Find(e => e.Fullname == "Egor")?.Print();
            Console.WriteLine(' ');

            Console.WriteLine("---------(удаляем employee Aleksey)--------");
            firm.employees -= emp1;
            Console.WriteLine(' ');

            firm.employees.Find(e => e.Fullname == "Aleksey")?.Print();
            firm.employees.Find(e => e.Fullname == "Egor")?.Print();

            Console.WriteLine("---------(тест поиска LINQ)--------");
            Console.WriteLine("поиск emp4(Aleksandr): " + FindEmployeeExtension.Find(firm.employees, emp4));
            Console.WriteLine("поиск emp1(Aleksey): " + FindEmployeeExtension.Find(firm.employees, emp1));

            Console.WriteLine("---------(распечатать кол-во сотрудников)--------");
            Console.WriteLine(firm.employees.Count); 

            Console.WriteLine("---------(распечатать всех сотрудников)--------");
            PrintAllEmployeersextension.PrintAll(firm.employees);
        }
    }
}
