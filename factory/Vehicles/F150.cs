namespace FactoryExample
{
    public class F150 : ICar
    {
        public string Make => "Ford";
        public string Model => "F150";
        public string Year => "1975-Current";
        public VehicleTypeEnum Type => VehicleTypeEnum.Truck;

    }

    public class F150FactoryMethod : CarMethodFactory
    {
        protected override ICar GetCar()
        {
            return new F150();
        }
    }
}
