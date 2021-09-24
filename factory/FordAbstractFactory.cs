namespace FactoryExample
{
    public class FordAbstractFactory
    {
        public ICar GetTruck() => new F150();
        public ICar GetSuv() => new Explorer();
    }
}
