using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_2_2
{
    class Triangle : ICalculatingFigureProperties
    {
        private double[] coordinates;

        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            coordinates = new double[] { x1, y1, x2, y2, x3, y3 };
        }
        public double Perimeter
        {
            get
            {
                double a = Math.Sqrt(Math.Pow(coordinates[2] - coordinates[0], 2) + Math.Pow(coordinates[3] - coordinates[1], 2));
                double b = Math.Sqrt(Math.Pow(coordinates[4] - coordinates[2], 2) + Math.Pow(coordinates[5] - coordinates[3], 2));
                double c = Math.Sqrt(Math.Pow(coordinates[4] - coordinates[0], 2) + Math.Pow(coordinates[5] - coordinates[1], 2));
                return a + b + c;
            }
        }

        public double Square()
        {
            double a = Math.Sqrt(Math.Pow(coordinates[2] - coordinates[0], 2) + Math.Pow(coordinates[3] - coordinates[1], 2));
            double b = Math.Sqrt(Math.Pow(coordinates[4] - coordinates[2], 2) + Math.Pow(coordinates[5] - coordinates[3], 2));
            double c = Math.Sqrt(Math.Pow(coordinates[4] - coordinates[0], 2) + Math.Pow(coordinates[5] - coordinates[1], 2));
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
