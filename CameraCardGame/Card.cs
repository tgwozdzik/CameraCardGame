using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraCardGame
{
    class Card
    {
        private int health { get; set; }
        private int attack { get; set; }
        private int cost { get; set; }
        private bool isTaunt { get; set; }

        public Card(int health, int attack, int cost, bool isTaunt)
        {
            this.health = health;
            this.attack = attack;
            this.cost = cost;
            this.isTaunt = isTaunt;
        }
    }
}
