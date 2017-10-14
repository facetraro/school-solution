using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Coordinate : IRouteObject
    {
        private int x { get; set; }
        private int y { get; set; }
        public Coordinate GetCoordinates()
        {
            return this;
        }
        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }
        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }
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
        private int GetDistanceY(int yPosition)
        {
            return Math.Abs(yPosition - this.Y);
        }
        public int GetDistanceOf(Coordinate aCoordinate)
        {
            return GetDistanceX(aCoordinate.X) + GetDistanceY(aCoordinate.Y);
        }
        public override bool Equals(object aCoordinate)
        {
            Coordinate theCoordinate = aCoordinate as Coordinate;
            return CompareX(theCoordinate.X) && CompareY(theCoordinate.Y);
        }
        public string PrintCoordinate()
        {
            return "[" + this.X + "," + this.Y + "]";
        }
    }
}
