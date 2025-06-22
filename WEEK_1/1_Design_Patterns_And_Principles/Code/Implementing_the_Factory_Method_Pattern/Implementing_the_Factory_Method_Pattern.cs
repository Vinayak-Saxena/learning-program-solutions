using System;

public interface IVehicle
{
    void Drive();
}


public class TwoWheeler : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Driving a Two-Wheeler");
    }
}

public class ThreeWheeler : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Driving a Three-Wheeler");
    }
}

public class FourWheeler : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Driving a Four-Wheeler");
    }
}


public abstract class VehicleFactory
{
    public abstract IVehicle CreateVehicle();

    public void StartJourney()
    {
        IVehicle vehicle = CreateVehicle();
        vehicle.Drive();
    }
}



public class TwoWheelerFactory : VehicleFactory
{
    public override IVehicle CreateVehicle()
    {
        return new TwoWheeler();
    }
}

public class ThreeWheelerFactory : VehicleFactory
{
    public override IVehicle CreateVehicle()
    {
        return new ThreeWheeler();
    }
}

public class FourWheelerFactory : VehicleFactory
{
    public override IVehicle CreateVehicle()
    {
        return new FourWheeler();
    }
}


public class Program
{
    public static void Main()
    {
        Console.WriteLine("Select a vehicle to drive:");
        Console.WriteLine("1. Two Wheeler");
        Console.WriteLine("2. Three Wheeler");
        Console.WriteLine("3. Four Wheeler");

        string? choice = Console.ReadLine();

        VehicleFactory factory = choice switch
        {
            "1" => new TwoWheelerFactory(),
            "2" => new ThreeWheelerFactory(),
            "3" => new FourWheelerFactory(),
            _   => throw new ArgumentException("Invalid choice")
        };

        factory.StartJourney();
    }
}
