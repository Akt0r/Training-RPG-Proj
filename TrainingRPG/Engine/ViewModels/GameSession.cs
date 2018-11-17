using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
using Engine.Factories;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }

        public Location CurrentLocation { get; set; }


        public World CurrentWorld { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player
            {
                Name = "Burgolort",
                Gold = 1000000,
                CharacterClass = "Berserk",
                ExperiencePoints = 0,
                HitPoints = 10,
                Level = 1
            };

            var worldFactory = new WorldFactory();
            CurrentWorld = worldFactory.CreateWorld();
            CurrentLocation = CurrentWorld.StartingLocation;
        }
    }
}
