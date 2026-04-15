using System.Runtime.CompilerServices;

class BirdCount
{
    private int[] _birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        _birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return [0, 2, 5, 3, 7, 8, 4];
    }

    public int Today()
    {
        return _birdsPerDay.LastOrDefault();
    }

    public void IncrementTodaysCount()
    {
        _birdsPerDay[_birdsPerDay.Length - 1]++;
    }

    public bool HasDayWithoutBirds()
    {
        return _birdsPerDay.Contains(0);
    }

    public int CountForFirstDays(int numberOfDays)
    {
        return _birdsPerDay[..numberOfDays].Sum();
    }

    public int BusyDays()
    {
        var gardenLimit = 5;
        return _birdsPerDay.Count(b => b >= gardenLimit);
    }
}
