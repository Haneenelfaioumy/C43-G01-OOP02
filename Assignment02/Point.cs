using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    internal struct Point
    {
        #region Attributes
        public double X { get; set; }
        public double Y { get; set; }
        #endregion

        #region Constructor
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        #endregion

        #region Method
        public static double CalculateDistance(Point p1, Point p2)
        {
            double deltaX = p2.X - p1.X; //x distance
            double deltaY = p2.Y - p1.Y; //y distance
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        } 
        #endregion

    }
}
