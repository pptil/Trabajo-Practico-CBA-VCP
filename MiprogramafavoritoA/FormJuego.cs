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
    public partial class FormJuego : Form
    {
        int cod=1;
        int opcion;
        WindowsMediaPlayer sonido;
        public FormJuego()
        {
            InitializeComponent();
        }

        private void FormJuego_Load(object sender, EventArgs e)
        {

            sonido = new WindowsMediaPlayer();
            Bloquear();
             Evaluar();
            cargarimagen();
            sonido.URL = Application.StartupPath + @"\Sonidos\Intro.mp3";
            sonido.controls.play();

            groupBoxRes.Visible = true;
            btnRespuesta.Visible = false;
            btnSonido.Visible = true;

           

        }

        //Metodos

        public void cargarimagen()
        {
            switch (cod)
            {
                case 1: //Perro
                    this.btnOpcion1.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Perro;
                    this.btnOpcion2.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Gato;
                    this.btnOpcion3.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Mono;
                    this.btnOpcion4.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Pollo;


                    break;
                case 2: //Pollo
                    this.btnOpcion1.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Mono;
                    this.btnOpcion2.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Buho;
                    this.btnOpcion3.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Cabra;
                    this.btnOpcion4.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Pollo;
                    
                    
                    break;
                case 3: //Mono
                    this.btnOpcion1.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Perro;
                    this.btnOpcion2.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Mono;
                    this.btnOpcion3.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Jirafa;
                    this.btnOpcion4.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Gato;
                   
                    break;
                case 4: //Gato
                    this.btnOpcion1.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Perro;
                    this.btnOpcion2.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Mono;
                    this.btnOpcion3.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Gato;
                    this.btnOpcion4.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Jirafa;
                   
                    break;
                case 5: //Cabra
                    this.btnOpcion1.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Perro;
                    this.btnOpcion2.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Gallo;
                    this.btnOpcion3.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Cabra;
                    this.btnOpcion4.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Gato;
                   
                    break;
                case 6: //Elefante
                    this.btnOpcion1.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Perro;
                    this.btnOpcion2.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Elefante;
                    this.btnOpcion3.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Jirafa;
                    this.btnOpcion4.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Gato;
                    break;
                case 7: //Buho
                    this.btnOpcion1.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Buho;
                    this.btnOpcion2.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Mono;
                    this.btnOpcion3.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Jirafa;
                    this.btnOpcion4.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Gato;
                    break;
                case 8: //Vaca
                    this.btnOpcion1.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Perro;
                    this.btnOpcion2.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Mono;
                    this.btnOpcion3.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Jirafa;
                    this.btnOpcion4.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Vaca;
                    
                    break;
                case 9:
                    // mostrar el progreso
                    cod = 1;
                    break;
            }
            }
        public void Evaluar()
        {
            switch (cod)
            {
                case 1: //Perro
                    
                    if (opcion == 1)
                    {
                        Ganar();
                        cod++;
                        Bloquear();
                    }
                    else
                    {
                        Perder();

                    }

                    break;
                case 2: //Pollo
                  //lblRes.Visible = false;
                    if (opcion == 4)
                    {
                        Ganar();
                        cod++;
                        Bloquear();
                    }
                    else
                    {
                        Perder();
                    }
                    break;
                case 3: //Mono
                   if (opcion == 2)
                    {
                        Ganar();
                        cod++;
                        Bloquear();
                    }
                    else
                    {
                        Perder();
                    }
                    break;
                case 4: //Gato
                   if (opcion == 3)
                    {
                        Ganar();
                        cod++;
                        Bloquear();
                    }
                    else
                    {
                        Perder();
                    }
                    break;
                case 5: //Cabra
                     if (opcion == 3)
                    {
                        Ganar();
                        cod++;
                        Bloquear();
                    }
                    else
                    {
                        Perder();
                    }
                    break;
                case 6: //Elefante
                    if (opcion == 2)
                    {
                        Ganar();
                        cod++;
                        Bloquear();
                    }
                    else
                    {
                        Perder();
                    }
                    break;
                case 7: //Buho
                    if (opcion == 1)
                    {
                        Ganar();
                        cod++;
                        Bloquear();
                    }
                    else
                    {
                        Perder();
                    }
                    break;
                case 8: //Vaca
                      if (opcion == 4)
                    {
                        Ganar();
                        cod++;
                        Bloquear();
                    }
                    else
                    {
                        Perder();
                    }
                    break;
            }

        }
        public void Reprodrucir()
        {
            switch (cod)
            {
                case 1:
                    sonido.URL = Application.StartupPath + @"\Sonidos\Perro.mp3";
                    sonido.controls.play();
                    break;
                case 2:
                    sonido.URL = Application.StartupPath + @"\Sonidos\Pollo.mp3";
                    sonido.controls.play();
                    break;
                case 3:
                    sonido.URL = Application.StartupPath + @"\Sonidos\Mono.mp3";
                    sonido.controls.play();
                    break;
                case 4:
                    sonido.URL = Application.StartupPath + @"\Sonidos\Gato.mp3";
                    sonido.controls.play();
                    break;
                case 5:
                    sonido.URL = Application.StartupPath + @"\Sonidos\Cabra.mp3";
                    sonido.controls.play();
                    break;
                case 6:
                    sonido.URL = Application.StartupPath + @"\Sonidos\Elefante.mp3";
                    sonido.controls.play();
                    break;
                case 7:
                    sonido.URL = Application.StartupPath + @"\Sonidos\Buho.mp3";
                    sonido.controls.play();
                    break;
                case 8:
                    sonido.URL = Application.StartupPath + @"\Sonidos\Vaca.mp3";
                    sonido.controls.play();
                    break;
            }

        }
        public void Bloquear()
        {
            btnRespuesta.BackgroundImage = null;
            groupBoxOp.Visible = false;
            btnRespuesta.Visible = false;
            
        }
        private void Ganar()
        {
            sonido.URL = Application.StartupPath + @"\Sonidos\Muy Bien.m4a";
            sonido.controls.play();
           
        }
        private void Perder()
        {
            
            sonido.URL = Application.StartupPath + @"\Sonidos\intentalo de nuevo.m4a";
            sonido.controls.play();
        }

        //Botones
     

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();

            
        }

        private void btnSonido_Click(object sender, EventArgs e)
        {
            Reprodrucir();
            btnRespuesta.Visible = true;
            groupBoxOp.Visible = true;
        }

        private void btnOpcion1_Click(object sender, EventArgs e)
        {
            opcion = 1;
            btnRespuesta.BackgroundImage = btnOpcion1.BackgroundImage;
            btnRespuesta.BackgroundImageLayout = btnOpcion1.BackgroundImageLayout;
            Evaluar();
            cargarimagen();
        }

        private void btnOpcion2_Click(object sender, EventArgs e)
        {
            opcion = 2;
            btnRespuesta.BackgroundImage = btnOpcion2.BackgroundImage;
            btnRespuesta.BackgroundImageLayout = btnOpcion2.BackgroundImageLayout;
            Evaluar();
            cargarimagen();
        }

        private void btnOpcion3_Click(object sender, EventArgs e)
        {
            opcion = 3;
            btnRespuesta.BackgroundImage = btnOpcion3.BackgroundImage;
            btnRespuesta.BackgroundImageLayout = btnOpcion3.BackgroundImageLayout;
            Evaluar();
            cargarimagen();
        }

        private void btnOpcion4_Click(object sender, EventArgs e)
        {
            opcion = 4;
            btnRespuesta.BackgroundImage = btnOpcion4.BackgroundImage;
            btnRespuesta.BackgroundImageLayout = btnOpcion4.BackgroundImageLayout;
            Evaluar();
            cargarimagen();
        }

        private void btnRespuesta_BackgroundImageChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxOp_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxRes_Enter(object sender, EventArgs e)
        {

        }

        private void btnRespuesta_Click(object sender, EventArgs e)
        {

        }
    }
}
