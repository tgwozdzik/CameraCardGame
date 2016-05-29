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

        private bool _vaitingForQRCode { get; set; }
        private bool _readedQRCode { get; set; }

        public Player(List<Card> cards, int health, int armor, int attack, int cardsLeft, int manaCristals)
        {
            this.cards = cards;
            this.health = health;
            this.armor = armor;
            this.attack = attack;
            this._cardsLeft = cardsLeft;
            this._manaCristals = manaCristals;
            this._vaitingForQRCode = false;
            this._readedQRCode = false;
        }

        public bool putCard(Card card)
        {
            for (int i = 0; i < this.cards.Count; ++i)
            {
                if (this.cards[i].getName() == card.getName()) return false;
            }
           
            this.cards.Add(card);
            return true;
        }

        public int cardsLeft { get { return _cardsLeft; } set { this._cardsLeft = value; } }
        public int health { get { return _health; } set { this._health = value; } }
        public int manaCristals { get { return _manaCristals; } set { this._manaCristals = value; } }
        public bool useMana(int value)
        {
            if(_manaCristals - value < 0) return false;
            else
            {
                _manaCristals -= value;
                return true;
            }
        }
        public bool vaitingForQRCode { get { return _vaitingForQRCode; } set { this._vaitingForQRCode = value; } }
        public bool readedQRCode { get { return _readedQRCode; } set { this._readedQRCode = value; } }
    }
}
