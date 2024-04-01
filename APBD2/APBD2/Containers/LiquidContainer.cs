using APBD2.Interfaces;
using APBD2.Methods;

namespace APBD2.Containers;

public class LiquidContainer(double height, double ownWeight, double depth, double maxCapacity)
    : Container(height, ownWeight, depth, maxCapacity), IHazardNotifier
{
    public override void Load(Cargo cargo,double mass)
    {
        base.Load(cargo,mass);
        if (cargo.Hazardous)
        {
            MaxCapacity *= 0.5;
            Warn();
        }
        else
        {
            MaxCapacity *= 0.9;
        }

        if (mass > MaxCapacity)
        {
            Warn();
        }

    }
    

    public void Warn()
    {
        Console.WriteLine("Dangerous situation in container: " + SerialNumber);
    }
    
}