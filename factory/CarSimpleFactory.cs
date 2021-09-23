using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    public class CarSimpleFactory
    {
        public ICar GetChevy() => new Silverado();
        public ICar GetF150() => new F150();
    }
}
