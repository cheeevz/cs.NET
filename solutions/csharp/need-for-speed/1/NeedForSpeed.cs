class RemoteControlCar
{
    public int speed;
    public int batteryDrain;
    private int distanceDriven = 0;
    private int battery = 100;
    private bool batteryDrained = false;
    
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        return this.battery < this.batteryDrain;
    }

    public int DistanceDriven()
    {
       return this.distanceDriven;
    }

    public void Drive()
    {
         if (this.battery >= this.batteryDrain)
        {
            this.distanceDriven += this.speed;
            this.battery -= this.batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private int distance;

    public RaceTrack(int distance){
        this.distance = distance;
    }
    public bool TryFinishTrack(RemoteControlCar car)
    {
        if (this.distance <= (100/car.batteryDrain*car.speed)){
            return true;
        }
        else {
            return false;
        }
    }
}
