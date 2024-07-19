using System;
using System.Collections.Generic;

// Base class
public abstract class Activity
{
    public DateTime Date { get; set; }
    public int DurationMinutes { get; set; }

    public Activity(DateTime date, int durationMinutes)
    {
        Date = date;
        DurationMinutes = durationMinutes;
    }

    // Abstract methods to be overridden in derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Method to get a summary of the activity
    public string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} {GetType().Name} ({DurationMinutes} min) - Distance {GetDistance()} {GetDistanceUnit()}, Speed {GetSpeed()} {GetSpeedUnit()}, Pace: {GetPace()} {GetPaceUnit()}";
    }

    protected abstract string GetDistanceUnit();
    protected abstract string GetSpeedUnit();
    protected abstract string GetPaceUnit();
}

// Derived class for Running
public class Running : Activity
{
    public double Distance { get; set; } // Distance in miles

    public Running(DateTime date, int durationMinutes, double distance)
        : base(date, durationMinutes)
    {
        Distance = distance;
    }

    public override double GetDistance() => Distance;

    public override double GetSpeed() => (Distance / DurationMinutes) * 60; // Speed in mph

    public override double GetPace() => DurationMinutes / Distance; // Pace in min per mile

    protected override string GetDistanceUnit() => "miles";
    protected override string GetSpeedUnit() => "mph";
    protected override string GetPaceUnit() => "min per mile";
}

// Derived class for Cycling
public class Cycling : Activity
{
    public double Speed { get; set; } // Speed in mph

    public Cycling(DateTime date, int durationMinutes, double speed)
        : base(date, durationMinutes)
    {
        Speed = speed;
    }

    public override double GetDistance() => (Speed * DurationMinutes) / 60; // Distance in miles

    public override double GetSpeed() => Speed;

    public override double GetPace() => 60 / Speed; // Pace in min per mile

    protected override string GetDistanceUnit() => "miles";
    protected override string GetSpeedUnit() => "mph";
    protected override string GetPaceUnit() => "min per mile";
}

// Derived class for Swimming
public class Swimming : Activity
{
    public int Laps { get; set; } // Number of laps

    public Swimming(DateTime date, int durationMinutes, int laps)
        : base(date, durationMinutes)
    {
        Laps = laps;
    }

    public override double GetDistance() => (Laps * 50) / 1000.0; // Distance in kilometers

    public override double GetSpeed() => (GetDistance() / DurationMinutes) * 60; // Speed in kph

    public override double GetPace() => DurationMinutes / GetDistance(); // Pace in min per km

    protected override string GetDistanceUnit() => "km";
    protected override string GetSpeedUnit() => "kph";
    protected override string GetPaceUnit() => "min per km";
}

// Program class to test the implementation
public class Program
{
    public static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 3.0),
            new Cycling(new DateTime(2022, 11, 4), 45, 15.0),
            new Swimming(new DateTime(2022, 11, 5), 60, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
