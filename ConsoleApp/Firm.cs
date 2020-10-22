using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Firm
    {
        public MyList<Employee> employees;
        public Firm()
        {
            employees = new MyList<Employee>();
        }
        
    }

    
}
