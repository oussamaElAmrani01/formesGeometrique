using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace formesGeometrique
{
    public class Point : IPoint
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double Distance(Point autrePoint)
        {
            double distanceX = (autrePoint.X - X) > 0 ? (autrePoint.X - X) : (X - autrePoint.X);
            double distanceY = (autrePoint.Y - Y) > 0 ? (autrePoint.Y - Y) : (Y - autrePoint.Y);

            return Math.Sqrt(Math.Pow(distanceX,2) + Math.Pow(distanceY, 2));
        }

        public bool Egalite(Point autrePoint)
        {
            return (X == autrePoint.X && Y == autrePoint.Y);
        }

        public Point Translation()
        {
            return new Point(X * (-1), Y);
        }


        public bool Linearite(Point pointB, Point pointC)
        {
            if (!(pointB.X % pointC.X == 0 && pointB.Y % pointC.Y == 0))
                return false;
            return (X % pointB.X == 0 && Y % pointB.Y == 0);
        }
    }
}
