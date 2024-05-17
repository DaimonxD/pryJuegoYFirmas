namespace pryJuegoYFirmas
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.cmdCharacter = new System.Windows.Forms.Button();
            this.cmdFirmas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(51, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(646, 107);
            this.label1.TabIndex = 7;
            this.label1.Text = "UnderShooter";
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Location = new System.Drawing.Point(230, 461);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(291, 54);
            this.cmdCerrar.TabIndex = 6;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.UseVisualStyleBackColor = false;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // cmdCharacter
            // 
            this.cmdCharacter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdCharacter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCharacter.Location = new System.Drawing.Point(230, 276);
            this.cmdCharacter.Name = "cmdCharacter";
            this.cmdCharacter.Size = new System.Drawing.Size(291, 54);
            this.cmdCharacter.TabIndex = 5;
            this.cmdCharacter.Text = "Jugar";
            this.cmdCharacter.UseVisualStyleBackColor = false;
            this.cmdCharacter.Click += new System.EventHandler(this.cmdCharacter_Click_1);
            // 
            // cmdFirmas
            // 
            this.cmdFirmas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdFirmas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdFirmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFirmas.Location = new System.Drawing.Point(230, 368);
            this.cmdFirmas.Name = "cmdFirmas";
            this.cmdFirmas.Size = new System.Drawing.Size(291, 54);
            this.cmdFirmas.TabIndex = 8;
            this.cmdFirmas.Text = "Firmas";
            this.cmdFirmas.UseVisualStyleBackColor = false;
            this.cmdFirmas.Click += new System.EventHandler(this.cmdFirmas_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryJuegoYFirmas.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(748, 542);
            this.Controls.Add(this.cmdFirmas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdCharacter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdCerrar;
        private System.Windows.Forms.Button cmdCharacter;
        private System.Windows.Forms.Button cmdFirmas;
    }
}