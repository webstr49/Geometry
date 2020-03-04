using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry.Models
{
    public class Square : ShapeBase
    {

        public Square()
        {
            Parameters.Add("a", 0);
            ImagePath = AppDomain.CurrentDomain.BaseDirectory + InformationString.SquareImagePath;
        }

        public override decimal CalcArea()
        {
            if (0 == Parameters["a"])
                return -1;

            return Parameters["a"] * Parameters["a"];
        }
    }
}
