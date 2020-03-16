using System;
using System.Collections.Generic;
using System.Text;

namespace Snakes_and_Ladders
{
    class Player
    {
        public readonly string Name;
        public const int startPosition = 0;
        public const int WINPOSITION = 100;
        private int _currentPosition;

        public int CurrentPosition
        {
            get { return _currentPosition; }
            set {
                _currentPosition = value;
                }
        }
        public Player(string name)
        {
            Name = name;
            CurrentPosition = startPosition;
        }

    }
}
