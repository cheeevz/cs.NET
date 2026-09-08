class RemoteControlCar
{
    int distance = 0;
    int battery = 100;
    
    public static RemoteControlCar Buy()
    {
        RemoteControlCar car = new RemoteControlCar();
        return car;
    }

    public string DistanceDisplay()
    {
        return $"Driven {distance} meters";
    }

    public string BatteryDisplay()
    {
        if (battery == 0){
            return "Battery empty";
        }
        else {        
            return $"Battery at {battery}%";
        }
    }

    public void Drive()
    {
        if (battery > 0){
        battery -=1;
        distance +=20;
        }
    }
}
