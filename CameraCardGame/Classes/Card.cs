using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraCardGame
{
    class Card
    {
        Image picture;

        private String name;
        private int id;
        private int health;
        private int attack;
        private int manaCristals;
        private bool isTaunt { get; set; }
        private int onTableId;
        private String cardType;

        public Card(int id, String name, String cardType, int health, int attack, int manaCristals, String isTaunt)
        {
            this.id = id;
            this.name = name;
            this.health = health;
            this.attack = attack;
            this.manaCristals = manaCristals;
            this.isTaunt = isTaunt == "true";
            this.cardType = cardType;
            this.onTableId = -1;

            this.picture = Image.FromFile("Assets/Cards/" + name + ".png");
        }

        public int getOnTableId()
        {
            return this.onTableId;
        }

        public void takeHealth(int value)
        {
            this.health -= value;
        }

        public void setOntableId(int onTableId)
        {
            this.onTableId = onTableId;
        }

        public String getCardType()
        {
            return this.cardType;
        }

        public int getManaCristals()
        {
            return this.manaCristals;
        }

        public void addManaCristal()
        {
            this.manaCristals++;
        }

        public void removeManaCristal()
        {
            this.manaCristals--;
        }

        public int getHealth()
        {
            return this.health;
        }

        public int getAttack()
        {
            return this.attack;
        }

        public int getId()
        {
            return this.id;
        }

        public String getName()
        {
            return this.name;
        }

        public Image getPicture()
        {
            return this.picture;
        }
    }
}
