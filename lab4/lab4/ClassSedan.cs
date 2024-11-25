using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Sedan : Car
{
    public int TrunkCapacity { get; set; }
    public override string GetCarType()
    {
        return "Sedan";
    }
    public override string GetCarFuel()
    {
        return "Gaz";
    }
}
