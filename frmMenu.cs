using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryJuegoYFirmas
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            InitializeBackground();
            SetupTimer();
            this.DoubleBuffered = true;
        }

        private PictureBox bcg;
        private Timer scroll;


        private void InitializeBackground()
        {
            bcg = new PictureBox
            {
                Image = Properties.Resources.background,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(this.ClientSize.Width, this.ClientSize.Height * 2),
                Location = new Point(0, -this.ClientSize.Height)
            };
            this.Controls.Add(bcg);
            this.Controls.SetChildIndex(bcg, 10);
        }

        private void SetupTimer()
        {
            scroll = new Timer();
            scroll.Interval = 20;
            scroll.Tick += ScrollTimer_Tick;
            scroll.Start();
        }

        private void ScrollTimer_Tick(object sender, EventArgs e)
        {
            int scrollSpeed = 5;

            bcg.Top += scrollSpeed;

            if (bcg.Top >= 0)
            {
                bcg.Top = -this.ClientSize.Height;
            }
        }

        private void IniciarJuego(string personajeSeleccionado)
        {
            frmJueguito juego = new frmJueguito(personajeSeleccionado);
            juego.Show();
            this.Hide();
        }

        private void cmdCharacter_Click_1(object sender, EventArgs e)
        {
            using (frmPersonajes seleccionPersonajes = new frmPersonajes())
            {
                if (seleccionPersonajes.ShowDialog() == DialogResult.OK)
                {
                    string personajeSeleccionado = seleccionPersonajes.PersonajeSeleccionado;
                    IniciarJuego(personajeSeleccionado);
                }
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdFirmas_Click(object sender, EventArgs e)
        {
            frmFirmas f = new frmFirmas();
            this.Hide();
            f.ShowDialog();
        }
    }
}
