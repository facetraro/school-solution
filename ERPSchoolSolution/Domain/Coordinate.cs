using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override bool Equals(object aCoordinate)
        {
            Coordinate theCoordinate = aCoordinate as Coordinate;
            return (this.X == theCoordinate.X && this.Y==theCoordinate.Y);
        }
    }
}
