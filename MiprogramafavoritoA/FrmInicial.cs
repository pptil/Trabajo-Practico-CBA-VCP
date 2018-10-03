using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MiprogramafavoritoA
{
    public partial class FrmInicial : Form
    {
        
        WindowsMediaPlayer media = new WindowsMediaPlayer();
        public FrmInicial()
        {
            InitializeComponent();
            media.URL = @"8bitsong.mp3";
            media.controls.play();
            media.settings.setMode("loop", true);

        }

        private void btnLengua_Click(object sender, EventArgs e)
        {
            btnActiv.Visible = true;
            btnPlay.Visible = true;
            mediaplayer.Visible = false;
            mediaplayer.Ctlcontrols.stop();
            media.controls.stop();
        }

        private void btnNaturales_Click(object sender, EventArgs e)
        {
            media.controls.stop();
            FormJuego frmnaturales = new FormJuego();
            frmnaturales.ShowDialog();
            mediaplayer.Ctlcontrols.stop();
            btnActiv.Visible = false;
            btnPlay.Visible = false;
            mediaplayer.Visible = false;
            

            

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPlay_Click_1(object sender, EventArgs e)
        {
            mediaplayer.URL = @"Cigarra y hormiga.mp4";
            mediaplayer.Visible = true;
            btnActiv.Visible = false;
            btnPlay.Visible = false;
            media.controls.stop();

        }

        private void btnActiv_Click(object sender, EventArgs e)
        {
            FrmActividades frmactiv = new FrmActividades();
            frmactiv.ShowDialog();
            media.controls.stop();
        }

        private void btnMatematica_Click(object sender, EventArgs e)
        {
            mediaplayer.Ctlcontrols.stop();
            media.controls.stop();
            btnActiv.Visible = false;
            btnPlay.Visible = false;
            mediaplayer.Visible = false;
            FrmMatematica frmate = new FrmMatematica();
            frmate.ShowDialog();
            media.controls.stop();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            media.controls.stop();
            this.Hide();
            FrmMenu menu = new FrmMenu();
            menu.ShowDialog();           
            this.Close();
        }

        private void btnSociales_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VERSION BETA: CIENCIAS SOCIALES EN PROGRESO", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
