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
    internal class clsNave
    {
        public string nombre;
        public PictureBox imgJugador;
        private string modeloActual;

        private static readonly Bitmap imgJugador1 = Properties.Resources.naveAnashe;
        private static readonly Bitmap imgJugador2 = Properties.Resources.naveAnashe2;
        private static readonly Bitmap imgProyectil = RotateImage(Properties.Resources.sticks);
        private static readonly Bitmap imgProyectil2 = RotateImage(Properties.Resources.knife2);

        public clsNave()
        {
            imgJugador = new PictureBox
            {
                Size = new Size(50, 50),
                BackColor = Color.Black,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
        }
        public void crearJugador(string modelo)
        {
            modeloActual = modelo;
            switch (modelo)
            {
                case "Plr1":
                    ConfigurarJugador("plr1", imgJugador1);
                    break;
                case "Plr2":
                    ConfigurarJugador("plr2", imgJugador2);
                    break;
            }
        }

        private void ConfigurarJugador(string name, Bitmap image)
        {
            nombre = name;
            imgJugador.Image = image;
        }

        public PictureBox crearProyectil()
        {
            PictureBox proyectil = new PictureBox
            {
                Image = imgProyectil,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(40, 70),
                BackColor = Color.Black,
                Location = new Point()
            };

            switch (modeloActual)
            {
                case "Plr1":
                    proyectil.Image = imgProyectil;
                    break;
                case "Plr2":
                    proyectil.Image = imgProyectil2;
                    break;
            }

            return proyectil;
        }

        private static Bitmap RotateImage(Bitmap originalImage)
        {
            Bitmap rotatedImage = new Bitmap(originalImage);
            rotatedImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
            return rotatedImage;
        }
    }
}