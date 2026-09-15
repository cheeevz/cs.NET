using System.Linq;

public interface IRemoteControlCar 
{
    int DistanceTravelled {get; set;}
    int NumberOfVictories {get; set;}
    void Drive();
}
public class ProductionRemoteControlCar : IRemoteControlCar, IComparable<ProductionRemoteControlCar>
{
    public int DistanceTravelled { get; private set; }
    public int NumberOfVictories { get; set; }

    int IRemoteControlCar.DistanceTravelled
    {
        get => DistanceTravelled;
        set => DistanceTravelled = value;
    }

    public void Drive()
    {
        DistanceTravelled += 10;
    }

    public int CompareTo(ProductionRemoteControlCar other)
    {
        return NumberOfVictories.CompareTo(other.NumberOfVictories);
    }
}

public class ExperimentalRemoteControlCar : IRemoteControlCar
{
    public int DistanceTravelled { get; private set; }
    public int NumberOfVictories { get; set; }

    int IRemoteControlCar.DistanceTravelled
    {
        get => DistanceTravelled;
        set => DistanceTravelled = value;
    }

    public void Drive()
    {
        DistanceTravelled += 20;
    }
}

public static class TestTrack
{
    public static void Race(IRemoteControlCar car)
    {
        car.Drive();    
    }

    public static List<ProductionRemoteControlCar> GetRankedCars(ProductionRemoteControlCar prc1,
        ProductionRemoteControlCar prc2)
    {
        return new List<ProductionRemoteControlCar> { prc1, prc2 }.OrderBy(c => c).ToList();
    }
}
