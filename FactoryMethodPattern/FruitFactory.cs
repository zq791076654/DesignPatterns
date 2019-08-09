using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public interface FruitFactory
    {
        Fruit CreateFruit();
    }

    public class AppleFactory : FruitFactory
    {
        public Fruit CreateFruit()
        {
            return new Apple();
        }
    }

    public class OrangeFactory : FruitFactory
    {
        public Fruit CreateFruit()
        {
            return new Orange();
        }
    }

    public class BananaFactory : FruitFactory
    {
        public Fruit CreateFruit()
        {
            return new Banana();
        }
    }
}
