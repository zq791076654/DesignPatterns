using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public abstract class JuewWeiFactory
    {
        public abstract YaBo CreateYaBo();
        public abstract YaJia CreateYaJia();
    }

    public class ShangHaiFactory : JuewWeiFactory
    {
        public override YaBo CreateYaBo()
        {
            return new ShangHaiYaBo();
        }

        public override YaJia CreateYaJia()
        {
            return new ShangHaiYaJia();
        }
    }

    public class SiChuanFactory : JuewWeiFactory
    {
        public override YaBo CreateYaBo()
        {
            return new SiChuanYaBo();
        }

        public override YaJia CreateYaJia()
        {
            return new SiChuanYaJia();
        }
    }

}
