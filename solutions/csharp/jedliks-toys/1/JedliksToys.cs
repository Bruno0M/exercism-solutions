class RemoteControlCar
{
    public int Meters { get; set; }
    public int Percentage { get; set; } = 100;

    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {Meters} meters";
    }

    public string BatteryDisplay()
    {
        if (Percentage == 0) return "Battery empty";
        return $"Battery at {Percentage}%";
    }

    public void Drive()
    {
        if (Percentage == 0) return;

        Meters += 20;
        Percentage -= 1;
    }
}
