using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry.Models
{
    public class Rectangle : ShapeBase
    {
        public Rectangle()
        {
            Parameters.Add("a", 0);
            Parameters.Add("b", 0);
            ImagePath = AppDomain.CurrentDomain.BaseDirectory + InformationString.RectangleImagePath;
        }

        public override decimal CalcArea()
        {
            if (Parameters["a"] == 0 || Parameters["b"] == 0)
                return -1;

            return Parameters["a"] * Parameters["b"];
        }
     
    }
}
