using APBD2.Methods;

namespace APBD2.Containers;

public class CoolingContainer(double height, double ownWeight, double depth, double maxCapacity,
    double temperature, CargoType compatibleCargoType)
    : Container(height, ownWeight, depth, maxCapacity)
{

    public double Temperature { get; set; } = temperature;
    public CargoType CompatibleCargoType { get; set; } = compatibleCargoType;

    public override void Load(Cargo cargo, double mass)
    {
        if (cargo.Hazardous)
        {
            Console.WriteLine("Nie można transportować niebezpiecznych produktów w kontenerze chłodzącym");
            return;
        }
        else if (Temperature < cargo.Temperature)
        {
            Console.WriteLine($"Temperatura w kontenerze: {SerialNumber} jest zbyt niska dla produktu: {cargo.CargoName}");
        }
        else if (!CompatibleCargoType.Equals(cargo.CargoType))
        {
            Console.WriteLine($"Typ: {cargo.CargoType} rożni się od typu kontenera: {CompatibleCargoType}");
        }
        else {
            base.Load(cargo, mass);
        }
    }

    public override string ToString()
    {
        return base.ToString() + $", temperature: {Temperature}, compatible cargo type: {CompatibleCargoType}";
    }
}