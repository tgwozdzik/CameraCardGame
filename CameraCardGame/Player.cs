using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraCardGame
{
    class Player
    {
        private List<Card> cards { get; set; }
        private int _health { get; set; }
        private int armor { get; set; }
        private int attack { get; set; }
        private int _cardsLeft { get; set; }
        private int _manaCristals { get; set; }

        public Player(List<Card> cards, int health, int armor, int attack, int cardsLeft, int manaCristals)
        {
            this.cards = cards;
            this.health = health;
            this.armor = armor;
            this.attack = attack;
            this._cardsLeft = cardsLeft;
            this.manaCristals = manaCristals;
        }

        public int cardsLeft { get { return _cardsLeft; } set { this._cardsLeft = value; } }
        public int health { get { return _health; } set { this._health = value; } }
        public int manaCristals { get { return _manaCristals; } set { this._manaCristals = value; } }
    }
}
