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
        private int manaCristals;
        private int manaCristalsCopy;

        public Player(List<Card> cards, int health, int armor, int attack, int cardsLeft, int manaCristals)
        {
            this.cards = cards;
            this.health = health;
            this.armor = armor;
            this.attack = attack;
            this.cardsLeft = cardsLeft;
            this.manaCristals = manaCristals;
            this.manaCristalsCopy = manaCristals;
        }

        public Card getCardOnTable(int onTableId)
        {
            for (int i = 0; i < this.cards.Count; ++i)
            {
                if (this.cards[i].getOnTableId() == onTableId) return cards[i];
            }

            return null;
        }

        public void removeCard(Card card)
        {
            for (int i = 0; i < this.cards.Count; ++i)
            {
                if (this.cards[i].getId() == card.getId()) cards.RemoveAt(i);
            }
        }

        public bool isCardOnList(Card card)
        {
            for (int i = 0; i < this.cards.Count; ++i)
            {
                if (this.cards[i].getId() == card.getId()) return true;
            }

            return false;
        }

        public bool putCard(Card card)
        {
            if (cards.Count < 7)
            {
                this.cards.Add(card);
                return true;
            }

            return false;
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

        public int getManaCristals()
        {
            return manaCristals;
        }

        public bool useMana(int value)
        {
            if(manaCristals - value < 0) return false;
            else
            {
                manaCristals -= value;
                return true;
            }
        }

        public void addCristal(int a = 0)
        {
            if (a > 0)
            {
                manaCristals = ++manaCristalsCopy + a;
            }
            else
            {
                if (manaCristalsCopy < 10)
                {
                    manaCristals = ++manaCristalsCopy;
                }
                else
                {
                    manaCristals = manaCristalsCopy;
                }
            }
        }
    }
}
