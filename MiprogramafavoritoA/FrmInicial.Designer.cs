﻿namespace MiprogramafavoritoA
{
    partial class FrmInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicial));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActiv = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.mediaplayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnLengua = new System.Windows.Forms.Button();
            this.btnMatematica = new System.Windows.Forms.Button();
            this.btnNaturales = new System.Windows.Forms.Button();
            this.btnSociales = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.btnActiv);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.mediaplayer);
            this.panel1.Location = new System.Drawing.Point(179, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 456);
            this.panel1.TabIndex = 0;
            // 
            // btnActiv
            // 
            this.btnActiv.Location = new System.Drawing.Point(160, 225);
            this.btnActiv.Name = "btnActiv";
            this.btnActiv.Size = new System.Drawing.Size(254, 43);
            this.btnActiv.TabIndex = 5;
            this.btnActiv.Text = "ACTIVIDADES";
            this.btnActiv.UseVisualStyleBackColor = true;
            this.btnActiv.Visible = false;
            this.btnActiv.Click += new System.EventHandler(this.btnActiv_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(160, 95);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(254, 42);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "VER VIDEO";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Visible = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click_1);
            // 
            // mediaplayer
            // 
            this.mediaplayer.Enabled = true;
            this.mediaplayer.Location = new System.Drawing.Point(22, 14);
            this.mediaplayer.Name = "mediaplayer";
            this.mediaplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaplayer.OcxState")));
            this.mediaplayer.Size = new System.Drawing.Size(573, 422);
            this.mediaplayer.TabIndex = 3;
            this.mediaplayer.Visible = false;
            // 
            // btnLengua
            // 
            this.btnLengua.BackColor = System.Drawing.Color.YellowGreen;
            this.btnLengua.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLengua.Location = new System.Drawing.Point(1, 44);
            this.btnLengua.Name = "btnLengua";
            this.btnLengua.Size = new System.Drawing.Size(172, 60);
            this.btnLengua.TabIndex = 1;
            this.btnLengua.Text = "LENGUA Y LITERATURA";
            this.btnLengua.UseVisualStyleBackColor = false;
            this.btnLengua.Click += new System.EventHandler(this.btnLengua_Click);
            // 
            // btnMatematica
            // 
            this.btnMatematica.BackColor = System.Drawing.Color.YellowGreen;
            this.btnMatematica.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatematica.Location = new System.Drawing.Point(1, 143);
            this.btnMatematica.Name = "btnMatematica";
            this.btnMatematica.Size = new System.Drawing.Size(172, 60);
            this.btnMatematica.TabIndex = 2;
            this.btnMatematica.Text = "MATEMATICA";
            this.btnMatematica.UseVisualStyleBackColor = false;
            this.btnMatematica.Click += new System.EventHandler(this.btnMatematica_Click);
            // 
            // btnNaturales
            // 
            this.btnNaturales.BackColor = System.Drawing.Color.YellowGreen;
            this.btnNaturales.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNaturales.Location = new System.Drawing.Point(1, 240);
            this.btnNaturales.Name = "btnNaturales";
            this.btnNaturales.Size = new System.Drawing.Size(172, 60);
            this.btnNaturales.TabIndex = 3;
            this.btnNaturales.Text = "CIENCIAS NATURALES";
            this.btnNaturales.UseVisualStyleBackColor = false;
            this.btnNaturales.Click += new System.EventHandler(this.btnNaturales_Click);
            // 
            // btnSociales
            // 
            this.btnSociales.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSociales.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSociales.Location = new System.Drawing.Point(1, 337);
            this.btnSociales.Name = "btnSociales";
            this.btnSociales.Size = new System.Drawing.Size(172, 60);
            this.btnSociales.TabIndex = 4;
            this.btnSociales.Text = "CIENCIAS SOCIALES";
            this.btnSociales.UseVisualStyleBackColor = false;
            // 
            // FrmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSociales);
            this.Controls.Add(this.btnNaturales);
            this.Controls.Add(this.btnMatematica);
            this.Controls.Add(this.btnLengua);
            this.Controls.Add(this.panel1);
            this.Name = "FrmInicial";
            this.Text = "FrmInicial";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mediaplayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLengua;
        private System.Windows.Forms.Button btnMatematica;
        private System.Windows.Forms.Button btnNaturales;
        private System.Windows.Forms.Button btnSociales;
        private AxWMPLib.AxWindowsMediaPlayer mediaplayer;
        private System.Windows.Forms.Button btnActiv;
        private System.Windows.Forms.Button btnPlay;
    }
}