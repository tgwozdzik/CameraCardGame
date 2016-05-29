using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
//var pictureBox = new PictureBox();
//pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
//pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
//pictureBox.Size = new Size(75, 110);
//pictureBox.Location = new Point(260, 60);

//pictureBox.MouseDown += new MouseEventHandler(PictureBoxMouseDown);
//pictureBox.MouseUp += new MouseEventHandler(PictureBoxMouseUp);
//pictureBox.MouseMove += new MouseEventHandler(PictureBoxMouseMove);

//this.Controls.Add(pictureBox);


namespace CameraCardGame
{
    class Card
    {
        Image picture;

        private String name;
        private int id;
        private int health { get; set; }
        private int attack { get; set; }
        private int _manaCristals { get; set; }
        private bool isTaunt { get; set; }

        public Card(int id, String name, int health, int attack, int manaCristals, String isTaunt)
        {
            this.id = id;
            this.name = name;
            this.health = health;
            this.attack = attack;
            this.manaCristals = manaCristals;
            this.isTaunt = isTaunt == "true";

            this.picture = Image.FromFile("Assets/Cards/" + name + ".png");
        }

        public int manaCristals { get { return _manaCristals; } set { this._manaCristals = value; } }

        public int getId()
        {
            return id;
        }

        public String getName()
        {
            return name;
        }

        public Image getPicture()
        {
            return picture;
        }
    }
}
