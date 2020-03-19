using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip
{
    public class Ships
    {
        public string name;
        public int spaces;    
        
        public Ships(string name, int spaces)
        {
            this.name = name;
            this.spaces = spaces;
        }
    }
}
