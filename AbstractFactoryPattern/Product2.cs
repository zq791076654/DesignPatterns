using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public abstract class Phone
    {
    }

    public abstract class Computer
    {
    }

    public class Iphone : Phone
    {
        public Iphone()
        {
            Console.WriteLine("Iphone");
        }
    }

    public class HuaWei : Phone
    {
        public HuaWei()
        {
            Console.WriteLine("HuaWei");
        }
    }

    public class HP : Computer
    {
        public HP()
        {
            Console.WriteLine("HP");
        }
    }

    public class Dell : Computer
    {
        public Dell()
        {
            Console.WriteLine("Dell");
        }
    }


}
