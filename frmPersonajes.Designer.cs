﻿namespace pryJuegoYFirmas
{
    partial class frmPersonajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonajes));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmd2 = new System.Windows.Forms.Button();
            this.cmd1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(424, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 108);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ñrisk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(63, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 108);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ñara";
            // 
            // cmd2
            // 
            this.cmd2.BackColor = System.Drawing.Color.Transparent;
            this.cmd2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmd2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd2.Image = global::pryJuegoYFirmas.Properties.Resources.naveAnashe;
            this.cmd2.Location = new System.Drawing.Point(453, 179);
            this.cmd2.Name = "cmd2";
            this.cmd2.Size = new System.Drawing.Size(205, 149);
            this.cmd2.TabIndex = 7;
            this.cmd2.UseVisualStyleBackColor = false;
            this.cmd2.Click += new System.EventHandler(this.cmd2_Click_1);
            // 
            // cmd1
            // 
            this.cmd1.BackColor = System.Drawing.Color.Transparent;
            this.cmd1.BackgroundImage = global::pryJuegoYFirmas.Properties.Resources.naveAnashe2;
            this.cmd1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd1.Location = new System.Drawing.Point(81, 179);
            this.cmd1.Name = "cmd1";
            this.cmd1.Size = new System.Drawing.Size(205, 149);
            this.cmd1.TabIndex = 6;
            this.cmd1.UseVisualStyleBackColor = false;
            this.cmd1.Click += new System.EventHandler(this.cmd1_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(696, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmPersonajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryJuegoYFirmas.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(748, 542);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmd2);
            this.Controls.Add(this.cmd1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPersonajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPersonajes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmd2;
        private System.Windows.Forms.Button cmd1;
        private System.Windows.Forms.Button button1;
    }
}