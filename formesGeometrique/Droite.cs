using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formesGeometrique
{
    public class Droite : IDroite
    {
        public Point pointA { get; set; }
        public Point pointB { get; set; }

        public Droite(Point pointA, Point pointB)
        {
            this.pointA = pointA;
            this.pointB = pointB;
        }

        public bool Egalite(Droite droite)
        {
            return (pointA.Egalite(droite.pointA) && pointB.Egalite(droite.pointB));
        }

        public bool Parallelisme(Droite droite)
        {
            return (droite.pointA == pointA.Translation() && droite.pointB == pointB.Translation());
            }

        public bool Intersection(Droite droite)
        {
            double coefficientA = ((pointB.Y - pointA.Y) / (pointB.X - pointA.Y));
            double coefficientB = ((droite.pointB.Y - droite.pointA.Y) / (droite.pointB.X - droite.pointA.X));

            return coefficientA != coefficientB;
        }
    }
}
