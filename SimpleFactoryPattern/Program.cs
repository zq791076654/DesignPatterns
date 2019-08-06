using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 不使用工厂模式
            //Apple apple = new Apple();
            //apple.Print();
            //Orange orange = new Orange();
            //orange.Print();
            //Banana banana = new Banana();
            //banana.Print();
            #endregion

            #region 使用简单工厂模式
            Fruit fruitApple = FruitSimpleFactory.CreateFruit("Apple");
            fruitApple.Print();
            Fruit fruitOrange = FruitSimpleFactory.CreateFruit("Orange");
            fruitOrange.Print();
            Fruit fruitBanana = FruitSimpleFactory.CreateFruit("Banana");
            fruitBanana.Print();
            #endregion

            Console.ReadKey();
        }
    }
}
