namespace FactoryExample
{
    public class Equinox : ICar
    {
        public string Make => "Chevrolet";
        public string Model => "Equinox";
        public string Year => "2004-Current";
        public VehicleTypeEnum Type => VehicleTypeEnum.Suv;
    }

    public class EquinoxFactoryMethod : CarMethodFactory
    {
        protected override ICar GetCar()
        {
            return new Equinox();
        }
    }
}
