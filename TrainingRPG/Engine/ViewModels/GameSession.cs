using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Engine.Models;
using Engine.Factories;

namespace Engine.ViewModels
{
    public class GameSession : INotifyPropertyChanged
    {
        private Location _currentLocation;

        public Player CurrentPlayer { get; set; }

        public Location CurrentLocation
        {
            get => _currentLocation;
            set
            {
                _currentLocation = value;
                OnPropertyChanged(nameof(CurrentLocation));
            }
        }

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

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
