using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics.Eventing.Reader;

namespace pryJuegoYFirmas
{
    public partial class frmJueguito : Form
    {
        public frmJueguito(string personajeSeleccionado)
        {
            InitializeComponent();
            crearJugador(personajeSeleccionado);
            iniciarJuego();
            enTimer();
            Dash();

            Caos = new SoundPlayer(Properties.Resources.enemy_death);
            DashPlr = new SoundPlayer(Properties.Resources.player_dash);
            Caos2 = new SoundPlayer(Properties.Resources.player_death);
            MoveEn = new SoundPlayer(Properties.Resources.enemy_attack);

            this.DoubleBuffered = true;
        }

        clsNave objImg;
        List<PictureBox> proyectiles = new List<PictureBox>();
        List<clsEnemigo> enemigos = new List<clsEnemigo>();
        private List<PictureBox> proyectilesEnemigos = new List<PictureBox>();
        Random rnd = new Random();

        private DateTime disparo;
        private Timer gTimer;
        private Timer movEnemigo;
        private Timer cdDash;
        private Timer wrnTimer;
        //sonidos\\
        private SoundPlayer Caos;
        private SoundPlayer DashPlr;
        private SoundPlayer Caos2;
        private SoundPlayer MoveEn;

        bool activo = true;
        private bool puedeDisparar = false;
        bool dash = false;
        bool izq, der, piu;
        bool over = false;
        double cd = 0.5;
        int score;
        int velocidadJ;
        int velocidadB = 10;
        int distancia = 100;
        int enemigosPorRonda = 4;


        //----------------\\
        //Sistema del juego\\


        private void iniciarJuego()
        {
            gTimer = new Timer();
            gTimer.Interval = 20;
            gTimer.Tick += tempJuego;
            gTimer.Start();
        }
        private void frmJueguito_Load_1(object sender, EventArgs e)
        {
            HP.ForeColor = Color.Firebrick; //no funciona >:(
            STM.ForeColor = Color.MediumBlue; //aca tampoco
            resetGame();
        }

        private async void IniciarNuevaRonda()
        {
            movEnemigo.Stop();
            CrearEnemigos(enemigosPorRonda);

            puedeDisparar = false;

            await Task.Delay(2000);

            puedeDisparar = true;

            foreach (var enemigo in enemigos)
            {
                enemigo.imgEnemigo.Image = Properties.Resources.enemigo2;
            }

            movEnemigo.Start();
            MoveEn.Play();
            MoveEn.Dispose();
        }

        private void resetGame()
        {
            over = false;
            velocidadJ = 10;
            HP.Value = 100;
            STM.Value = 100;
            score = 0;
            lblScore.Text = "Score:" + Environment.NewLine + score;

            CrearEnemigos(4);
        }

        private void gameOver()
        {
            movEnemigo.Stop();
            gTimer.Stop();
            cdDash.Stop();

            foreach (var enemigo in enemigos)
            {
                Controls.Remove(enemigo.imgEnemigo);
                enemigo.imgEnemigo.Dispose();
            }

            activo = false;
            ShowGameOverScreen();
        }

        private void tempJuego(object sender, EventArgs e)
        {
            int x = 0;

            if (der) x += velocidadJ;
            if (izq) x -= velocidadJ;

            if (x != 0)
            {
                Moveplr(x);
            }

            actProyectil();
        }

        private void ShowGameOverScreen()
        {
            Panel gameOverPanel = new Panel
            {
                Size = new Size(884, 711),
                Location = new Point(0, 0),
                BackColor = Color.Black,
            };

            Label gameOverText = new Label
            {
                Text = "GAME OVER\nTu puntuación: " + score,
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 14, FontStyle.Bold)
            };

            gameOverPanel.Controls.Add(gameOverText);
            Controls.Add(gameOverPanel);
            gameOverPanel.BringToFront();

        }

        //------------------\\
        //Sistema de enemigos\\


        private async Task enTimer()
        {
            puedeDisparar = false;

            await Task.Delay(2000);

            foreach(var enemigo in enemigos)
            {
                enemigo.imgEnemigo.Image = Properties.Resources.enemigo2;
            }

            puedeDisparar = true;
            movEnemigo = new Timer();
            movEnemigo.Interval = 100;
            movEnemigo.Tick += (sender, e) => MoverEnemigos();

            movEnemigo.Start();
            MoveEn.Play();
            MoveEn.Dispose();
        }

        private void MoverEnemigos()
        {
            List<clsEnemigo> enemigosParaRemover = new List<clsEnemigo>();

            foreach (clsEnemigo enemigo in enemigos)
            {
                if (enemigo.imgEnemigo.Top < 580)
                {
                    enemigo.imgEnemigo.Top += enemigo.VelocidadY;
                }
                else if (enemigo.imgEnemigo.Top >= 580)
                {
                    enemigosParaRemover.Add(enemigo);
                    Vida(-100);
                }
                
            }

            foreach (PictureBox proyectil in proyectilesEnemigos.ToList())
            {
                if (proyectil.Bounds.IntersectsWith(this.ClientRectangle))
                {
                    proyectil.Parent.Controls.Remove(proyectil);
                    proyectil.Dispose();
                    proyectilesEnemigos.Remove(proyectil);

                    if (proyectil.Tag is Timer dañoJugadorTimer)
                    {
                        dañoJugadorTimer.Stop();
                    }
                }
            }

            foreach (clsEnemigo enemigo in enemigosParaRemover)
            {
                Controls.Remove(enemigo.imgEnemigo);
                enemigos.Remove(enemigo);
            }

            if (enemigos.Count == 0)
            {
                IniciarNuevaRonda();
                enTimer();
            }

            this.Invalidate();

        }

        private void CrearEnemigos(int cantidad)
        {
            if (over) return;

            int[] eX1 = { 20, 220, 420, 620, 820 };
            int[] eX2 = { 120, 320, 520, 720 };
            int Y = 20;

            bool useEX1 = rnd.Next(2) == 0;
            int[] selectedArray = useEX1 ? eX1 : eX2;

            int numEnemigos = useEX1 ? 5 : 4;

            HashSet<int> Usada = new HashSet<int>();

            for (int i = 0; i < numEnemigos; i++)
            {
                int xPos;
                do
                {
                    xPos = selectedArray[rnd.Next(selectedArray.Length)];
                } while (Usada.Contains(xPos));

                Usada.Add(xPos);

                clsEnemigo enemigo = new clsEnemigo();
                enemigo.imgEnemigo.Location = new Point(xPos, Y);

                Controls.Add(enemigo.imgEnemigo);
                enemigos.Add(enemigo);

                foreach (clsEnemigo Enemigo in enemigos)
                {
                    Enemigo.VelocidadY = 5;
                }
            }
        }

        private void actProyectil()
        {
            List<PictureBox> removerBalas = new List<PictureBox>();
            foreach (PictureBox bala in proyectiles)
            {
                bala.Location = new Point(bala.Location.X, bala.Location.Y - velocidadB);
                if (bala.Location.Y < 0)
                {
                    removerBalas.Add(bala);
                }
                else
                {
                    List<clsEnemigo> enemigosEliminados = new List<clsEnemigo>();
                    foreach (var enemigo in enemigos)
                    {
                        if (bala.Bounds.IntersectsWith(enemigo.imgEnemigo.Bounds))
                        {
                            Controls.Remove(enemigo.imgEnemigo);
                            enemigo.imgEnemigo.Dispose();
                            enemigosEliminados.Add(enemigo);
                            removerBalas.Add(bala);
                            Caos.Play();
                            score++;
                            lblScore.Text = "Score:" + Environment.NewLine + score;
                            break;
                        }
                    }
                    foreach (clsEnemigo enemigo in enemigosEliminados)
                    {
                        enemigos.Remove(enemigo);
                    }
                    if (enemigos.Count == 0)
                    {
                        movEnemigo.Stop();
                        IniciarNuevaRonda();
                    }
                }
            }

            foreach (PictureBox bala in removerBalas)
            {
                Controls.Remove(bala);
                proyectiles.Remove(bala);
                bala.Dispose();
            }
        }


        //------------------\\
        //Sistema del jugador\\


        private void Moveplr(int dx)
        {
            Point Cord = objImg.imgJugador.Location;

            int nX = Cord.X + dx;

            int minX = 0;
            int maxX = this.ClientSize.Width - objImg.imgJugador.Width;

            nX = Math.Max(minX, Math.Min(nX, maxX));

            objImg.imgJugador.Location = new Point(nX, 580);

        }

        private void Vida(int change)
        {
            HP.Value = Math.Max(0, Math.Min(HP.Value + change, HP.Maximum));

            double percentage = (double)HP.Value / HP.Maximum * 100;
            if (percentage == 100)
                HP.BackColor = Color.Green;
            else if (percentage >= 75)
                HP.BackColor = Color.LightGreen;
            else if (percentage >= 50)
                HP.BackColor = Color.Yellow;
            else if (percentage >= 25)
                HP.BackColor = Color.Orange;
            else
                HP.BackColor = Color.Red;

            if (HP.Value == 0)
            {
                Caos2.Play();
                Caos2.Dispose();
                gameOver();
            }
        }

        private void frmJueguito_KeyDown_1(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.ShiftKey && !dash && STM.Value == 100)
            {
                int dx = 0;
                if (der) dx = distancia;
                else if (izq) dx = -distancia;

                Moveplr(dx);
                dash = true;
                STM.Value = 0;
                cdDash.Start();
                DashPlr.Play();
            }

            if (over && e.KeyCode == Keys.Enter)
            {
                this.Close();
                new frmMenu().Show();
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
                new frmMenu().Show();
                return;

            }

            switch (e.KeyCode)
            {
                case Keys.D:
                    der = true;
                    break;
                case Keys.A:
                    izq = true;
                    break;
                case Keys.Space:
                    piu = true;
                    disparar();
                    break;
            }
        }

        private void frmJueguito_KeyUp_1(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D:
                    der = false;
                    break;
                case Keys.A:
                    izq = false;
                    break;
                case Keys.Space:
                    piu = false;
                    break;
            }
        }

        private void disparar()
        {
            if (puedeDisparar && (DateTime.Now - disparo).TotalSeconds >= cd)
            {
                if (piu)
                {
                    if (activo)
                    {
                        PictureBox bala = objImg.crearProyectil();
                        bala.Location = new Point(objImg.imgJugador.Location.X + objImg.imgJugador.Width / 2 - bala.Width / 2,
                                                objImg.imgJugador.Location.Y - bala.Height);
                        Controls.Add(bala);
                        bala.BringToFront();
                        proyectiles.Add(bala);
                        disparo = DateTime.Now;
                    }
                }
            }
        }


        private void crearJugador(string personajeSeleccionado)
        {
            objImg = new clsNave();
            objImg.crearJugador(personajeSeleccionado);
            objImg.imgJugador.Location = new Point(400, 580);
            Controls.Add(objImg.imgJugador);
            Controls.SetChildIndex(objImg.imgJugador, 1);
        }

        private void Dash()
        {
            cdDash = new Timer();
            cdDash.Interval = 500;
            cdDash.Tick += (sender, e) =>
            {
                if (STM.Value < 100)
                {
                    STM.Value += 20;
                    if (STM.Value >= 100)
                    {
                        STM.Value = 100;
                        cdDash.Stop();
                        dash = false;
                    }
                }
            };
        }

    }
}
