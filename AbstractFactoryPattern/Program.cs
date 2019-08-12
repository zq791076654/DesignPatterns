using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            JuewWeiFactory shFactory = new ShangHaiFactory();
            shFactory.CreateYaBo();
            shFactory.CreateYaJia();

            JuewWeiFactory scFactory = new SiChuanFactory();
            scFactory.CreateYaBo();
            scFactory.CreateYaJia();

            Console.ReadKey();
        }
    }
}
