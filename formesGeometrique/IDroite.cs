using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formesGeometrique
{
    interface IDroite
    {
        bool Egalite(Droite droite);
        bool Parallelisme(Droite droite);
        bool Intersection(Droite droite);
    }
}
