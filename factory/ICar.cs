namespace FactoryExample
{
    public interface ICar
    {
        string Make { get; }
        string Model { get; }
        string Year { get; }
        VehicleTypeEnum Type { get; }
    }
}
