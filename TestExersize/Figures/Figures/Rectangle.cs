using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Figures
{
    public class Rectangle : IFigure
    {
        public float Height { get; set; }
        public float Width { get; set; }

        public Rectangle(float height, float width) {
            Height = height;
            Width = width;
        }
        public float CalculateSquare()
        {
            return Height * Width;
        }
    }
}
