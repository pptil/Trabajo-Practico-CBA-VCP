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
    public partial class FrmJuego : Form
    {
       
        DataTable tblengua;
        DataTable tbmatematica;
        DataTable tbingles;
        DataTable tbcnaturales;
        DataTable tbcsociales;
        int codM, codI, C, I, codL, L, codCN, CN, codCS, CS;
        string n1, n2, n3, n4, resuM, mjeboton, p1, p2;
        int tiempo, bandera;
        string l1, l2, l3, l4, l5, pl1;
        string cn1, cn2, cs1;
        int CONTM, CONTI, CONTL, CONTCN, CONTCS;
        string mjeRESULTADO;
        WindowsMediaPlayer mp3;
        WindowsMediaPlayer media = new WindowsMediaPlayer();





        //timer
        private void Trmje_Tick(object sender, EventArgs e)
        {
            progreso();
        }


        //Paneles
        private void PIngles_Paint(object sender, PaintEventArgs e)
        {
            PIngles.BackColor = Color.MediumVioletRed;
            GbEvaluar.BackColor = Color.WhiteSmoke;
            BtnEvaluar.Visible = true;
            LblInformar.Visible = false;
            Ingles();
            
        }
        private void PLengua_Paint(object sender, PaintEventArgs e)
        {
            PLengua.BackColor = Color.DarkOrange;
            GbEvaluar.BackColor = Color.WhiteSmoke;
            BtnEvaluar.Visible = true;
            LblInformar.Visible = false;
            lengua();


        }

        private void PMatematica_Paint(object sender, PaintEventArgs e)
        {
            PMatematica.BackColor = Color.YellowGreen;
            GbEvaluar.BackColor = Color.DarkGray;
            BtnEvaluar.Visible = true;
            LblInformar.Visible = false;
            Matematica();
        }
        private void PCNaturales_Paint(object sender, PaintEventArgs e)
        {
            PCNaturales.BackColor = Color.PowderBlue;
            GbEvaluar.BackColor = Color.DarkGray;
            GbCN.BackColor = Color.PowderBlue;
            LbCN1.BackColor = Color.PowderBlue;
            BtnEvaluar.Visible = true;
            LblInformar.Visible = false;
            CNaturales();


        }
        private void PCSociales1_Paint(object sender, PaintEventArgs e)
        {
            PCSociales1.BackColor = Color.SlateGray;
            GbEvaluar.BackColor = Color.WhiteSmoke;
            BtnEvaluar.Visible = true;
            LblInformar.Visible = false;
            csociales();


        }


        //Botones

        private void BtnEvaluar_Click(object sender, EventArgs e)
        {

            BtnEvaluar.Enabled = false;
            tiempo = 0;
            progreso();
            if (bandera == 1) // Matematica
            { 
                if (codM == 1 || codM == 2 || codM == 5 || codM == 6 || codM == 7 || codM == 9)
                {
                    if (TxtA.Text == n1 && TxtB.Text == n2 &&
                     TxtResultado.Text == resuM)
                    {
                        Ganar();
                    }
                    else
                    {
                        Perder();
                    }
                }
            if (codM == 3)
            {
                if (TxtA.Text == n1 && TxtB.Text == n2 && TxtC.Text == n3
                    && TxtD.Text == n4 && TxtResultado.Text == resuM)
                {
                    Ganar();
                }
                else
                {
                    Perder();
                }
            }
            if (codM == 4 || codM == 8)
                if (TxtA.Text == n1 && TxtB.Text == n2 && TxtC.Text == n3
                && TxtResultado.Text == resuM)
                {
                    Ganar();
                }
                else
                {
                    Perder();
                }
            if (codM == 10)
            {
                if (TxtResultado.Text == resuM)
                {
                    Ganar();
                }
                else
                {
                    Perder();
                }
            }
            }//Matematica

            if (bandera == 2) //ingles
                switch (codI)
                {
                    case 1:

                        if (Cb3.Checked == true)
                        {
                            Ganar();
                        }
                        if (Cb3.Checked == false || Cb2.Checked == true || Cb1.Checked == true)
                        {
                            Perder();
                        }

                        break;


                    case 2:
                        if (Cb1.Checked == true)
                        {
                            Ganar();
                        }
                        if (Cb1.Checked == false || Cb2.Checked == true || Cb3.Checked == true)
                        {
                            Perder();

                        }


                        break;
                    case 3:
                        if (Cb2.Checked == true)
                        {
                            Ganar();
                        }
                        if (Cb2.Checked == false || Cb1.Checked == true || Cb3.Checked == true)
                        {
                            Perder();
                        }

                        break;
                    case 4:
                        if (Cb2.Checked == true)
                        {
                            Ganar();
                        }
                        if (Cb2.Checked == false || Cb1.Checked == true || Cb3.Checked == true)
                        {
                            Perder();
                        }

                        break;
                    case 5:
                        if (Cb3.Checked == true)
                        {
                            Ganar();
                        }
                        if (Cb3.Checked == false || Cb1.Checked == true || Cb2.Checked == true)
                        {
                            Perder();
                        }

                        break;
                    case 6:
                        if (Cb1.Checked == true)
                        {
                            Ganar();
                        }
                        if (Cb1.Checked == false || Cb2.Checked == true || Cb3.Checked == true)
                        {
                            Perder();
                        }

                        break;
                    case 7:
                        if (Cb1.Checked == true)
                        {
                            Ganar();
                        }
                        if (Cb1.Checked == false || Cb2.Checked == true || Cb3.Checked == true)
                        {
                            Perder();
                        }

                        break;
                    case 8:
                        if (Cb1.Checked == true)
                        {
                            Ganar();
                        }
                        if (Cb1.Checked == false || Cb2.Checked == true || Cb3.Checked == true)
                        {
                            Perder();
                        }

                        break;
                    case 9:
                        if (Cb1.Checked == true)
                        {
                            Ganar();
                        }
                        if (Cb1.Checked == false || Cb2.Checked == true || Cb3.Checked == true)
                        {
                            Perder();
                        }

                        break;
                    case 10:
                        if (Cb1.Checked == true)
                        {
                            Ganar();
                        }
                        if (Cb1.Checked == false || Cb2.Checked == true || Cb3.Checked == true)
                        {
                            Perder();
                        }

                        break;
                    case 11:
                        if (Cb1.Checked == true)
                        {
                            Ganar();
                        }
                        if (Cb1.Checked == false || Cb2.Checked == true || Cb3.Checked == true)
                        {
                            Perder();
                        }

                        break;
                    case 12:
                        if (Cb1.Checked == true)
                        {
                            Ganar();
                        }
                        if (Cb1.Checked == false || Cb2.Checked == true || Cb3.Checked == true)
                        {
                            Perder();
                        }

                        break;

                }
            if (bandera == 3) //Lengua
            {
                if (codL<=10)
                { 
                if (codL == 1 || codL == 2 || codL==7)
                {
                    if (TxtAL.Text == l1 && TxtBL.Text == l2)
                    {
                        Ganar();
                    }
                    else
                    {
                        Perder();
                    }
                }
                if (codL == 3 || codL == 4 ||codL==8 || codL==9)
                {
                    if (TxtAL.Text == l1 && TxtBL.Text == l2 && TxtCL.Text == l3)
                    {
                        Ganar();
                    }
                    else
                    {
                        Perder();
                    }
                }
                    if (codL == 5 || codL == 6)
                    {
                        if (TxtAL.Text == l1 && TxtBL.Text == l2 && TxtCL.Text == l3 && TxtDL.Text == l4)
                        {
                            Ganar();
                        }
                        else
                        {
                            Perder();
                        }
                    }
                    if (codL == 10)
                    {
                        if (TxtAL.Text == l1 && TxtBL.Text == l2 && TxtCL.Text == l3 && TxtDL.Text == l4 && TxtEL.Text==l5)
                        {
                            Ganar();
                        }
                        else
                    {
                        Perder();
                    }
                    }
                    
                }
            }//lengua
            if (bandera == 4)//Ciencia Naturales
            {
                switch (codCN)
                {
                    case 1:
                        if (LbCN1.SelectedIndex == 0)
                        {
                            Ganar();
                        }
                        else
                        {
                            Perder();
                        }
                        break;
                    case 2:
                        if (LbCN1.SelectedIndex == 1)
                        {
                            Ganar();
                        }
                        else
                        {
                            Perder();
                        }
                        break;
                    case 3:
                        if (LbCN1.SelectedIndex == 2)
                        {
                            Ganar();
                        }
                        else
                        {
                            Perder();
                        }
                        break;
                    case 4:
                        if (LbCN1.SelectedIndex == 0)
                        {
                            Ganar();
                        }
                        else
                        {
                            Perder();
                        }
                        break;
                    case 5:
                        if (LbCN1.SelectedIndex == 1)
                        {
                            Ganar();
                        }
                        else
                        {
                            Perder();
                        }
                        break;
                    case 6:
                        if (LbCN1.SelectedIndex == 2)
                        {
                            Ganar();
                        }
                        else
                        {
                            Perder();
                        }
                        break;
                    case 7:
                        if (LbCN1.SelectedIndex == 1)
                        {
                            Ganar();
                        }
                        else
                        {
                            Perder();
                        }
                        break;
                    case 8:
                        if (LbCN1.SelectedIndex == 2)
                        {
                            Ganar();
                        }
                        else
                        {
                            Perder();
                        }
                        break;
                    case 9:
                        if (LbCN1.SelectedIndex == 0)
                        {
                            Ganar();
                        }
                        else
                        {
                            Perder();
                        }
                        break;
                    case 10:
                        if (LbCN1.SelectedIndex == 0)
                        {
                            Ganar();
                        }
                        else
                        {
                            Perder();
                        }
                        break;
                }

            }// c naturales


            if (bandera == 5)// c sociales
            {
                switch (codCS)
                {
                    case 1:

                        if (RbCS13.Checked == true)
                        {
                            Ganar();
                        }
                        if (RbCS13.Checked == false || RbCS12.Checked == true || RbCS11.Checked == true)
                        {
                            Perder();
                        }
                        break;
                    case 2:

                        if (RbCS12.Checked == true)
                        {
                            Ganar();
                        }
                        if (RbCS12.Checked == false || RbCS13.Checked == true || RbCS11.Checked == true)
                        {
                            Perder();
                        }
                        break;
                    case 3:

                        if (RbCS13.Checked == true)
                        {
                            Ganar();
                        }
                        if (RbCS13.Checked == false || RbCS12.Checked == true || RbCS11.Checked == true)
                        {
                            Perder();
                        }
                        break;
                    case 4:

                        if (RbCS11.Checked == true)
                        {
                            Ganar();
                        }
                        if (RbCS11.Checked == false || RbCS12.Checked == true || RbCS13.Checked == true)
                        {
                            Perder();
                        }
                        break;
                    case 5:

                        if (RbCS11.Checked == true)
                        {
                            Ganar();
                        }
                        if (RbCS11.Checked == false || RbCS12.Checked == true || RbCS13.Checked == true)
                        {
                            Perder();
                        }
                        break;
                    case 6:

                        if (RbCS12.Checked == true)
                        {
                            Ganar();
                        }
                        if (RbCS12.Checked == false || RbCS11.Checked == true || RbCS13.Checked == true)
                        {
                            Perder();
                        }
                        break;
                    case 7:

                        if (RbCS13.Checked == true)
                        {
                            Ganar();
                        }
                        if (RbCS13.Checked == false || RbCS12.Checked == true || RbCS11.Checked == true)
                        {
                            Perder();
                        }
                        break;
                    case 8:

                        if (RbCS11.Checked == true)
                        {
                            Ganar();
                        }
                        if (RbCS11.Checked == false || RbCS12.Checked == true || RbCS13.Checked == true)
                        {
                            Perder();
                        }
                        break;
                    case 9:

                        if (RbCS12.Checked == true)
                        {
                            Ganar();
                        }
                        if (RbCS12.Checked == false || RbCS11.Checked == true || RbCS13.Checked == true)
                        {
                            Perder();
                        }
                        break;
                    case 10:

                        if (RbCS13.Checked == true)
                        {
                            Ganar();
                        }
                        if (RbCS13.Checked == false || RbCS12.Checked == true || RbCS11.Checked == true)
                        {
                            Perder();
                        }
                        break;
                }
            }// C SOCIALES

        Trmje.Enabled = true;

        }


       


        private void BtnPrimerG_Click(object sender, EventArgs e)
        {

            PMateria1.Visible = true;

        }



        private void BtnCSociales1_Click(object sender, EventArgs e)
        {
            PIngles.Visible = false;
            PMatematica.Visible = false;
            PLengua.Visible = false;
            PCNaturales.Visible = false;
            PCSociales1.Visible = true;
            GbEvaluar.Visible = true;
            CONTCS = 0;
            CS = 0;
        }

        private void BtnSegundoG_Click(object sender, EventArgs e)
        {
            error3grado();
        }
        private void BtnMatematica1_Click(object sender, EventArgs e)
        {
            PMatematica.Visible = true;
            PIngles.Visible = false;
            PLengua.Visible = false;
            PCNaturales.Visible = false;
            PCSociales1.Visible = false;
            GbEvaluar.Visible = true;
            CONTM = 0;
            C= 0;
        }

        private void BtnLengua1_Click(object sender, EventArgs e)
        {
            PLengua.Visible = true;
            PIngles.Visible = false;
            PMatematica.Visible = false;
            PCNaturales.Visible = false;
            PCSociales1.Visible = false;
            GbEvaluar.Visible = true;
            CONTL = 0;
            L = 0;
        }

        private void BtnCNaturales1_Click(object sender, EventArgs e)
        {
            PLengua.Visible = false;
            PIngles.Visible = false;
            PMatematica.Visible = false;
            PCNaturales.Visible = true;
            PCSociales1.Visible = false;
            GbEvaluar.Visible = true;
            CONTCN = 0;
            CN = 0;
        }
        private void BtnTercerG_Click(object sender, EventArgs e)
        {
            
            PTercerGrado.Visible = true;
        }
        private void BtnIgnles_Click(object sender, EventArgs e)
        {
            PIngles.Visible = true;
            PMatematica.Visible = false;
            PLengua.Visible = false;
            GbEvaluar.Visible = true;
            CONTI = 0;
            I = 0;
        }
        private void BTnBack_Click(object sender, EventArgs e)
        {
            media.controls.stop();
            this.Hide();
            FrmMenu frm = new FrmMenu();
            frm.ShowDialog();
            this.Close();

        }

        private void BtenVolver1_Click(object sender, EventArgs e)
        {
            Volver();
        }
        private void BtnVolver3_Click(object sender, EventArgs e)
        {
            Volver();
        }
        private void btnMatematica3_Click(object sender, EventArgs e)
        {
            error3grado();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            error3grado();
        }
        private void btnCNaturales3_Click(object sender, EventArgs e)
        {
            error3grado();
        }
        private void btnCSociales_Click(object sender, EventArgs e)
        {
            error3grado();
        }
        private void PbCerrar_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("¿ESTA SEGURO DE QUE QUIERE CERRAR LA APLICACION?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
           {
                Application.Exit();
            }
        }


        // metedos del form
        public FrmJuego()
        {
            InitializeComponent();

        }

       
        private void FrmJuego_Load(object sender, EventArgs e)
        {
            media.URL = @"gamemusic2.mp3";
            media.controls.play();
            media.settings.setMode("loop", true);

            bandera = 0;
            codM = 0;
            tiempo = 0;
            Trmje.Enabled = false;
            C = 0;
            codI = 0;
            codL = 0;
            codCS = 0;
            L = 0;
            codCN = 0;
            CN = 0;
            CS = 0;
            CONTM = 0;
            CONTI = 0;
            CONTL = 0;
            CONTCN = 0;
            CONTCS = 0;
            mp3 = new WindowsMediaPlayer();

        }



        //metodos creados
        private void progreso()
        {
            if (bandera == 1)//matematica
            {
                
                mjeboton = tiempo.ToString();
                BtnEvaluar.Text = mjeboton;
                tiempo++;
                if (tiempo == 20)
                {
                    if (codM <= 9)
                    {

                        C++;
                        LblInformar.Visible = false;
                        Matematica();
                        Reiniciar();
                        limpiarMatematica();
                    }
                    else
                    {
                        
                        mjeRESULTADO = Convert.ToString(CONTM);
                        LblInformar.Text = "RESULTADO: " + mjeRESULTADO + " DE 10";
                        FinalDeJuego();
                        Reiniciar();
                        limpiarMatematica();
                        C = 0;
                    }
                }
            }//Matematica

            if (bandera == 2)//Ingles
            {
                
                mjeboton = tiempo.ToString();
                BtnEvaluar.Text = mjeboton;
                tiempo++;
                if (tiempo == 20)
                {
                    if (codI <= 11)
                    {
                        I++;
                        LblInformar.Visible = false;
                        Ingles();
                        Reiniciar();
                        limpiarIngles();
                    }
                    else
                    {
                        I = 0;
                        mjeRESULTADO = Convert.ToString(CONTI);
                        LblInformar.Text = "RESULTADO: " + mjeRESULTADO + " DE 12";
                        FinalDeJuego();
                        Reiniciar();
                        limpiarIngles();
                    }
                }
            }//Ingles
            if (bandera == 3)//Lengua
            {
                
                mjeboton = tiempo.ToString();
                BtnEvaluar.Text = mjeboton;
                tiempo++;
                if (tiempo == 20)
                {
                    if (codL <= 9)
                    {

                        L++;
                        LblInformar.Visible = false;
                        lengua();
                        Reiniciar();
                        limpiarLengua();
                    }
                    else
                    {
                       // L = 0;
                        mjeRESULTADO = Convert.ToString(CONTL);
                        LblInformar.Text = "RESULTADO: " + mjeRESULTADO + " DE 10";
                        FinalDeJuego();
                        Reiniciar();
                        limpiarLengua();
                    }
                }
            }//Lengua
            if (bandera == 4)//Ciencia Naturales
            {
                
                mjeboton = tiempo.ToString();
                BtnEvaluar.Text = mjeboton;
                tiempo++;
                if (tiempo == 20)
                {
                    if (codCN <= 9)
                    {
                        CN++;
                        LblInformar.Visible = false;
                        CNaturales();
                        Reiniciar();
                        limpiarCNaturales();
                    }
                    else
                    {
                        CN = 0;
                        mjeRESULTADO = Convert.ToString(CONTCN);
                        LblInformar.Text = "RESULTADO: " + mjeRESULTADO + " DE 10";
                        FinalDeJuego();
                        Reiniciar();
                        limpiarCNaturales();
                    }
                }
            }// Ciencia Naturales
            if (bandera == 5)//Ciencia Sociales
            {
                
                mjeboton = tiempo.ToString();
                BtnEvaluar.Text = mjeboton;
                tiempo++;
                if (tiempo == 20)
                {
                    if (codCS <= 9)
                    {
                    LblInformar.Visible = false;
                     CS++;
                        csociales();
                        Reiniciar();
                        limpiarCSociales();
                    }
                    else
                    {
                        CS = 0;
                        mjeRESULTADO = Convert.ToString(CONTCS);
                        LblInformar.Text = "RESULTADO: " + mjeRESULTADO + " DE 10";
                        FinalDeJuego();
                        Reiniciar();
                        limpiarCNaturales();
                    }
                }

            }//CIencia Sociales
        }

        

        public void FinalDeJuego()
        {
            mp3.URL = Application.StartupPath + @"\MP3\Alerta 1.mp3";
            LblInformar.Visible = true;
            LblInformar.ForeColor = Color.YellowGreen;
            GbEvaluar.BackColor = Color.DarkViolet;
            PCNaturales.Visible = false;
            PMatematica.Visible = false;
            PIngles.Visible = false;
            PLengua.Visible = false;
            PCSociales1.Visible = false;
            BtnEvaluar.Visible = false;
            if (CONTCN > 5 || CONTCS > 5 || CONTM > 5 || CONTL > 5 || CONTI > 6)
            {
                LblInformar.ForeColor = Color.Yellow;
                GbEvaluar.BackColor = Color.Blue;
            }
            else
            {
                LblInformar.ForeColor = Color.White;
                GbEvaluar.BackColor = Color.Red;
            }

        }
        public void Reiniciar()
        {
            BtnEvaluar.Text = "¡EVALUAR!";
            BtnEvaluar.Enabled = true;
            Trmje.Enabled = false;
            Trmje.Stop();

        }

        public void limpiarCSociales()
        {
            RbCS11.Checked = false;
            RbCS12.Checked = false;
            RbCS13.Checked = false;
        }
        public void limpiarLengua()
        {
            TxtAL.Text = "";
            TxtBL.Text = "";
            TxtCL.Text = "";
            TxtDL.Text = "";
            TxtEL.Text = "";
        }
        public void limpiarIngles()
        {
            Cb1.Checked = false;
            Cb2.Checked = false;
            Cb3.Checked = false;
        }
        public void limpiarMatematica()
        {
            TxtA.Text = "";
            TxtB.Text = "";
            TxtC.Text = "";
            TxtD.Text = "";
            TxtResultado.Text = "";
        }
        public void limpiarCNaturales()
        {
            LbCN1.ClearSelected();
        }
        public void Matematica()
        {

            bandera = 1;
            tbmatematica = new DataTable();
            tbmatematica.Columns.Add("CTM");
            tbmatematica.Columns.Add("Problema");
            tbmatematica.Columns.Add("A");
            tbmatematica.Columns.Add("B");
            tbmatematica.Columns.Add("C");
            tbmatematica.Columns.Add("D");
            tbmatematica.Columns.Add("=");
            DataRow FTM1 = tbmatematica.NewRow();
            FTM1[0] = "1";
            FTM1[1] = "CARLITOS ESTA FELÍZ POR QUE SU PAPÁ LE REGALÓ 3 CARAMELOS, Y SU MAMÁ LE COMPRO 5 MAS CARAMELOS.\n¿CUÁNTOS CARAMELOS TIENE AHORA?";
            FTM1[2] = "3";
            FTM1[3] = "5";
            FTM1[4] = "0";
            FTM1[5] = "0";
            FTM1[6] = "8";
            tbmatematica.Rows.Add(FTM1);
            DataRow FTM2 = tbmatematica.NewRow();
            FTM2[0] = "2";
            FTM2[1] = "LISA TIENE 4 HERMOSAS FLORES, DECIDIÓ REGALAR 2 A SU ABUELA.\n¿CUÁNTAS FLORES LE QUEDARON?";
            FTM2[2] = "4";
            FTM2[3] = "2";
            FTM2[4] = "0";
            FTM2[5] = "0";
            FTM2[6] = "2";
            tbmatematica.Rows.Add(FTM2);
            DataRow FTM3 = tbmatematica.NewRow();
            FTM3[0] = "3";
            FTM3[1] = "10 NIÑOS Y 10 NIÑAS PARTICIPAN EN UN MARATÓN, 4 NIÑAS Y 1 NIÑO NO LLEGARON A LA META.\n¿CUÁNTOS ACABARON LA CARRERA?";
            FTM3[2] = "10";
            FTM3[3] = "10";
            FTM3[4] = "4";
            FTM3[5] = "1";
            FTM3[6] = "15";
            tbmatematica.Rows.Add(FTM3);
            DataRow FTM4 = tbmatematica.NewRow();
            FTM4[0] = "4";
            FTM4[1] = "TENEMOS EN LA HELADERA 8 BANANAS Y COMPRÓ 12 BANANAS MÀS, NOS COMEMOS LAS 8 BANANAS.\n¿CUÀNTAS BANANAS QUEDAN EN LA HELADERA?";
            FTM4[2] = "8";
            FTM4[3] = "12";
            FTM4[4] = "8";
            FTM4[5] = "0";
            FTM4[6] = "12";
            tbmatematica.Rows.Add(FTM4);
            DataRow FTM5 = tbmatematica.NewRow();
            FTM5[0] = "5";
            FTM5[1] = "LUIS COMRPÓ 4 MANGOS Y MARIA COMPRÓ 6 MANGOS.\n¿CUÀNTOS MANGOS TIENEN LOS DOS JUNTOS?";
            FTM5[2] = "4";
            FTM5[3] = "6";
            FTM5[4] = "0";
            FTM5[5] = "0";
            FTM5[6] = "10";
            tbmatematica.Rows.Add(FTM5);
            DataRow FTM6 = tbmatematica.NewRow();
            FTM6[0] = "6";
            FTM6[1] = "HAY 2 PELOTAS ROJAS Y 4 PELOTAS BLANCAS.\n¿CUÀNTAS PELOTAS HAY EN TOTAL?";
            FTM6[2] = "2";
            FTM6[3] = "4";
            FTM6[4] = "0";
            FTM6[5] = "0";
            FTM6[6] = "6";
            tbmatematica.Rows.Add(FTM6);
            DataRow FTM7 = tbmatematica.NewRow();
            FTM7[0] = "7";
            FTM7[1] = "2 PERROS ESTÁN JUGANDO, LLEGAN 3 PERROS MÁS.\n¿CUÁNTOS PERROS HAY EN TOTAL?";
            FTM7[2] = "2";
            FTM7[3] = "3";
            FTM7[4] = "0";
            FTM7[5] = "0";
            FTM7[6] = "5";
            tbmatematica.Rows.Add(FTM7);
            DataRow FTM8 = tbmatematica.NewRow();
            FTM8[0] = "8";
            FTM8[1] = "LA MAESTRA REPARTE 8 CHUPETINES ENTRE 3 DE SUS ALUMNOS,SI A UN ALUMNO LE DA 2 CHUPETINES Y A OTRO 5.\n¿CUÁNTOS CHUPETINES LE DARÁ AL TERCER ALUMNO?";
            FTM8[2] = "8";
            FTM8[3] = "2";
            FTM8[4] = "5";
            FTM8[5] = "0";
            FTM8[6] = "1";
            tbmatematica.Rows.Add(FTM8);
            DataRow FTM9 = tbmatematica.NewRow();
            FTM9[0] = "9";
            FTM9[1] = "JUAN TENÍA AHORRADO 4 MONEDAS DE 1 PESO Y ESTE DOMINGO AHORRÓ 5 MONEDAS MÁS.\n¿CUÁNTAS MONEDAS DE 1 PESO TIENE JUAN?";
            FTM9[2] = "4";
            FTM9[3] = "5";
            FTM9[4] = "0";
            FTM9[5] = "0";
            FTM9[6] = "9";
            tbmatematica.Rows.Add(FTM9);
            DataRow FTM10 = tbmatematica.NewRow();
            FTM10[0] = "10";
            FTM10[1] = "SOY MENOR QUE 4 Y MAYOR QUE 2.\n¿QUÉ NÚMERO SOY?";
            FTM10[2] = "0";
            FTM10[3] = "0";
            FTM10[4] = "0";
            FTM10[5] = "0";
            FTM10[6] = "3";
            tbmatematica.Rows.Add(FTM10);
            //Agregar mas operaciones

            codM = int.Parse(tbmatematica.Rows[C][0].ToString());//LEE FILA Y COLUMNA 
            n1 = tbmatematica.Rows[C][2].ToString();
            n2 = tbmatematica.Rows[C][3].ToString();
            n3 = tbmatematica.Rows[C][4].ToString();
            n4 = tbmatematica.Rows[C][5].ToString();
            resuM = tbmatematica.Rows[C][6].ToString();

            
                switch (codM)
                {
                    case 1:
                        LblPregunta.Text = tbmatematica.Rows[C][1].ToString();
                        TxtA.Visible = true;
                        TxtB.Visible = true;
                        TxtC.Visible = false;
                        TxtD.Visible = false;
                        LblA.Visible = true;
                        LblA.Text = "+";
                        LblB.Visible = false;
                        LblC.Visible = false;
                    pictureBox1.Image = imLMatematica.Images[0];

                    break;

                    case 2:
                        LblPregunta.Text = tbmatematica.Rows[C][1].ToString();
                        TxtA.Visible = true;
                        TxtB.Visible = true;
                        TxtC.Visible = false;
                        TxtD.Visible = false;
                        LblA.Visible = true;
                        LblA.Text = "-";
                        LblB.Visible = false;
                        LblC.Visible = false;
                    pictureBox1.Image = imLMatematica.Images[1];

                    break;

                    case 3:
                        LblPregunta.Text = tbmatematica.Rows[C][1].ToString();
                        TxtA.Visible = true;
                        TxtB.Visible = true;
                        TxtC.Visible = true;
                        TxtD.Visible = true;
                        LblA.Visible = true;
                        LblA.Text = "+";
                        LblB.Visible = true;
                        LblB.Text = "-";
                        LblC.Visible = true;
                        LblC.Text = "-";
                    pictureBox1.Image = imLMatematica.Images[2];

                    break;
                    case 4:
                        LblPregunta.Text = tbmatematica.Rows[C][1].ToString();
                        TxtA.Visible = true;
                        TxtB.Visible = true;
                        TxtC.Visible = true;
                        TxtD.Visible = false;
                        LblA.Visible = true;
                        LblA.Text = "+";
                        LblB.Visible = true;
                        LblB.Text = "-";
                        LblC.Visible = false;
                    pictureBox1.Image = imLMatematica.Images[3];

                    break;
                case 5:
                    LblPregunta.Text = tbmatematica.Rows[C][1].ToString();
                    TxtA.Visible = true;
                    TxtB.Visible = true;
                    TxtC.Visible = false;
                    TxtD.Visible = false;
                    LblA.Visible = true;
                    LblA.Text = "+";
                    LblB.Visible = false;
                    LblC.Visible = false;
                    pictureBox1.Image = imLMatematica.Images[4];
                    break;
                case 6:
                    LblPregunta.Text = tbmatematica.Rows[C][1].ToString();
                    TxtA.Visible = true;
                    TxtB.Visible = true;
                    TxtC.Visible = false;
                    TxtD.Visible = false;
                    LblA.Visible = true;
                    LblA.Text = "+";
                    LblB.Visible = false;
                    LblC.Visible = false;
                    pictureBox1.Image = imLMatematica.Images[5];
                    break;
                case 7:
                    LblPregunta.Text = tbmatematica.Rows[C][1].ToString();
                    TxtA.Visible = true;
                    TxtB.Visible = true;
                    TxtC.Visible = false;
                    TxtD.Visible = false;
                    LblA.Visible = true;
                    LblA.Text = "+";
                    LblB.Visible = false;
                    LblC.Visible = false;
                    pictureBox1.Image = imLMatematica.Images[6];
                    break;
                case 8:
                    LblPregunta.Text = tbmatematica.Rows[C][1].ToString();
                    TxtA.Visible = true;
                    TxtB.Visible = true;
                    TxtC.Visible = true;
                    TxtD.Visible = false;
                    LblA.Visible = true;
                    LblA.Text = "-";
                    LblB.Visible = true;
                    LblC.Text = "-";
                    LblC.Visible = false;
                    pictureBox1.Image = imLMatematica.Images[7];
                    break;
                case 9:
                    LblPregunta.Text = tbmatematica.Rows[C][1].ToString();
                    TxtA.Visible = true;
                    TxtB.Visible = true;
                    TxtC.Visible = false;
                    TxtD.Visible = false;
                    LblA.Visible = true;
                    LblA.Text = "+";
                    LblB.Visible = false;
                    LblC.Visible = false;
                    pictureBox1.Image = imLMatematica.Images[8];
                    break;
                case 10:
                    LblPregunta.Text = tbmatematica.Rows[C][1].ToString();
                    TxtA.Visible = false;
                    TxtB.Visible = false;
                    TxtC.Visible = false;
                    TxtD.Visible = false;
                    LblA.Visible = false;
                    LblB.Visible = false;
                    LblC.Visible = false;
                    pictureBox1.Image = imLMatematica.Images[9];
                    break;
                
            }
            
            
        }
        public void CNaturales()
        {
            bandera = 4;
            tbcnaturales = new DataTable();
            tbcnaturales.Columns.Add("CTCN");
            tbcnaturales.Columns.Add("Animal");
            tbcnaturales.Columns.Add("Tipo de animales");
            DataRow FTCN1 = tbcnaturales.NewRow();
            FTCN1[0] = "1";
            FTCN1[1] = "LEON";
            FTCN1[2] = "TERRESTRE";
            
            tbcnaturales.Rows.Add(FTCN1);
            DataRow FTCN2 = tbcnaturales.NewRow();
            FTCN2[0] = "2";
            FTCN2[1] = "PEZ GLOBO";
            FTCN2[2] = "ACUATICO";
            
            tbcnaturales.Rows.Add(FTCN2);
            DataRow FTCN3 = tbcnaturales.NewRow();
            FTCN3[0] = "3";
            FTCN3[1] = "PAJARO CARPINTERO";
            FTCN3[2] = "AEREO";

            tbcnaturales.Rows.Add(FTCN3);
            DataRow FTCN4 = tbcnaturales.NewRow();
            FTCN4[0] = "4";
            FTCN4[1] = "ELEFANTE";
            FTCN4[2] = "TERRESTRE";
            tbcnaturales.Rows.Add(FTCN4);
            DataRow FTCN5 = tbcnaturales.NewRow();
            FTCN5[0] = "5";
            FTCN5[1] = "TIBURON";
            FTCN5[2] = "ACUATICO";
            tbcnaturales.Rows.Add(FTCN5);
            DataRow FTCN6 = tbcnaturales.NewRow();
            FTCN6[0] = "6";
            FTCN6[1] = "AGUILA";
            FTCN6[2] = "AEREO";
            tbcnaturales.Rows.Add(FTCN6);
            DataRow FTCN7 = tbcnaturales.NewRow();
            FTCN7[0] = "7";
            FTCN7[1] = "BALLENA";
            FTCN7[2] = "ACUATICO";
            tbcnaturales.Rows.Add(FTCN7);
            DataRow FTCN8 = tbcnaturales.NewRow();
            FTCN8[0] = "8";
            FTCN8[1] = "PALOMA";
            FTCN8[2] = "AEREO";
            tbcnaturales.Rows.Add(FTCN8);
            DataRow FTCN9= tbcnaturales.NewRow();
            FTCN9[0] = "9";
            FTCN9[1] = "TIGRE";
            FTCN9[2] = "TERRESTRE";
            tbcnaturales.Rows.Add(FTCN9);
            DataRow FTCN10 = tbcnaturales.NewRow();
            FTCN10[0] = "10";
            FTCN10[1] = "ÑANDU";
            FTCN10[2] = "TERRESTRE";
            tbcnaturales.Rows.Add(FTCN10);

            codCN = Convert.ToInt32(tbcnaturales.Rows[CN][0].ToString());
            cn1 = tbcnaturales.Rows[CN][1].ToString();
            cn2 = tbcnaturales.Rows[CN][2].ToString();

            
                switch (codCN)
                {
                    case 1:
                        LblPreguntaCN1.Text = cn1;
                        PbCNaturales1.Image = ImListNaturales.Images[0];
                        break;
                    case 2:
                        LblPreguntaCN1.Text = cn1;
                        PbCNaturales1.Image = ImListNaturales.Images[1];
                        break;
                    case 3:
                        LblPreguntaCN1.Text = cn1;
                        PbCNaturales1.Image = ImListNaturales.Images[2];
                        break;
                    case 4:
                        LblPreguntaCN1.Text = cn1;
                        PbCNaturales1.Image = ImListNaturales.Images[3];
                        break;
                case 5:
                    LblPreguntaCN1.Text = cn1;
                    PbCNaturales1.Image = ImListNaturales.Images[4];
                    break;
                case 6:
                    LblPreguntaCN1.Text = cn1;
                    PbCNaturales1.Image = ImListNaturales.Images[5];
                    break;
                case 7:
                    LblPreguntaCN1.Text = cn1;
                    PbCNaturales1.Image = ImListNaturales.Images[6];
                    break;
                case 8:
                    LblPreguntaCN1.Text = cn1;
                    PbCNaturales1.Image = ImListNaturales.Images[7];
                    break;
                case 9:
                    LblPreguntaCN1.Text = cn1;
                    PbCNaturales1.Image = ImListNaturales.Images[8];
                    break;
                case 10:
                    LblPreguntaCN1.Text = cn1;
                    PbCNaturales1.Image = ImListNaturales.Images[9];
                    break;
            }
            
            
        }
        public void lengua()
        {
            bandera = 3;
            tblengua = new DataTable();
            tblengua.Columns.Add("CTL");
            tblengua.Columns.Add("Silaba");
            tblengua.Columns.Add("1");
            tblengua.Columns.Add("2");
            tblengua.Columns.Add("3");
            tblengua.Columns.Add("4");
            tblengua.Columns.Add("5");
            DataRow FTL1 = tblengua.NewRow();
            FTL1[0] = "1";
            FTL1[1] = "GATO";
            FTL1[2] = "GA";
            FTL1[3] = "TO";
            FTL1[4] = "";
            FTL1[5] = "";
            FTL1[6] = "";
           
            tblengua.Rows.Add(FTL1);
            DataRow FTL2 = tblengua.NewRow();
            pictureBox1.Image = ImListNaturales.Images[4];
            FTL2[0] = "2";
            FTL2[1] = "CASA";
            FTL2[2] = "CA";
            FTL2[3] = "SA";
            FTL2[4] = "";
            FTL2[5] = "";
            FTL2[6] = "";
           
            tblengua.Rows.Add(FTL2);
            DataRow FTL3 = tblengua.NewRow();
            FTL3[0] = "3";
            FTL3[1] = "BANANA";
            FTL3[2] = "BA";
            FTL3[3] = "NA";
            FTL3[4] = "NA";
            FTL3[5] = "";
            FTL3[6] = "";
           
            tblengua.Rows.Add(FTL3);
            DataRow FTL4 = tblengua.NewRow();
            FTL4[0] = "4";
            FTL4[1] = "PELOTA";
            FTL4[2] = "PE";
            FTL4[3] = "LO";
            FTL4[4] = "TA";
            FTL4[5] = "";
            FTL4[6] = "";
            
            tblengua.Rows.Add(FTL4);
            DataRow FTL5 = tblengua.NewRow();
            FTL5[0] = "5";
            FTL5[1] = "TELEFONO";
            FTL5[2] = "TE";
            FTL5[3] = "LE";
            FTL5[4] = "FO";
            FTL5[5] = "NO";
            FTL5[6] = "";
            
            tblengua.Rows.Add(FTL5);
            DataRow FTL6 = tblengua.NewRow();
            FTL6[0] = "6";
            FTL6[1] = "BICICLETA";
            FTL6[2] = "BI";
            FTL6[3] = "CI";
            FTL6[4] = "CLE";
            FTL6[5] = "TA";
            FTL6[6] = "";
            
            tblengua.Rows.Add(FTL6);
            DataRow FTL7 = tblengua.NewRow();
            FTL7[0] = "7";
            FTL7[1] = "REGLA";
            FTL7[2] = "RE";
            FTL7[3] = "GLA";
            FTL7[4] = "";
            FTL7[5] = "";
            FTL7[6] = "";
            tblengua.Rows.Add(FTL7);
            DataRow FTL8 = tblengua.NewRow();
            FTL8[0] = "8";
            FTL8[1] = "TECLADO";
            FTL8[2] = "TE";
            FTL8[3] = "CLA";
            FTL8[4] = "DO";
            FTL8[5] = "";
            FTL8[6] = "";
            tblengua.Rows.Add(FTL8);
            DataRow FTL9 = tblengua.NewRow();
            FTL9[0] = "9";
            FTL9[1] = "MOCHILA";
            FTL9[2] = "MO";
            FTL9[3] = "CHI";
            FTL9[4] = "LA";
            FTL9[5] = "";
            FTL9[6] = "";
            tblengua.Rows.Add(FTL9);
            DataRow FTL10 = tblengua.NewRow();
            FTL10[0] = "10";
            FTL10[1] = "COMPUTADORA";
            FTL10[2] = "COM";
            FTL10[3] = "PU";
            FTL10[4] = "TA";
            FTL10[5] = "DO";
            FTL10[6] = "RA";
            tblengua.Rows.Add(FTL10);



            codL = int.Parse(tblengua.Rows[L][0].ToString());
            pl1 = tblengua.Rows[L][1].ToString();
            l1 = tblengua.Rows[L][2].ToString();
            l2 = tblengua.Rows[L][3].ToString();
            l3 = tblengua.Rows[L][4].ToString();
            l4 = tblengua.Rows[L][5].ToString();
            l5 = tblengua.Rows[L][6].ToString();

            
            switch (codL)
            {
                case 1:
                    LblPreguntaL.Text = pl1;
                    TxtAL.Text = l1;
                    //TxtAL.Enabled = false;
                    TxtCL.Visible = false;
                    TxtDL.Visible = false;
                    TxtEL.Visible = false;
                    LblL2.Visible = false;
                    LblL3.Visible = false;
                    LblL4.Visible = false;
                    PbLengua.Image = imLLengua.Images[0];
                    break;
                   
                case 2:
                    
                    LblPreguntaL.Text = pl1;
                    TxtAL.Enabled = true;
                    TxtBL.Text = l2;
                    TxtCL.Visible = false;
                    TxtDL.Visible = false;
                    TxtEL.Visible = false;
                    LblL2.Visible = false;
                    LblL3.Visible = false;
                    LblL4.Visible = false;
                    PbLengua.Image = imLLengua.Images[1];
                    break;
                case 3:
                    LblPreguntaL.Text = pl1;
                    TxtAL.Enabled = true;
                    TxtBL.Enabled = true;
                    TxtCL.Visible = true;
                    TxtCL.Text = l3;
                    TxtDL.Visible = false;
                    TxtEL.Visible = false;
                    LblL2.Visible = true;
                    LblL3.Visible = false;
                    LblL4.Visible = false;
                    PbLengua.Image = imLLengua.Images[2];
                    break;
                case 4:
                    LblPreguntaL.Text = pl1;
                    TxtAL.Enabled = true;
                    TxtBL.Enabled = true;
                    TxtCL.Enabled = true;
                    TxtDL.Visible = false;
                    TxtEL.Visible = false;
                    LblL2.Visible = true;
                    LblL3.Visible = false;
                    LblL4.Visible = false;
                    PbLengua.Image = imLLengua.Images[3];
                    break;
                case 5:
                    LblPreguntaL.Text = pl1;
                    TxtAL.Enabled = true;
                    TxtBL.Enabled = true;
                    TxtCL.Enabled = true;
                    TxtDL.Visible = true;
                    TxtEL.Visible = false;
                    LblL3.Visible = true;
                    LblL4.Visible = false;
                    PbLengua.Image = imLLengua.Images[4];
                    break;
                case 6:
                    LblPreguntaL.Text = pl1;
                    TxtAL.Enabled = true;
                    TxtBL.Enabled = true;
                    TxtCL.Enabled = true;
                    TxtDL.Visible = true;
                    TxtEL.Visible = false;
                    LblL3.Visible = true;
                    LblL4.Visible = false;
                    PbLengua.Image = imLLengua.Images[5];
                    break;
                case 7:
                    LblPreguntaL.Text = pl1;
                    TxtAL.Visible = true;
                    TxtCL.Visible = false;
                    TxtDL.Visible = false;
                    TxtEL.Visible = false;
                    LblL2.Visible = false;
                    LblL3.Visible = false;
                    LblL4.Visible = false;
                    PbLengua.Image = imLLengua.Images[6];
                    break;
                case 8:
                    LblPreguntaL.Text = pl1;
                    TxtAL.Enabled = true;
                    TxtBL.Enabled = true;
                    TxtCL.Visible = true;
                    TxtDL.Visible = false;
                    TxtEL.Visible = false;
                    LblL2.Visible = true;
                    LblL3.Visible = false;
                    LblL4.Visible = false;
                    PbLengua.Image = imLLengua.Images[7];
                    break;
                case 9:
                    LblPreguntaL.Text = pl1;
                    TxtAL.Enabled = true;
                    TxtBL.Enabled = true;
                    TxtCL.Visible = true;
                    TxtDL.Visible = false;
                    TxtEL.Visible = false;
                    LblL2.Visible = true;
                    LblL3.Visible = false;
                    LblL4.Visible = false;
                    PbLengua.Image = imLLengua.Images[8];
                    break;
                case 10:
                    LblPreguntaL.Text = pl1;
                    TxtAL.Enabled = true;
                    TxtBL.Enabled = true;
                    TxtCL.Visible = true;
                    TxtDL.Visible = true;
                    TxtEL.Visible = true;
                    LblL2.Visible = true;
                    LblL3.Visible = true;
                    LblL4.Visible = true;
                    PbLengua.Image = imLLengua.Images[9];
                    break;
            }
            
        }

         public void Ingles()
        {
            bandera = 2;
            tbingles = new DataTable();
            tbingles.Columns.Add("CTI");
            tbingles.Columns.Add("PIngles");
            tbingles.Columns.Add("PEspañol");
            DataRow FTI1 = tbingles.NewRow();
            FTI1[0] = "1";
            FTI1[1] = "ONE";
            FTI1[2] = "UNO";
            
            tbingles.Rows.Add(FTI1);
            DataRow FTI2 = tbingles.NewRow();
            FTI2[0] = "2";
            FTI2[1] = "TWO";
            FTI2[2] = "DOS";
            
            tbingles.Rows.Add(FTI2);
            DataRow FTI3 = tbingles.NewRow();
            FTI3[0] = "3";
            FTI3[1] = "RED";
            FTI3[2] = "ROJO";
            tbingles.Rows.Add(FTI3);
            DataRow FTI4 = tbingles.NewRow();
            FTI4[0] = "4";
            FTI4[1] = "GREEN";
            FTI4[2] = "VERDE";
            tbingles.Rows.Add(FTI4);
            DataRow FTI5 = tbingles.NewRow();
            FTI5[0] = "5";
            FTI5[1] = "BLUE";
            FTI5[2] = "AZUL";
            tbingles.Rows.Add(FTI5);
            DataRow FTI6 = tbingles.NewRow();
            FTI6[0] = "6";
            FTI6[1] = "DOG";
            FTI6[2] = "PERRO";
            tbingles.Rows.Add(FTI6);
            DataRow FTI7 = tbingles.NewRow();
            FTI7[0] = "7";
            FTI7[1] = "CAT";
            FTI7[2] = "GATO";
            tbingles.Rows.Add(FTI7);
            DataRow FTI8 = tbingles.NewRow();
            FTI8[0] = "8";
            FTI8[1] = "HOUSE";
            FTI8[2] = "CASA";
            tbingles.Rows.Add(FTI8);
            DataRow FTI9 = tbingles.NewRow();
            FTI9[0] = "9";
            FTI9[1] = "FOOD";
            FTI9[2] = "COMIDA";
            tbingles.Rows.Add(FTI9);
            DataRow FTI10 = tbingles.NewRow();
            FTI10[0] = "10";
            FTI10[1] = "PERNCIL";
            FTI10[2] = "LAPIZ";
            tbingles.Rows.Add(FTI10);

            DataRow FTI11 = tbingles.NewRow();
            FTI11[0] = "11";
            FTI11[1] = "BYE";
            FTI11[2] = "ADIOS";
            tbingles.Rows.Add(FTI11);

            DataRow FTI12 = tbingles.NewRow();
            FTI12[0] = "12";
            FTI12[1] = "HELLO";
            FTI12[2] = "HOLA";
            tbingles.Rows.Add(FTI12);
            //necesiomas palabras


            codI = int.Parse(tbingles.Rows[I][0].ToString());
            p1 = tbingles.Rows[I][1].ToString();
            p2 = tbingles.Rows[I][2].ToString();


            
            switch (codI)
            {
                case 1:


                    LblPreguntaI.Text = p1;

                    Cb1.Text = tbingles.Rows[11][2].ToString();
                    Cb2.Text = tbingles.Rows[5][2].ToString();
                    Cb3.Text = p2;
                    PbIngles.Image = ImListIngles.Images[0];

                    break;
                case 2:
                    LblPreguntaI.Text = p1;

                    Cb3.Text = tbingles.Rows[11][2].ToString();
                    Cb2.Text = tbingles.Rows[5][2].ToString();
                    Cb1.Text = p2;
                    PbIngles.Image = ImListIngles.Images[1];
                    break;
                case 3:
                    LblPreguntaI.Text = p1;
                    Cb1.Text = tbingles.Rows[11][2].ToString();
                    Cb2.Text = p2;
                    Cb3.Text = tbingles.Rows[5][2].ToString();
                    PbIngles.Image = ImListIngles.Images[2];

                    break;
                case 4:
                    LblPreguntaI.Text = p1;

                    Cb2.Text = p2;
                    Cb1.Text = tbingles.Rows[11][2].ToString();
                    Cb3.Text = tbingles.Rows[5][2].ToString();
                    PbIngles.Image = ImListIngles.Images[3];
                    break;
                case 5:
                    LblPreguntaI.Text = p1;

                    Cb3.Text = p2;
                    Cb1.Text = tbingles.Rows[11][2].ToString();
                    Cb2.Text = tbingles.Rows[0][2].ToString();
                    PbIngles.Image = ImListIngles.Images[4];
                    break;
                case 6:
                    LblPreguntaI.Text = p1;

                    Cb1.Text = p2;
                    Cb3.Text = tbingles.Rows[11][2].ToString();
                    Cb2.Text = tbingles.Rows[7][2].ToString();
                    PbIngles.Image = ImListIngles.Images[5];
                    break;
                    case 7:
                        LblPreguntaI.Text = p1;

                        Cb1.Text = p2;
                        Cb3.Text = tbingles.Rows[0][2].ToString();
                        Cb2.Text = tbingles.Rows[5][2].ToString();
                    PbIngles.Image = ImListIngles.Images[6];
                    break;
                    case 8:
                        LblPreguntaI.Text = p1;

                        Cb1.Text = p2;
                        Cb3.Text = tbingles.Rows[4][2].ToString();
                        Cb2.Text = tbingles.Rows[11][2].ToString();
                    PbIngles.Image = ImListIngles.Images[7];
                    break;
                    case 9:
                        LblPreguntaI.Text = p1;

                        Cb1.Text = p2;
                        Cb3.Text = tbingles.Rows[2][2].ToString();
                        Cb2.Text = tbingles.Rows[10][2].ToString();
                    PbIngles.Image = ImListIngles.Images[8];
                    break;
                    case 10:
                        LblPreguntaI.Text = p1;

                        Cb1.Text = p2;
                        Cb3.Text = tbingles.Rows[4][2].ToString();
                        Cb2.Text = tbingles.Rows[5][2].ToString();
                    PbIngles.Image = ImListIngles.Images[9];
                    break;
                    case 11:
                        LblPreguntaI.Text = p1;

                        Cb1.Text = p2;
                        Cb3.Text = tbingles.Rows[8][2].ToString();
                        Cb2.Text = tbingles.Rows[3][2].ToString();
                    PbIngles.Image = ImListIngles.Images[10];
                    break;
                    case 12:
                        LblPreguntaI.Text = p1;

                        Cb1.Text = p2;
                        Cb3.Text = tbingles.Rows[8][2].ToString();
                        Cb2.Text = tbingles.Rows[7][2].ToString();
                    PbIngles.Image = ImListIngles.Images[11];
                    break;
                }
           
        }

        public void csociales()
        {
            bandera = 5;
            tbcsociales = new DataTable();
            tbcsociales.Columns.Add("CTCS");
            tbcsociales.Columns.Add("Profesion");
            DataRow FTCS1 = tbcsociales.NewRow();
            FTCS1[0] = "1";
            FTCS1[1] = "DOCTOR";
            tbcsociales.Rows.Add(FTCS1);
            DataRow FTCS2 = tbcsociales.NewRow();
            FTCS2[0] = "2";
            FTCS2[1] = "POLICIA";
            tbcsociales.Rows.Add(FTCS2);
            DataRow FTCS3 = tbcsociales.NewRow();
            FTCS3[0] = "3";
            FTCS3[1] = "MAESTRA";
            tbcsociales.Rows.Add(FTCS3);
            DataRow FTCS4 = tbcsociales.NewRow();
            FTCS4[0] = "4";
            FTCS4[1] = "BOMBERO";
            tbcsociales.Rows.Add(FTCS4);
            DataRow FTCS5 = tbcsociales.NewRow();
            FTCS5[0] = "5";
            FTCS5[1] = "VETERINARIO";
            tbcsociales.Rows.Add(FTCS5);
            DataRow FTCS6 = tbcsociales.NewRow();
            FTCS6[0] = "6";
            FTCS6[1] = "COCINERO";
            tbcsociales.Rows.Add(FTCS6);
            DataRow FTCS7 = tbcsociales.NewRow();
            FTCS7[0] = "7";
            FTCS7[1] = "PANADERO";
            PbImagenCS1.Image = ImListSociales.Images[6];
            tbcsociales.Rows.Add(FTCS7);
            DataRow FTCS8 = tbcsociales.NewRow();
            FTCS8[0] = "8";
            FTCS8[1] = "MARINERO";
            tbcsociales.Rows.Add(FTCS8);
            DataRow FTCS9 = tbcsociales.NewRow();
            FTCS9[0] = "9";
            FTCS9[1] = "FUTBOLITA";
            tbcsociales.Rows.Add(FTCS9);
            DataRow FTCS10 = tbcsociales.NewRow();
            FTCS10[0] = "10";
            FTCS10[1] = "JUEZ";
            tbcsociales.Rows.Add(FTCS10);

            codCS = int.Parse(tbcsociales.Rows[CS][0].ToString());
            cs1 = tbcsociales.Rows[CS][1].ToString();

            
                switch (codCS)
                {
                    case 1:
                        LblPreguntaCS1.Text = cs1;
                        RbCS11.Text = tbcsociales.Rows[7][1].ToString();
                        RbCS12.Text = tbcsociales.Rows[8][1].ToString();
                        RbCS13.Text = cs1;
                        PbImagenCS1.Image = ImListSociales.Images[0];
                        break;
                    case 2:
                        LblPreguntaCS1.Text = cs1;
                        RbCS11.Text = tbcsociales.Rows[9][1].ToString();
                        RbCS13.Text = tbcsociales.Rows[4][1].ToString();
                        RbCS12.Text = cs1;
                        PbImagenCS1.Image = ImListSociales.Images[1];
                        break;
                    case 3:
                        LblPreguntaCS1.Text = cs1;
                        RbCS11.Text = tbcsociales.Rows[8][1].ToString();
                        RbCS12.Text = tbcsociales.Rows[6][1].ToString();
                        RbCS13.Text = cs1;
                        PbImagenCS1.Image = ImListSociales.Images[2];
                        break;
                    case 4:
                        LblPreguntaCS1.Text = cs1;
                        RbCS13.Text = tbcsociales.Rows[7][1].ToString();
                        RbCS12.Text = tbcsociales.Rows[1][1].ToString();
                        RbCS11.Text = cs1;
                        PbImagenCS1.Image = ImListSociales.Images[3];
                        break;
                    case 5:
                        LblPreguntaCS1.Text = cs1;
                        RbCS13.Text = tbcsociales.Rows[2][1].ToString();
                        RbCS12.Text = tbcsociales.Rows[3][1].ToString();
                        RbCS11.Text = cs1;
                        PbImagenCS1.Image = ImListSociales.Images[4];
                        break;
                case 6:
                    LblPreguntaCS1.Text = cs1;
                    RbCS13.Text = tbcsociales.Rows[0][1].ToString();
                    RbCS11.Text = tbcsociales.Rows[9][1].ToString();
                    RbCS12.Text = cs1;
                    PbImagenCS1.Image = ImListSociales.Images[5];
                    break;
                case 7:
                    LblPreguntaCS1.Text = cs1;
                    RbCS12.Text = tbcsociales.Rows[1][1].ToString();
                    RbCS11.Text = tbcsociales.Rows[5][1].ToString();
                    RbCS13.Text = cs1;
                    PbImagenCS1.Image = ImListSociales.Images[6];
                    break;
                case 8:
                    LblPreguntaCS1.Text = cs1;
                    RbCS13.Text = tbcsociales.Rows[3][1].ToString();
                    RbCS12.Text = tbcsociales.Rows[4][1].ToString();
                    RbCS11.Text = cs1;
                    PbImagenCS1.Image = ImListSociales.Images[7];
                    break;
                case 9:
                    LblPreguntaCS1.Text = cs1;
                    RbCS13.Text = tbcsociales.Rows[5][1].ToString();
                    RbCS11.Text = tbcsociales.Rows[7][1].ToString();
                    RbCS12.Text = cs1;
                    PbImagenCS1.Image = ImListSociales.Images[8];
                    break;
                case 10:
                    LblPreguntaCS1.Text = cs1;
                    RbCS11.Text = tbcsociales.Rows[1][1].ToString();
                    RbCS12.Text = tbcsociales.Rows[2][1].ToString();
                    RbCS13.Text = cs1;
                    PbImagenCS1.Image = ImListSociales.Images[9];
                    break;
                
            }
            
        }
        public void Ganar()
        {
            
            mp3.URL = Application.StartupPath + @"\MP3\correct 1.mp3";
            if (bandera == 1)
            { CONTM++; }
            if (bandera == 2)
            { CONTI++; }
            if (bandera == 3)
            { CONTL++; }
            if (bandera == 4)
            { CONTCN++; }
            if (bandera == 5)
            { CONTCS++; }
            LblInformar.Visible = true;
            LblInformar.ForeColor = Color.Green;
            LblInformar.Text = "GANASTE, FELICITACIONES";

        }
        public void Perder()
        {
            mp3.URL = Application.StartupPath + @"\MP3\Error 1.mp3";
            LblInformar.Visible = true;
            LblInformar.Text = "PERDISTE";
            LblInformar.ForeColor = Color.Red;
        }
        public void Volver()
        {
            PMateria1.Visible = false;
            PTercerGrado.Visible = false;
            PMatematica.Visible = false;
            PIngles.Visible = false;
            PLengua.Visible = false;
            PCNaturales.Visible = false;
            PCSociales1.Visible = false;
            GbEvaluar.Visible = false;
            
        }

        public void error3grado()
        {
            MessageBox.Show("VERSION BETA: CONTIENE TODOS LOS JUEGO DE PRIMER GRADO E INGLES DE TERCER GRADO", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
        //No Sirve
        private void LblPregunta_Click(object sender, EventArgs e)
        {

        }
        private void LblPreguntaCN_Click(object sender, EventArgs e)
        {

        }
        private void LblB_Click(object sender, EventArgs e)
        {

        }
        private void LblInformar_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void PbIngles_Click(object sender, EventArgs e)
        {

        }
        private void LbCN1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void TxtEL_TextChanged(object sender, EventArgs e)
        {

        }
        private void TxtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblA_Click(object sender, EventArgs e)
        {

        }
        private void TxtResultado_TextChanged(object sender, EventArgs e)
        {

        }
       
    }
}
