using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    public class F150 : ICar
    {
        public string Make => "Ford";
        public string Model => "F150";
        public string Year => "1975-Current";
    }

    public class F150FactoryMethod : Car
    {
        protected override ICar GetCar()
        {
            return new F150();
        }
    }
}
