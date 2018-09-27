using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VCPApp
{
    public partial class FormActividades : Form
    {
        bool correct = false;
        Int32 contador_actividades = 1;
        bool enable = true;
        public FormActividades()
        {
            InitializeComponent();
        }

        private void FormActividades_Load(object sender, EventArgs e)
        {
            Preguntas();
            lblContador.Text = "Pregunta: " + contador_actividades;
            
        }

        public void Preguntas()
        {
            switch(contador_actividades)
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
                    break;
            }
           
             
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
                    correct = true;
                    Reset();
                }
                else
                {
                    button1.BackColor = Color.Red;
                    correct = false;
                    Reset();
                }
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(enable==true)
            {
                button2.BackColor = Color.Red;
                Texto();
                correct = false;
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
                    correct = true;
                    Reset();
                }
                else
                {
                    button3.BackColor = Color.Red;
                    correct = false;
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
                Reset();
            }
            
        }

        public void Texto() { if (correct == true) { label1.Text = "C O R R E C T O!"; } else { label1.Text = "Q U E   L A S T I M A!"; } }

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
    }

}
