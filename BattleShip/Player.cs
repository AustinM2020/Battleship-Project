using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip
{
    public class Player
    {
        public string name;
        public string placeChoice;
        public string attackChoice;
    
        public Player(string name, string placeChoice, string attackChoice)
        {
            this.name = name;
            this.placeChoice = placeChoice;
            this.attackChoice = attackChoice;
        }
    
    
    }
}
