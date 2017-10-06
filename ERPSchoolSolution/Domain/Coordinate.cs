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
        private bool CompareX(int xPosition)
        {
            return this.X == xPosition;
        }
        private bool CompareY(int yPosition)
        {
            return this.Y == yPosition;
        }
        private int GetDistanceX(int xPosition)
        {
            return Math.Abs(xPosition - this.X);
        }
        public int GetDistanceOf(Coordinate aCoordinate)
        {
            return GetDistanceX(aCoordinate.X);
        }
        public override bool Equals(object aCoordinate)
        {
            Coordinate theCoordinate = aCoordinate as Coordinate;
            return CompareX(theCoordinate.X) && CompareY(theCoordinate.Y);
        }
    }
}
