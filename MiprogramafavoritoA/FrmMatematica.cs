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
    public partial class FrmMatematica : Form
    {       
        int puntaje = 1, contador_imagen;
        bool enable = true;
        public FrmMatematica()
        {
            InitializeComponent();           
            contador_imagen = 1;
        }
        //Metodos del Formulario
        private void FrmMatematica_Load(object sender, EventArgs e)
        {
            Juego();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            btnNext.Visible = false;
            enable = true;
            contador_imagen++;
            Juego();
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (enable==true)
            {
                if (contador_imagen == 1)
                {
                    Ganar();
                }
                else
                {
                    Perder();
                }
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (enable == true)
            {
                if (contador_imagen == 4)
                {
                    Ganar();
                }
                else
                {
                    Perder();
                }
            }
           
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (enable == true)
            {
                if (contador_imagen == 3)
                {
                    Ganar();
                }
                else
                {
                    Perder();
                }
            }
          
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (enable == true)
            {
                if (contador_imagen == 5)
                {
                    Ganar();
                }
                else
                {
                    Perder();
                }
            }
            
        }    
        private void button5_Click(object sender, EventArgs e)
        {
            if (enable == true)
            {
                if (contador_imagen == 2)
                {
                    Ganar();
                }
                else
                {
                    Perder();
                }
            }
           
        }
        //Metodos Propios
        public void Juego()
        {
            switch (contador_imagen)
            {
                case 1:
                    pictureBox1.ImageLocation = @"pelota1.jpg";
                    break;
                case 2:
                    pictureBox1.ImageLocation = @"pelota5.jpg";
                    break;
                case 3:
                    pictureBox1.ImageLocation = @"pelota3.jpg";
                    break;
                case 4:
                    pictureBox1.ImageLocation = @"pelota2.jpg";
                    break;
                case 5:
                    pictureBox1.ImageLocation = @"pelota4.jpg";
                    break;
                default:
                    label1.Text = "Su puntaje ha sido: " + puntaje;
                    pictureBox1.Visible = false;
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    break;
            }

        }
        private void Ganar()
        {
            label1.Text = "MUY BIEN! Acertaste";
            btnNext.Visible = true;
            label1.Visible = true;

            enable = false;
            label1.ForeColor = Color.Green;
            puntaje++;
        }
        private void Perder()
        {
            label1.Text = "QUE LASTIMA! Fallaste";
            label1.ForeColor = Color.Red;
            label1.Visible = true;
            btnNext.Visible = true;
            enable = false;

        }
    }
}
