using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraCardGame
{
    class Game
    {
        private Player _player1;
        private Player _player2;
        private int _round;
        private int _turn;
        private float _turnTimer;
        private float _tempTurnTimer;

        public Game(Player player1, Player player2, int round, int turn, int turnTimer)
        {
            this._player1 = player1;
            this._player2 = player2;
            this._round = round;
            this._turn = turn;
            this._turnTimer = turnTimer;
            this._tempTurnTimer = this._turnTimer;
        }

        public void fight(Card atkCard, Card defCard) 
        {
            defCard.takeHealth(atkCard.getAttack());
            atkCard.takeHealth(defCard.getAttack());
        }

        public Player player1 {
            get
            {
                return _player1;
            }
            set
            {
                this._player1 = value;
            }
        }

        public Player player2
        {
            get
            {
                return _player2;
            }
            set
            {
                this._player2 = value;
            }
        }

        public int round
        {
            get
            {
                return _round;
            }
            set
            {
                this._round = value;
            }
        }

        public int turn
        {
            get
            {
                return _turn;
            }
            set
            {
                this._turn = value;
            }
        }

        public void nextRound()
        {
            this._round++;
        }

        public float turnTimer
        {
            get
            {
                return _turnTimer;
            }
            set
            {
                this._turnTimer = value;
            }
        }

        public void decreaseTurnTimer(float value = 1000)
        {
            this._turnTimer -= value/1000;

            if (this._turnTimer < 0)
            {
                this._turnTimer = 0;
            }
        }

        public void resetTurnTimer()
        {
            this._turnTimer = this._tempTurnTimer;
        }

        public void changeTurn()
        {
            if (this._turn == 1) this._turn = 2;
            else this._turn = 1;
        }
    }
}
