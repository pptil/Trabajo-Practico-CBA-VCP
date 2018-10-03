using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiprogramafavoritoA
{
    public partial class FrmCarga : Form
    {
        int timer = 0;
        string mje = "";
        public FrmCarga()
        {
            InitializeComponent();
        }
        private void Progreso()
        {

            timer++;
            mje = timer.ToString();
            LblCarga.Text = mje + "%";
            if (timer == 100)
            {
                TrCarga.Stop();
                this.Hide();// esconde la pantalla de carga
                FrmMenu M = new FrmMenu();
                M.ShowDialog();
                this.Close();


            }
          

         }
            private void FrmCarga_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void TrCarga_Tick(object sender, EventArgs e)
        {
            Progreso();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
