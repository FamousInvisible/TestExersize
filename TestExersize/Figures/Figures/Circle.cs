using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Figures
{
    public class Circle : IFigure
    {
        public float Radius { get; set; }

        public Circle(float radius) { 
            Radius = radius;
        }
        public float CalculateSquare()
        {
            return (float)(Math.PI * Math.Pow(Radius, 2));
        }
    }
}
