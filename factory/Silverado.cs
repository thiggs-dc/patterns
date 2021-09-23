using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    public class Silverado: ICar
    {
        public string Make => "Chevrolet";
        public string Model => "Silverado";
        public string Year => "1999-Current";

    }

    public class SilveradoFactoryMethod : Car
    {
        protected override ICar GetCar()
        {
            return new Silverado();
        }
    }
}
