using APBD2.Interfaces;
using APBD2.Methods;

namespace APBD2.Containers;

public class GasContainer(double height, double ownWeight, double depth, double maxCapacity, double pressure)
    : Container(height, ownWeight, depth, maxCapacity), IHazardNotifier
{

    public double Pressure { get; set; } = pressure;

    public override void Load(Cargo cargo, double mass)
    {
        base.Load(cargo, mass);
        if (cargo.Hazardous)
        {
            Warn();
        }
    }

    public override void Empty()
    {
        LoadMass *= 0.05;
    }

    public void Warn()
    {
        Console.WriteLine("Dangerous situation in container:  " + SerialNumber);
    }

    public override string ToString()
    {
        return base.ToString() + $", pressure: {Pressure}";
    }
}