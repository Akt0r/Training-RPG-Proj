using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Engine.Models.Portal;

namespace Engine.Models
{
    public class Location
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }

        public Dictionary<Side, Portal> Portals { get; private set; } = new Dictionary<Side, Portal>();

        public Side AwailableSides { get; set; }

        public void Link(Side side, Location destination)
        {
            if (destination == null)
            { throw new ArgumentNullException(nameof(destination)); }

            if (AwailableSides.HasFlag(side))
            { throw new InvalidOperationException($"Location {this} already has portal for {side}"); }
            if (destination.AwailableSides.HasFlag(GetOpposite(side)))
            { throw new InvalidOperationException($"Location {destination} already has portal for {GetOpposite(side)}"); }

            Portals.Add(side, new Portal() { Destination = destination });
            AwailableSides |= side;

            Side opposite = GetOpposite(side);
            destination.Portals.Add(opposite, new Portal() { Destination = this });
            destination.AwailableSides |= opposite;
        }

        public Location NorthLocation()
        {
            return LocationAt(Side.North);
        }

        public Location WestLocation()
        {
            return LocationAt(Side.West);
        }

        public Location EastLocation()
        {
            return LocationAt(Side.East);
        }

        public Location SouthLocation()
        {
            return LocationAt(Side.South);
        }

        public bool HasLocationToNorth
        { get => AwailableSides.HasFlag(Side.North); }

        public bool HasLocationToWest
        { get => AwailableSides.HasFlag(Side.West); }

        public bool HasLocationToEast
        { get => AwailableSides.HasFlag(Side.East); }

        public bool HasLocationToSouth
        { get => AwailableSides.HasFlag(Side.South); }

        private Location LocationAt(Side side)
        {
            if (AwailableSides.HasFlag(side))
            {
                return Portals[side].Destination;
            }
            throw new InvalidOperationException();
        }
    }
}
