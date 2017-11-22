using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSchoolValidator
{
    public interface IRouteObject
    {
        Coordinate GetCoordinates();
        string PrintToRoute();
    }
}
