namespace APBD2.Methods;

public class Cargo(string cargoName,CargoType cargoType,double temperature, bool hazardous)
{
    public string CargoName { get; } = cargoName;
    public CargoType CargoType { get; } = cargoType;
    public double Temperature { get; } = temperature;
    public bool Hazardous { get; } = hazardous;

    public override string ToString()
    {
        return $"{CargoName}, cargo type: {CargoType}, cargo temperature: {Temperature}, cargo hazard: {hazardous}";
    }
}

public enum CargoType
{
    Fruit,
    Meat,
    Dairy,
    Fuel,
    Chemical
}