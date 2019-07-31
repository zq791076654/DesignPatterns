using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager1 = PersonManager.GetPersonManager();
            PersonManager personManager2 = PersonManager.GetPersonManager();
            personManager1.Say();
            personManager2.Say();
        }
    }
}
