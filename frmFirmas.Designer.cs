namespace pryJuegoYFirmas
{
    partial class frmFirmas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.picBoxFirma = new System.Windows.Forms.PictureBox();
            this.btnV = new System.Windows.Forms.Button();
            this.rNegro = new System.Windows.Forms.RadioButton();
            this.rAzul = new System.Windows.Forms.RadioButton();
            this.rRojo = new System.Windows.Forms.RadioButton();
            this.rAmarillo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFirma)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(673, 406);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 32);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picBoxFirma
            // 
            this.picBoxFirma.BackColor = System.Drawing.Color.AliceBlue;
            this.picBoxFirma.Location = new System.Drawing.Point(13, 12);
            this.picBoxFirma.Name = "picBoxFirma";
            this.picBoxFirma.Size = new System.Drawing.Size(775, 387);
            this.picBoxFirma.TabIndex = 0;
            this.picBoxFirma.TabStop = false;
            this.picBoxFirma.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBoxFirma_MouseMove);
            // 
            // btnV
            // 
            this.btnV.Location = new System.Drawing.Point(13, 406);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(98, 32);
            this.btnV.TabIndex = 2;
            this.btnV.Text = "&Volver";
            this.btnV.UseVisualStyleBackColor = true;
            this.btnV.Click += new System.EventHandler(this.btnV_Click);
            // 
            // rNegro
            // 
            this.rNegro.AutoSize = true;
            this.rNegro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rNegro.Location = new System.Drawing.Point(184, 414);
            this.rNegro.Name = "rNegro";
            this.rNegro.Size = new System.Drawing.Size(54, 17);
            this.rNegro.TabIndex = 3;
            this.rNegro.TabStop = true;
            this.rNegro.Text = "Negro";
            this.rNegro.UseVisualStyleBackColor = true;
            // 
            // rAzul
            // 
            this.rAzul.AutoSize = true;
            this.rAzul.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rAzul.Location = new System.Drawing.Point(316, 414);
            this.rAzul.Name = "rAzul";
            this.rAzul.Size = new System.Drawing.Size(45, 17);
            this.rAzul.TabIndex = 4;
            this.rAzul.TabStop = true;
            this.rAzul.Text = "Azul";
            this.rAzul.UseVisualStyleBackColor = true;
            // 
            // rRojo
            // 
            this.rRojo.AutoSize = true;
            this.rRojo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rRojo.Location = new System.Drawing.Point(459, 414);
            this.rRojo.Name = "rRojo";
            this.rRojo.Size = new System.Drawing.Size(47, 17);
            this.rRojo.TabIndex = 5;
            this.rRojo.TabStop = true;
            this.rRojo.Text = "Rojo";
            this.rRojo.UseVisualStyleBackColor = true;
            // 
            // rAmarillo
            // 
            this.rAmarillo.AutoSize = true;
            this.rAmarillo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rAmarillo.Location = new System.Drawing.Point(582, 414);
            this.rAmarillo.Name = "rAmarillo";
            this.rAmarillo.Size = new System.Drawing.Size(61, 17);
            this.rAmarillo.TabIndex = 6;
            this.rAmarillo.TabStop = true;
            this.rAmarillo.Text = "Amarillo";
            this.rAmarillo.UseVisualStyleBackColor = true;
            // 
            // frmFirmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::pryJuegoYFirmas.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rAmarillo);
            this.Controls.Add(this.rRojo);
            this.Controls.Add(this.rAzul);
            this.Controls.Add(this.rNegro);
            this.Controls.Add(this.btnV);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.picBoxFirma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFirmas";
            this.Text = "Firmas";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFirma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxFirma;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.RadioButton rNegro;
        private System.Windows.Forms.RadioButton rAzul;
        private System.Windows.Forms.RadioButton rRojo;
        private System.Windows.Forms.RadioButton rAmarillo;
    }
}