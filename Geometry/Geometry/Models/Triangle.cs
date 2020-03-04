using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry.Models
{
    public class Triangle : ShapeBase
    {
        public Triangle()
        {
            Parameters.Add("a", 0);
            Parameters.Add("v", 0);          
            ImagePath = AppDomain.CurrentDomain.BaseDirectory + InformationString.TriangleImagePath;
        }

        public override decimal CalcArea()
        {
           
            if (0 == Parameters["a"] || 0 == Parameters["v"])
                return -1;

            return Parameters["a"] * Parameters["v"] / 2;
        }
    }
}
