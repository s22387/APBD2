using System.Collections;
using APBD2.Exception;
using APBD2.Methods;

namespace APBD2.Containers;

public abstract class Container
{
    private static int _id = 0;

    public int Id { get; } = _id++;
    public double LoadMass { get; set; }
    public double Height { get; set; } 
    public double OwnWeight { get; set; } 
    public double Depth { get; set; } 
    public double MaxCapacity { get; set; }
    public Cargo ContainerCargo { get; set; }
    public string SerialNumber { get; }

    protected Container(double height, double ownWeight, double depth, double maxCapacity)
    {
        Height = height;
        OwnWeight = ownWeight;
        Depth = depth;
        MaxCapacity = maxCapacity;
        SerialNumber = GenerateSerialNumber();
        LoadMass = 0;
    }


    public virtual void Empty()
    {
        LoadMass = 0;
        ContainerCargo = null;
    }

    public virtual void Load(Cargo cargo,double mass)
    {
        if (mass > MaxCapacity)
        {
            throw new OverfillException();
        }

        ContainerCargo = cargo;
        LoadMass = mass;
    }

    private string GenerateSerialNumber()
    {
        return "KON-" + GetType().Name[0] + "-" + _id;
    }

    public virtual string ToString()
    {
        return $"container serial number: {SerialNumber}, load mass: {LoadMass}, height: {Height}, " +
               $"container's own weight: {OwnWeight}, depth: {Depth}, max capacity: {MaxCapacity}, " +
               $"container's cargo: {ContainerCargo}, ";
    }
    
}