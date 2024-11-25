using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Car
{
    public string Model { get; set; }
    public string LicencePlate { get; set; }

    
    public string StartEngine()
    {
        return ($"Двигатель автомобиля {Model} запущен.");
    }
    public string StopEngine()
    {
        return ($"Двигатель автомобиля {Model} остановлен.");
    }

    public abstract string GetCarType();
    public abstract string GetCarFuel();
}

