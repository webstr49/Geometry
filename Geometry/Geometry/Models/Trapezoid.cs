using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry.Models
{
    public class Trapezoid : ShapeBase
    {
        public Trapezoid()
        {
            Parameters.Add("a", 0);
            Parameters.Add("c", 0);
            Parameters.Add("v", 0);
            ImagePath = AppDomain.CurrentDomain.BaseDirectory + InformationString.TrapezoidImagePath;
        }

        public override decimal CalcArea()
        {
    
            if (0 == Parameters["a"] || 0 == Parameters["c"] || 0 == Parameters["v"])
            return -1;

            return (Parameters["a"] + Parameters["c"]) / 2 * Parameters["v"];
        }
    }
}
