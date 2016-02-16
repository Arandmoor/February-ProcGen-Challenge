using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformerLSystem.Util
{
    /// <summary>
    /// Simple point class for use with HighLevelRooms.
    /// </summary>
    public class GridPos : IComparable<GridPos>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public GridPos North { get { return new GridPos(X, Y + 1); } }
        public GridPos South { get { return new GridPos(X, Y - 1); } }
        public GridPos East { get { return new GridPos(X + 1, Y); } }
        public GridPos West { get { return new GridPos(X - 1, Y); } }

        public GridPos(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int CompareTo(GridPos other)
        {
            if (other.X == X && other.Y == Y) return 0;
            else
            {
                int maxX = Math.Max(X, other.X);
                return (Y * maxX + X) - (other.Y * maxX + other.X);
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X * 1109) ^ (Y * 2521);
            }
        }

        public override string ToString()
        {
            return string.Format("({0}:{1})", X, Y);
        }
    }

    public class GridPosEqualityComparer : IEqualityComparer<GridPos>
    {
        public bool Equals(GridPos x, GridPos y)
        {
            return x.X == y.X && x.Y == y.Y;
        }

        public int GetHashCode(GridPos obj)
        {
            unchecked
            {
                return (obj.X * 1109) ^ (obj.Y * 2521);
            }
        }
    }
}
