using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace pryJuegoYFirmas
{
    public partial class frmFirmas : Form
    {
        private Bitmap imagen;
        public frmFirmas()
        {
            InitializeComponent();
            rNegro.Checked = true;
            imagen = new Bitmap(picBoxFirma.Width, picBoxFirma.Height);
        }

        private void picBoxFirma_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                switch (true)
                {
                    case var _ when rNegro.Checked:
                        using (Graphics objetoLoco = Graphics.FromImage(imagen))
                        {
                            objetoLoco.FillEllipse(Brushes.Black, e.X, e.Y, 5, 5);
                        }
                    break;

                    case var _ when rRojo.Checked:
                        using (Graphics objetoLoco = Graphics.FromImage(imagen))
                        {
                            objetoLoco.FillEllipse(Brushes.Red, e.X, e.Y, 5, 5);
                        }
                    break;
                    
                    case var _ when rAmarillo.Checked:
                        using (Graphics objetoLoco = Graphics.FromImage(imagen))
                        {
                            objetoLoco.FillEllipse(Brushes.Yellow, e.X, e.Y, 5, 5);
                        }
                    break;

                    case var _ when rAzul.Checked:
                        using (Graphics objetoLoco = Graphics.FromImage(imagen))
                        {
                            objetoLoco.FillEllipse(Brushes.Blue, e.X, e.Y, 5, 5);
                        }
                    break;
                }


                picBoxFirma.Image = imagen;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog guardar = new SaveFileDialog())
            {
                guardar.Title = "Guardar firma";

                guardar.Filter = "Archivos de imagen (*.png)|*.png|Todos los archivos (*.*)|*.*";

                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    string ubicacion = guardar.FileName;

                    try
                    {
                        imagen.Save(ubicacion);
                        MessageBox.Show("Nashe");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nashen't" + ex.Message);
                    }
                }
            }
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            frmMenu m = new frmMenu();
            this.Hide();
            m.Show();
        }
    }
}
