using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Fleet
{
    public List<Car> Cars { get; set; }
    public List<Driver> Drivers { get; set; }
    public List<Trip> Trips { get; set; }
    public Fleet()
    {
        Cars = new List<Car>();
        Drivers = new List<Driver>();
        Trips = new List<Trip>();
    }
    public void AddCar(Car car)
    {
        Cars.Add(car);
    }
    public void RegisterDriver(Driver driver)
    {
        Drivers.Add(driver);
    }
    public void CreateTrip(Driver driver, Car car,DateTime data, DateTime startTime, DateTime endTime)
    {
        Trip trip = new Trip
        {
            Driver = driver,
            Car = car,
            TripDate = data,
            StartTime = startTime,
            EndTime = endTime
        };
        Trips.Add(trip);
    }
    public void DisplayTripsByDate()
    {
        foreach (var trip in Trips)
        {

            trip.DisplayTripInfo();

        }
    }
}