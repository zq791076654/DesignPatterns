using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FruitFactory appleFactory = new AppleFactory();
            Fruit apple = appleFactory.CreateFruit();
            apple.Print();

            FruitFactory orangeFactory = new OrangeFactory();
            Fruit orange = orangeFactory.CreateFruit();
            orange.Print();

            FruitFactory bananaFactory = new BananaFactory();
            Fruit banana = bananaFactory.CreateFruit();
            banana.Print();

            Console.ReadKey();
        }
    }
}
