namespace FactoryExample
{
    public abstract class CarMethodFactory
    {
        protected abstract ICar GetCar();

        public string GetCarInfo()
        {
            var car = GetCar();
            return $"Make: {car.Make}, Model: {car.Model}, Production Years: {car.Year}";
        }
    }
}
