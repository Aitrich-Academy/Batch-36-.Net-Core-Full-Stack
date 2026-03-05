using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Worker
    {
        public string name;
        public string description;


        public Worker(string a)
        {
            name = a;
        }
        public Worker(Worker o)  // copy constructor
        {
            name = o.name;



        }
    }
}
