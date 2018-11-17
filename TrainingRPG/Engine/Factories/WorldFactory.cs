using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        internal World CreateWorld()
        {
            var world = new World();

            var farmFields = new Location
            {
                XCoordinate = 0,
                YCoordinate = 0,
                Name = "Farmer's Field",
                Description = "There are rows of corn growing here, with giant rats hiding between them.",
                ImageName = "/Engine;component/Images/Locations/FarmFields.png"
            };

            var farmHouse = new Location
            {
                XCoordinate = 0,
                YCoordinate = 0,
                Name = "Farmer's House",
                Description = "This is the house of your neighbor, Farmer Ted.",
                ImageName = "/Engine;component/Images/Locations/Farmhouse.png"
            };

            var herbalistsGarden = new Location
            {
                XCoordinate = 0,
                YCoordinate = 0,
                Name = "Herbalist's garden",
                Description = "There are many plants here, with snakes hiding behind them.",
                ImageName = "/Engine;component/Images/Locations/HerbalistsGarden.png"
            };

            var herbalistsHut = new Location
            {
                XCoordinate = 0,
                YCoordinate = 0,
                Name = "Herbalist's hut",
                Description = "You see a small hut, with plants drying from the roof.",
                ImageName = "/Engine;component/Images/Locations/HerbalistsHut.png"
            };

            var home = new Location
            {
                XCoordinate = 0,
                YCoordinate = -1,
                Name = "Home",
                Description = "This is your house",
                ImageName = "/Engine;component/Images/Locations/Home.png"
            };

            var spiderForest = new Location
            {
                XCoordinate = 0,
                YCoordinate = 0,
                Name = "Spider Forest",
                Description = "The trees in this forest are covered with spider webs.",
                ImageName = "/Engine;component/Images/Locations/SpiderForest.png"
            };

            var townGate = new Location
            {
                XCoordinate = 0,
                YCoordinate = 0,
                Name = "Town Gate",
                Description = "There is a gate here, protecting the town from giant spiders.",
                ImageName = "/Engine;component/Images/Locations/TownGate.png"
            };

            var townSquare = new Location
            {
                XCoordinate = 0,
                YCoordinate = 0,
                Name = "Town square",
                Description = "You see a fountain here.",
                ImageName = "/Engine;component/Images/Locations/TownSquare.png"
            };

            var trader = new Location
            {
                XCoordinate = 0,
                YCoordinate = 0,
                Name = "Trading Shop",
                Description = "The shop of Susan, the trader.",
                ImageName = "/Engine;component/Images/Locations/Trader.png"
            };

            farmFields.Link(Portal.Side.East, farmHouse);
            farmHouse.Link(Portal.Side.East, home);
            farmHouse.Link(Portal.Side.North, trader);

            trader.Link(Portal.Side.East, townSquare);
            townSquare.Link(Portal.Side.North, herbalistsHut);
            herbalistsHut.Link(Portal.Side.North, herbalistsGarden);
            townSquare.Link(Portal.Side.South, home);

            townSquare.Link(Portal.Side.East, townGate);
            spiderForest.Link(Portal.Side.West, townGate);

            world.StartingLocation = home;

            return world;
        }
    }
}
