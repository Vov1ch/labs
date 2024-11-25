using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

public class Trip
{
    public Driver Driver { get; set; }
    public Car Car { get; set; }
    public DateTime TripDate { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public void DisplayTripInfo()
    {
        TimeSpan duration = (EndTime - StartTime);
        double totalMinutes = duration.TotalMinutes;
        int x = Convert.ToInt32(totalMinutes);
        Console.WriteLine("ездки за сегодня:");
        Console.WriteLine($"Водитель: {Driver.Name}, Дата поездки: {TripDate}, Продолжительность поездки: {x} минут," +
            $" Тип автомобиля: {Car.GetCarType()}, Тип топлива: {Car.GetCarFuel()} ");
    }

}
