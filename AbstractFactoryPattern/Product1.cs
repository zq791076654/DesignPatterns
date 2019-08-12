using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public abstract class YaBo
    { }

    public abstract class YaJia
    { }

    public class ShangHaiYaBo : YaBo
    {
        public ShangHaiYaBo()
        {
            Console.WriteLine("ShangHaiYaBo");
        }
    }

    public class SiChuanYaBo : YaBo
    {
        public SiChuanYaBo()
        {
            Console.WriteLine("SiChuanYaBo");
        }
    }

    public class ShangHaiYaJia : YaJia
    {
        public ShangHaiYaJia()
        {
            Console.WriteLine("ShangHaiYaJia");
        }
    }

    public class SiChuanYaJia : YaJia
    {
        public SiChuanYaJia()
        {
            Console.WriteLine("SiChuanYaJia");
        }
    }
}
