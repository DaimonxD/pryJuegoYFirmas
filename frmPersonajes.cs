using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryJuegoYFirmas
{
    public partial class frmPersonajes : Form
    {

        public string PersonajeSeleccionado { get; private set; }

        public frmPersonajes()
        {
            InitializeComponent();
            InitializeBackground();
            SetupTimer();
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

        private void cmd2_Click_1(object sender, EventArgs e)
        {
            PersonajeSeleccionado = "Plr1";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmd1_Click_1(object sender, EventArgs e)
        {
            PersonajeSeleccionado = "Plr2";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
