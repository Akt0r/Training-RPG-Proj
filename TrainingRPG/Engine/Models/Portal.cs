using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Portal
    {
        public Location Destination { get; set; }

        private const int MaxSide = 8;

        [Flags]
        public enum Side
        {
            None = 0,
            North = 1,
            East = 2,
            South = 4,
            West = MaxSide
        }

        public static Side GetOpposite(Side side)
        {
            if (side.HasFlag(Side.North | Side.South))
            { throw new InvalidOperationException(); }
            if (side.HasFlag(Side.East | Side.West))
            { throw new InvalidOperationException(); }
            int result = (int)side << 2;
            result = result > MaxSide
                ? result >> 4
                : result;
            return (Side)result;
        }
    }
}
