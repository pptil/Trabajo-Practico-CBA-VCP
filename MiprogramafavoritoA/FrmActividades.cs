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
    
    public partial class FrmActividades : Form
    {
        WindowsMediaPlayer media = new WindowsMediaPlayer();
        WindowsMediaPlayer media2 = new WindowsMediaPlayer();
        //Variables 
        bool correct = false;
        Int32 contador_actividades = 1, puntuacion;
        bool enable = true;
        public FrmActividades()
        {
            
            InitializeComponent();
            puntuacion = 0;
            
        }
        private void FrmActividades_Load(object sender, EventArgs e)
        {
           
            Preguntas();            
        }
        //Metodos del Formulario
        private void button1_Click(object sender, EventArgs e)
        {
            if (enable == true)
            {
                if (contador_actividades == 1)
                {
                    button1.BackColor = Color.Green;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Red;
                    button4.BackColor = Color.Red;
                    puntuacion++;
                    correct = true;
                    Reset();
                    media2.URL = @"win.mp3";
                    media2.controls.play();
                    media.URL = @"correcto.mp3";
                    media.controls.play();
                }
                else
                {
                    button1.BackColor = Color.Red;
                    correct = false;
                    media2.URL = @"lose.mp3";
                    media2.controls.play();
                    media.URL = @"incorrecto.mp3";
                    media.controls.play();

                    Reset();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (enable == true)
            {
                button2.BackColor = Color.Red;
                Texto();
                correct = false;
                media2.URL = @"lose.mp3";
                media2.controls.play();
                media.URL = @"incorrecto.mp3";
                media.controls.play();
                Reset();

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (enable == true)
            {
                if (contador_actividades == 2)
                {
                    button3.BackColor = Color.Green;
                    puntuacion++;
                    correct = true;
                    media2.URL = @"win.mp3";
                    media2.controls.play();
                    media.URL = @"correcto.mp3";
                    media.controls.play();
                    Reset();
                    
                }
                else
                {
                    button3.BackColor = Color.Red;
                    correct = false;
                    media2.URL = @"lose.mp3";
                    media2.controls.play();
                    media.URL = @"incorrecto.mp3";
                    media.controls.play();
                    Reset();
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (enable == true)
            {
                button4.BackColor = Color.Red;
                correct = false;
                media2.URL = @"lose.mp3";
                media2.controls.play();
                media.URL = @"incorrecto.mp3";
                media.controls.play();
                Reset();
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gray;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
            button4.BackColor = Color.Gray;
            contador_actividades++;
            enable = true;
            Preguntas();
            Vis();
        }

        //Metodos Propios
        public void Preguntas()
        {
            switch (contador_actividades)
            {
                case 1:
                    label2.Text = "¿Qué animal era el Holgazan?";
                    pictureBox1.ImageLocation = @"cigarra.jpeg";
                    pictureBox2.ImageLocation = @"conejo.jpg";
                    pictureBox3.ImageLocation = @"mariposa.png";
                    pictureBox4.ImageLocation = @"tortuga.png";
                    button1.Text = "Cigarra";
                    button2.Text = "Conejo";
                    button3.Text = "Tortuga";
                    button4.Text = "Mariposa";
                    media.URL = "holgazan.mp3";
                    media.controls.play();
                    media2.URL = @"8bitrocknroll.mp3";
                    media2.controls.play();
                    break;
                case 2:
                    label2.Text = "¿Donde pasa la historia?";
                    pictureBox1.ImageLocation = @"ciudad.png";
                    pictureBox2.ImageLocation = @"montañas.png";
                    pictureBox3.ImageLocation = @"playa.png";
                    pictureBox4.ImageLocation = @"bosque.png";
                    button1.Text = "Ciudad";
                    button2.Text = "Montaña";
                    button3.Text = "Bosque";
                    button4.Text = "Playa";
                    media.URL = "historia.mp3";
                    media.controls.play();
                    media2.URL = @"8bitrocknroll.mp3";
                    media2.controls.play();
                    break;
                default:
                    lblPuntuacion.Text = "TU PUNTUACION HA SIDO: " + puntuacion;
                    Clear_actividades();
                    break;
                    
                    
            }


        }
        private void Clear_actividades()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            label2.Visible = false;
        }
        private void Vis()
        {
            label1.Visible = false;
            btnNext.Visible = false;
        }
        public void Reset()
        {
            btnNext.Visible = true;
            Texto();
            enable = false;
            label1.Visible = true;
        }

        private void FrmActividades_FormClosing(object sender, FormClosingEventArgs e)
        {
            media2.controls.stop();
        }

        public void Texto() { if (correct == true) { label1.Text = "C O R R E C T O!"; } else { label1.Text = "Q U E   L A S T I M A!"; } }
       
    }
}
