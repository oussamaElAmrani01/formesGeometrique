using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formesGeometrique
{
    public interface IPoint
    {
        double Distance(Point autrePoint);
        bool Egalite(Point autrePoint);
        Point Translation();
        bool Linearite(Point pointB, Point pointC);
    }
}
