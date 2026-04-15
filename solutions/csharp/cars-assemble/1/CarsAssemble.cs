using static System.Runtime.InteropServices.JavaScript.JSType;

static class AssemblyLine
{
    //    0: 0% success rate.
    //1 to 4: 100% success rate.
    //5 to 8: 90% success rate.
    //9: 80% success rate.
    //10: 77% success rate.
    public static double SuccessRate(int speed)
    {
        if (speed == 10) return 0.77;
        if (speed == 9) return 0.8;
        if (speed >= 5) return 0.9;
        if (speed >= 1) return 1.0;

        return 0.0;
    }

    //speed 1 = 221 per hours
    // 60 minutes = 221
    public static double ProductionRatePerHour(int speed)
    {
        int productionPerHour = 221;
        return (speed * productionPerHour) * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        var itemsPerHour = ProductionRatePerHour(speed);
        return (int)(itemsPerHour / 60);
    }
}
