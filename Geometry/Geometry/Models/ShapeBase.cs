using System;
using System.Collections.Generic;

namespace Geometry.Models
{
    public abstract class ShapeBase
    {
        private Dictionary<string, decimal> _parameters;
        private string imagePath;

        public Dictionary<string, decimal> Parameters { get => _parameters; set => _parameters = value; }
        public string ImagePath { get => imagePath; set => imagePath = value; }
        public ShapeBase()
        {
            Parameters = new Dictionary<string, decimal>();
        }

        public abstract decimal CalcArea();
    }
}
