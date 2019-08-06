using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    public static class FruitSimpleFactory
    {
        public static Fruit CreateFruit(string fruitType)
        {
            switch (fruitType)
            {
                case "Apple":
                    return new Apple();
                case "Orange":
                    return new Orange();
                case "Banana":
                    return new Banana();
                default:
                    throw new ArgumentException("Not Found Fruit!");
            }
        }
    }
}
