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
    public partial class FrmMenu : Form
    {
        WindowsMediaPlayer media = new WindowsMediaPlayer();

        public FrmMenu()
        {
            InitializeComponent();
            media.URL = @"game2.mp3";
            media.controls.play();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location; this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void BtnJardin_Click(object sender, EventArgs e)
        {
            media.controls.stop();
            FrmInicial frmini = new FrmInicial();
            this.Hide();
            frmini.ShowDialog();
            this.Close();

        }

        private void BtnPrimaria_Click(object sender, EventArgs e)
        {
            media.controls.stop();
            this.Hide();
            FrmJuego frm = new FrmJuego();
            frm.ShowDialog();
            this.Close();

        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            media.controls.stop();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            media.controls.stop();
        }
    }
}
