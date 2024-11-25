using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Truck : Car
{
    public int LoadCapacity { get; set; }
    public override string GetCarType()
    {
        return "Truck";
    }
    public override string GetCarFuel()
    {
        return "Disel";
    }
}
