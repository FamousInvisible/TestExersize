using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Figures
{
    public class Triangle : ITriangle
    {
        public float X {  get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public Triangle(float x, float y, float z) { 
            X = x;
            Y = y;
            Z = z;
        }

        public float CalculateSquare()
        { 
            float halfPerimetr = (X + Y + Z) / 2;
            return (float)(Math.Pow((double)(halfPerimetr * (halfPerimetr - X) * (halfPerimetr - Y) * (halfPerimetr - Z)), 0.5));
        }

        public bool CheckRightTriangle()
        {
            float powX = (float)Math.Pow(X, 2);
            float powY = (float)Math.Pow(Y, 2);
            float powZ = (float)Math.Pow(Z, 2);

            List<float> sides = [powX, powY, powZ];
            float maxSide = sides.Max();
            sides.Remove(maxSide);
            float sum = sides.Sum();
            return maxSide == sum;
        }
    }
}
