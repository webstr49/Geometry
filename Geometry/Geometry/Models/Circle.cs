using System;
using System.Collections.Generic;
using System.Text;


namespace Geometry.Models
{
    public class Circle : ShapeBase
    {
        public Circle()
        {
            Parameters.Add("r", 0);
            ImagePath = AppDomain.CurrentDomain.BaseDirectory + InformationString.CircleImagePath;
        }
        public override decimal CalcArea()
        {
            var a = Parameters["r"];
            if (a == 0)
                return -1;

            return a * a* (decimal)Math.PI;
        }
    }
}
