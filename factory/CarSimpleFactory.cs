namespace FactoryExample
{
    public class CarSimpleFactory
    {
        public ICar GetSilverado() => new Silverado();
        public ICar GetF150() => new F150();
        public ICar GetEquinox() => new Equinox();
        public ICar GetExplorer() => new Explorer();
    }
}
