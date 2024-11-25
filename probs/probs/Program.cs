using System;
using System.Collections.Generic;

// Базовый абстрактный класс Car
public abstract class Car
{
    public string Model { get; set; }
    public string LicensePlate { get; set; }

    public void StartEngine()
    {
        Console.WriteLine($"Двигатель автомобиля {Model} запущен.");
    }

    public void StopEngine()
    {
        Console.WriteLine($"Двигатель автомобиля {Model} остановлен.");
    }

    public abstract string GetCarType();
}

// Класс Sedan, наследующий Car
public class Sedan : Car
{
    public int TrunkCapacity { get; set; }

    public override string GetCarType()
    {
        return "Седан";
    }
}

// Класс Truck, наследующий Car
public class Truck : Car
{
    public int LoadCapacity { get; set; }

    public override string GetCarType()
    {
        return "Грузовик";
    }
}

// Класс MedicalCertificate
public class MedicalCertificate
{
    public int CertificateNumber { get; set; }
    public DateTime IssueDate { get; set; }
    public string DoctorName { get; set; }
}

// Класс Driver
public class Driver
{
    public string Name { get; set; }
    public int ExperienceYears { get; set; }
    public MedicalCertificate MedicalCertificate { get; set; }
}

// Класс Trip
public class Trip
{
    public Driver Driver { get; set; }
    public Car Car { get; set; }
    public DateTime TripDate { get; set; }
    public int StartTime { get; set; } // Время в минутах с начала дня
    public int EndTime { get; set; } // Время в минутах с начала дня

    public void DisplayTripInfo()
    {
        int duration = EndTime - StartTime;
        Console.WriteLine($"Водитель: {Driver.Name}, Дата поездки: {TripDate.ToShortDateString()}, Продолжительность поездки: {duration} минут, Тип автомобиля: {Car.GetCarType()}");
    }
}

// Класс Fleet
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

    public void CreateTrip(Driver driver, Car car, DateTime tripDate, int startTime, int endTime)
    {
        Trip trip = new Trip
        {
            Driver = driver,
            Car = car,
            TripDate = tripDate,
            StartTime = startTime,
            EndTime = endTime
        };
        Trips.Add(trip);
    }

    public void DisplayTripInfo(DateTime date)
    {
        foreach (var trip in Trips)
        {
            if (trip.TripDate.Date == date.Date)
            {
                trip.DisplayTripInfo();
            }
        }
    }
}

// Пример использования
public class Program
{
    public static void Main()
    {
        Fleet fleet = new Fleet();

        // Создаем автомобили
        Car sedan = new Sedan { Model = "Toyota Camry", LicensePlate = "A123BC", TrunkCapacity = 500 };
        Car truck = new Truck { Model = "Ford F-150", LicensePlate = "D456EF", LoadCapacity = 2000 };

        // Добавляем автомобили в автопарк
        fleet.AddCar(sedan);
        fleet.AddCar(truck);

        // Создаем водителей
        Driver driver1 = new Driver { Name = "Иван Иванов", ExperienceYears = 5, MedicalCertificate = new MedicalCertificate { CertificateNumber = 1, IssueDate = DateTime.Now, DoctorName = "Доктор Смит" } };
        Driver driver2 = new Driver { Name = "Петр Петров", ExperienceYears = 10, MedicalCertificate = new MedicalCertificate { CertificateNumber = 2, IssueDate = DateTime.Now, DoctorName = "Доктор Джонс" } };

        // Регистрируем водителей в автопарке
        fleet.RegisterDriver(driver1);
        fleet.RegisterDriver(driver2);

        // Создаем поездки
        fleet.CreateTrip(driver1, sedan, DateTime.Now, 60, 180); // Поездка с 1:00 до 3:00
        fleet.CreateTrip(driver2, truck, DateTime.Now, 100, 240); // Поездка с 2:00 до 4:00

        // Выводим информацию о поездках за текущую дату
        fleet.DisplayTripInfo(DateTime.Now);
    }
}
