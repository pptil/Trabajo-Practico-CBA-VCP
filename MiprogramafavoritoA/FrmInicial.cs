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
        
        
        public FrmInicial()
        {
            InitializeComponent();
            this.Location = Screen.PrimaryScreen.WorkingArea.Location; this.Size = Screen.PrimaryScreen.WorkingArea.Size;

        }

        private void btnLengua_Click(object sender, EventArgs e)
        {
            btnActiv.Visible = true;
            btnPlay.Visible = true;
            mediaplayer.Visible = false;
            mediaplayer.Ctlcontrols.stop();
        }

        private void btnNaturales_Click(object sender, EventArgs e)
        {
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
            
        }

        private void btnActiv_Click(object sender, EventArgs e)
        {
            FrmActividades frmactiv = new FrmActividades();
            frmactiv.ShowDialog();

        }

        private void btnMatematica_Click(object sender, EventArgs e)
        {
            mediaplayer.Ctlcontrols.stop();
            btnActiv.Visible = false;
            btnPlay.Visible = false;
            mediaplayer.Visible = false;
            FrmMatematica frmate = new FrmMatematica();
            frmate.ShowDialog();
        }
    }
}
