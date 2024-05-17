using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryJuegoYFirmas
{
    internal class clsEnemigo
    {
        public PictureBox imgEnemigo { get; private set; }
        public int hp;
        public string nombre;
        public int VelocidadY { get; set; } = 5;
        public PictureBox Advertencia { get; private set; }

        private static readonly Bitmap imgEnemigo1 = Properties.Resources.enemigo1;

        public clsEnemigo()
        {
            imgEnemigo = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Black,
                Size = new Size(50, 50)
            };

            ConfigurarEnemigo(100, "enemigo1", imgEnemigo1);
        }

        private void ConfigurarEnemigo(int health, string name, Bitmap image)
        {
            hp = health;
            nombre = name;
            imgEnemigo.Image = image;
        }
    }
}
