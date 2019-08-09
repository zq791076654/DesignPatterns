using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public interface Fruit
    {
        void Print();
    }

    public class Apple : Fruit
    {
        public void Print()
        {
            Console.WriteLine("Apple");
        }
    }

    public class Orange : Fruit
    {
        public void Print()
        {
            Console.WriteLine("Orange");
        }
    }

    public class Banana : Fruit
    {
        public void Print()
        {
            Console.WriteLine("Banana");
        }
    }
}
