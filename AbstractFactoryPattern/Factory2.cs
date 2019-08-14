using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public abstract class DeviceFactory
    {
        public abstract Phone CreatePhone();
        public abstract Computer CreateComputer();
    }

    public class AmericanFactory : DeviceFactory
    {
        public override Computer CreateComputer()
        {
            return new HP();
        }

        public override Phone CreatePhone()
        {
            return new Iphone();
        }
    }

    public class ChinaFactory : DeviceFactory
    {
        public override Computer CreateComputer()
        {
            return new Dell();
        }

        public override Phone CreatePhone()
        {
            return new HuaWei();
        }
    }
}
