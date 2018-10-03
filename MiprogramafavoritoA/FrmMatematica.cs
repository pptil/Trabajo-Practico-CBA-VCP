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
    public partial class FrmMatematica : Form
    {
        WindowsMediaPlayer media = new WindowsMediaPlayer();
        WindowsMediaPlayer media2 = new WindowsMediaPlayer();
        int puntaje = 0, contador_imagen;
        bool enable = true;
        public FrmMatematica()
        {
            media.URL = @"seleccion.mp3";
            media.controls.play();
            media2.URL = @"8bitrocknroll.mp3";
            media2.controls.play();
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
            media2.URL = @"8bitrocknroll.mp3";
            media2.controls.play();

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

        private void button6_Click(object sender, EventArgs e)
        {
            if (enable ==true)
            {
                Perder();
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
                    int puntuacion_final = (puntaje * 100) / 5; 
                    
                    if (puntuacion_final < 50)
                    {
                        label1.Text = "Su puntaje ha sido: " + puntaje + "\r\n" +  "Mejor suerte la proxima!";                        
                        label1.ForeColor = Color.Red;

                    }
                    else
                    {
                        label1.Text = "Su puntaje ha sido: " + puntaje + "\r\n" + " Muy Bien!";
                        label1.ForeColor = Color.Green;
                    }
                    
                    pictureBox1.Visible = false;
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
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
            media.URL = @"correcto.mp3";
            media.controls.play();
            media2.URL = @"win.mp3";
            media2.controls.play();
        }

        private void FrmMatematica_FormClosing(object sender, FormClosingEventArgs e)
        {
            media2.controls.stop();
        }

        
        private void Perder()
        {
            label1.Text = "QUE LASTIMA! Fallaste";
            label1.ForeColor = Color.Red;
            label1.Visible = true;
            btnNext.Visible = true;
            enable = false;
            media.URL = @"incorrecto.mp3";
            media.controls.play();
            media2.URL = @"lose.mp3";
            media2.controls.play();

        }
    }
}
