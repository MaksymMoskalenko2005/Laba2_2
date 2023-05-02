using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_2_2
{
        class Circle : ICalculatingFigureProperties
        {
            private double radius;

            public Circle(double radius)
            {
                this.radius = radius;
            }

            public double Perimeter
            {
                get
                {
                    return 2 * Math.PI * radius;
                }
            }
            public double Square()
            {
                return Math.PI * Math.Pow(radius, 2);
            }
        }
}
