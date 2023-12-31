using System;

class Run : Activity
{
    public Run(string dt, double dr, double x) : base(dt, dr, x){}
    public override double CalculateDistance(){
        return Math.Round(distance, 2);
    }
    public override double CalculateSpeed(){
        return Math.Round(distance/(duration/60), 2);
    }
    public override double CalculatePace(){
        return Math.Round(duration/distance, 2);
    }
    public override string GetSummary(){
        return $"{date} - Running - Distance: {CalculateDistance()}km, Speed: {CalculateSpeed()}km/h, Pace: {CalculatePace()}min/km";
    }
}