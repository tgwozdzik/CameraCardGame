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
        private int cardsLeft;
        private int _manaCristals { get; set; }

        public Player(List<Card> cards, int health, int armor, int attack, int cardsLeft, int manaCristals)
        {
            this.cards = cards;
            this.health = health;
            this.armor = armor;
            this.attack = attack;
            this.cardsLeft = cardsLeft;
            this._manaCristals = manaCristals;
        }

        public Card getCardOnTable(int onTableId)
        {
            for (int i = 0; i < this.cards.Count; ++i)
            {
                if (this.cards[i].getOnTableId() == onTableId) return cards[i];
            }

            return null;
        }

        public bool isCardOnList(Card card)
        {
            for (int i = 0; i < this.cards.Count; ++i)
            {
                if (this.cards[i].getId() == card.getId()) return true;
            }

            return false;
        }

        public void putCard(Card card)
        {
            this.cards.Add(card);
        }

        public int getCardsLeft()
        {
            return this.cardsLeft;
        }

        public void takeCard()
        {
            this.cardsLeft--;
        }

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
    }
}
