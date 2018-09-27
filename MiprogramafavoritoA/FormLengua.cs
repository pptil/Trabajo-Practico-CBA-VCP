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

namespace VCPApp
{
    public partial class FormLengua : Form
    {
        WindowsMediaPlayer wmp = new WindowsMediaPlayer();
        
        
       
        public FormLengua()
        {
            InitializeComponent();
            

        }

        private void FormLengua_Load(object sender, EventArgs e)
        {
           media.uiMode = "none";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
                media.Ctlcontrols.pause();
                
            
            
            


        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            media.Visible = true;
            btnFullscreen.Visible = true;
            btnContinue.Visible = true;
            btnRestart.Visible = true;
            btnPlay.Hide();
            btnStop.Visible = true;
            media.URL = @"Cigarra y la hormiga.avi";
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            
            
                media.Ctlcontrols.play();
               
            

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            media.Ctlcontrols.stop();
            media.Ctlcontrols.play();
        }

        private void btnFullscreen_Click(object sender, EventArgs e)
        {
            media.fullScreen = true;
           
        }

        private void FormLengua_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            media.Ctlcontrols.stop();
            
        }

        private void FormLengua_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
