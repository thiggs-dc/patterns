namespace FactoryExample
{
    public class Explorer : ICar
    {
        public string Make => "Ford";
        public string Model => "Explorer";
        public string Year => "1990-Current";
        public VehicleTypeEnum Type => VehicleTypeEnum.Suv;
    }

    public class ExplorerFactoryMethod : CarMethodFactory
    {
        protected override ICar GetCar()
        {
            return new Explorer();
        }
    }
}
