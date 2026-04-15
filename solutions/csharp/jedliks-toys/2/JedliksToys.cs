class RemoteControlCar
{
    private int _meters;
    private int _percentage = 100;

    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_meters} meters";
    }

    public string BatteryDisplay()
    {
        return _percentage == 0 
            ? "Battery empty" 
            : $"Battery at {_percentage}%";
    }

    public void Drive()
    {
        if (_percentage == 0) return;

        _meters += 20;
        _percentage = Math.Max(_percentage - 1, 0);
    }
}
