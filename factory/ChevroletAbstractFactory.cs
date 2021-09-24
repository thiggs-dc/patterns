namespace FactoryExample
{
    public class ChevroletAbstractFactory
    {
        public ICar GetTruck() => new Silverado();
        public ICar GetSuv() => new Equinox();
    }
}
