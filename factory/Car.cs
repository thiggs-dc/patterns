using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    public abstract class Car
    {
        protected abstract ICar GetCar();

        public string GetCarInfo()
        {
            var car = GetCar();
            return $"Make: {car.Make}, Model: {car.Model}, Production Years: {car.Year}";
        }
    }
}
