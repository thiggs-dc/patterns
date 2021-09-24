namespace FactoryExample
{
    public class Silverado: ICar
    {
        public string Make => "Chevrolet";
        public string Model => "Silverado";
        public string Year => "1999-Current";
        public VehicleTypeEnum Type => VehicleTypeEnum.Truck;
    }

    public class SilveradoFactoryMethod : CarMethodFactory
    {
        protected override ICar GetCar()
        {
            return new Silverado();
        }
    }
}
