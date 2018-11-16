using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }

        public Location CurrentLocation { get; set; }

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

            CurrentLocation = new Location
            {
                XCoordinate = 0,
                YCoordinate = -1,
                Name = "Home",
                Description = "This is your house",
                ImageName = "/Engine;component/Images/Locations/Home.png"
            };
        }
    }
}
