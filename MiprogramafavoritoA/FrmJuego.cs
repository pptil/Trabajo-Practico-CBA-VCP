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
    public partial class FrmJuego : Form
    {
        DataTable tblengua;
        DataTable tbmatematica;
        DataTable tbingles;
        DataTable tbcnaturales;
        DataTable tbcsociales;
        int codM, codI, C, I, codL, L, codCN, CN, codCS, CS ;
        string n1, n2, n3, n4, resuM, mjeboton, p1, p2;
        int tiempo, bandera;
        string l1, l2, l3, l4, l5, pl1;
        string cn1, cn2, cs1;

       
        
       

       
       
       
        //timer
        private void Trmje_Tick(object sender, EventArgs e)
        {
            progreso();
        }


        //Paneles
        private void PIngles_Paint(object sender, PaintEventArgs e)
        {
            PIngles.BackColor = Color.DarkGray;
            Ingles();
        }
        private void PLengua_Paint(object sender, PaintEventArgs e)
        {
            PLengua.BackColor = Color.DarkGray;
            lengua();
        }
        
        private void PMatematica_Paint(object sender, PaintEventArgs e)
        {
            PMatematica.BackColor = Color.DarkGray;
            Matematica();
        }
        private void PCNaturales_Paint(object sender, PaintEventArgs e)
        {
            PCNaturales.BackColor = Color.DarkGray;
            CNaturales();
        }

        //Botones

        private void BtnEvaluar_Click(object sender, EventArgs e)
        {
            
            BtnEvaluar.Enabled = false;
            tiempo = 0;
            progreso();
            if (bandera == 1)
                if (codM == 1 || codM == 2)
                {
                    if (TxtA.Text == n1 && TxtB.Text == n2 &&
                     TxtResultado.Text == resuM)
                    {

                        LblInformar.Visible = true;
                        LblInformar.ForeColor = Color.Green;
                        LblInformar.Text = "GANASTE, felicitaciones";

                    }
                    else
                    {
                        LblInformar.Visible = true;
                        LblInformar.Text = "PERDISTE";
                        LblInformar.ForeColor = Color.Red;
                    }
                }
                if (codM == 3 || codM == 4)
            {
                if (TxtA.Text == n1 && TxtB.Text == n2 && TxtC.Text == n3
                    && TxtD.Text == n4 && TxtResultado.Text == resuM)
                {
                    LblInformar.Visible = true;
                    LblInformar.Text = "GANASTE, felicitaciones";
                    LblInformar.ForeColor = Color.Green;
                }
                else
                {
                    LblInformar.Visible = true;
                    LblInformar.Text = "PERDISTE";
                    LblInformar.ForeColor = Color.Red;
                }
            }
            if (bandera == 2)
                switch (codI)
                {
                    case 1:

                        if (Cb3.Checked == true)
                        {
                            LblInformar.Visible = true;
                            LblInformar.Text = "GANASTE, felicitaciones";
                            LblInformar.ForeColor = Color.Green;
                        }
                        if (Cb3.Checked == false || Cb2.Checked == true || Cb1.Checked == true)
                        {
                            LblInformar.Visible = true;
                            LblInformar.Text = "PERDISTE";
                            LblInformar.ForeColor = Color.Red;
                        }

                        break;


                    case 2:
                        if (Cb1.Checked == true)
                        {
                            LblInformar.Visible = true;
                            LblInformar.Text = "GANASTE, felicitaciones";
                            LblInformar.ForeColor = Color.Green;
                        }
                        if (Cb1.Checked == false || Cb2.Checked == true || Cb3.Checked == true)
                        {
                            LblInformar.Visible = true;
                            LblInformar.Text = "PERDISTE";
                            LblInformar.ForeColor = Color.Red;

                        }


                        break;
                    case 3:
                        if (Cb2.Checked == true)
                        {
                            LblInformar.Visible = true;
                            LblInformar.Text = "GANASTE, felicitaciones";
                            LblInformar.ForeColor = Color.Green;
                        }
                        if (Cb2.Checked == false || Cb1.Checked == true || Cb3.Checked == true)
                        {
                            LblInformar.Visible = true;
                            LblInformar.Text = "PERDISTE";
                            LblInformar.ForeColor = Color.Red;
                        }

                        break;
                    case 4:
                        if (Cb2.Checked == true)
                        {
                            LblInformar.Visible = true;
                            LblInformar.Text = "GANASTE, felicitaciones";
                            LblInformar.ForeColor = Color.Green;
                        }
                        if (Cb2.Checked == false || Cb1.Checked == true || Cb3.Checked == true)
                        {
                            LblInformar.Visible = true;
                            LblInformar.Text = "PERDISTE";
                            LblInformar.ForeColor = Color.Red;
                        }

                        break;
                    case 5:
                        if (Cb3.Checked == true)
                        {
                            LblInformar.Visible = true;
                            LblInformar.Text = "GANASTE, felicitaciones";
                            LblInformar.ForeColor = Color.Green;
                        }
                        if (Cb3.Checked == false || Cb1.Checked == true || Cb2.Checked == true)
                        {
                            LblInformar.Visible = true;
                            LblInformar.Text = "PERDISTE";
                            LblInformar.ForeColor = Color.Red;
                        }

                        break;
                    case 6:
                        if (Cb1.Checked == true)
                        {
                            LblInformar.Visible = true;
                            LblInformar.Text = "GANASTE, felicitaciones";
                            LblInformar.ForeColor = Color.Green;
                        }
                        if (Cb1.Checked == false || Cb2.Checked == true || Cb3.Checked == true)
                        {
                            LblInformar.Visible = true;
                            LblInformar.Text = "PERDISTE";
                            LblInformar.ForeColor = Color.Red;
                        }

                        break;
                }
            if (bandera == 3)
            {
                if (codL == 1 || codL == 2)
                {
                    //l1, l2, l3,l4,l5
                    if (TxtAL.Text == l1 && TxtBL.Text == l2)
                    {
                        LblInformar.Visible = true;
                        LblInformar.ForeColor = Color.Green;
                        LblInformar.Text = "GANASTE, felicitaciones";
                    }
                    else
                    {
                        LblInformar.Visible = true;
                        LblInformar.Text = "PERDISTE";
                        LblInformar.ForeColor = Color.Red;
                    }
                }
                if (codL == 3 || codL == 4)
                {
                    if (TxtAL.Text == l1 && TxtBL.Text == l2 && TxtCL.Text == l3)
                    {
                        LblInformar.Visible = true;
                        LblInformar.ForeColor = Color.Green;
                        LblInformar.Text = "GANASTE, felicitaciones";
                    }
                    else
                    {
                        LblInformar.Visible = true;
                        LblInformar.Text = "PERDISTE";
                        LblInformar.ForeColor = Color.Red;
                    }
                }
                if (codL == 5 || codL == 6)
                {
                    if (TxtAL.Text == l1 && TxtBL.Text == l2 && TxtCL.Text == l3 && TxtD.Text == l4)
                    {
                        LblInformar.Visible = true;
                        LblInformar.ForeColor = Color.Green;
                        LblInformar.Text = "GANASTE, felicitaciones";
                    }
                    else
                    {
                        LblInformar.Visible = true;
                        LblInformar.Text = "PERDISTE";
                        LblInformar.ForeColor = Color.Red;
                    }
                }
            }
            if(bandera==4)
            {
                switch (codCN)
                {
                    case 1:
                    if(LbCN1.SelectedIndex==0)
                        {
                            LblInformar.Visible = true;
                            LblInformar.ForeColor = Color.Green;
                            LblInformar.Text = "GANASTE, FELICITACIONES";
                        }
                        else
                        {
                            LblInformar.Visible = true;
                            LblInformar.Text = "PERDISTE";
                            LblInformar.ForeColor = Color.Red;
                        }
                        break;
                case 2:
                        if (LbCN1.SelectedIndex == 1)
                        {
                            LblInformar.Visible = true;
                            LblInformar.ForeColor = Color.Green;
                            LblInformar.Text = "GANASTE, FELICITACIONES";
                        }
                        else
                        {
                            LblInformar.Visible = true;
                            LblInformar.Text = "PERDISTE";
                            LblInformar.ForeColor = Color.Red;
                        }
                        break;
                case 3:
                        if (LbCN1.SelectedIndex == 2)
                        {
                            LblInformar.Visible = true;
                            LblInformar.ForeColor = Color.Green;
                            LblInformar.Text = "GANASTE, FELICITACIONES";
                        }
                        else
                        {
                            LblInformar.Visible = true;
                            LblInformar.Text = "PERDISTE";
                            LblInformar.ForeColor = Color.Red;
                        }
                        break;
                 }

            }
            if (bandera==5)
            {
                switch (codCS)
                {
                    case 1:

                        if (RbCS13.Checked == true)
                        {
                            LblInformar.Visible = true;
                            LblInformar.Text = "GANASTE, felicitaciones";
                            LblInformar.ForeColor = Color.Green;
                        }
                        if (RbCS13.Checked == false || RbCS12.Checked == true || RbCS11.Checked == true)
                        {
                            LblInformar.Visible = true;
                            LblInformar.Text = "PERDISTE";
                            LblInformar.ForeColor = Color.Red;
                        }
                        break;
                    case 2:

                        if (RbCS12.Checked == true)
                        {
                            LblInformar.Visible = true;
                            LblInformar.Text = "GANASTE, felicitaciones";
                            LblInformar.ForeColor = Color.Green;
                        }
                        if (RbCS12.Checked == false || RbCS13.Checked == true || RbCS11.Checked == true)
                        {
                            LblInformar.Visible = true;
                            LblInformar.Text = "PERDISTE";
                            LblInformar.ForeColor = Color.Red;
                        }
                        break;
                    case 3:

                        if (RbCS13.Checked == true)
                        {
                            LblInformar.Visible = true;
                            LblInformar.Text = "GANASTE, felicitaciones";
                            LblInformar.ForeColor = Color.Green;
                        }
                        if (RbCS13.Checked == false || RbCS12.Checked == true || RbCS11.Checked == true)
                        {
                            LblInformar.Visible = true;
                            LblInformar.Text = "PERDISTE";
                            LblInformar.ForeColor = Color.Red;
                        }
                        break;
                    case 4:

                        if (RbCS11.Checked == true)
                        {
                            LblInformar.Visible = true;
                            LblInformar.Text = "GANASTE, felicitaciones";
                            LblInformar.ForeColor = Color.Green;
                        }
                        if (RbCS11.Checked == false || RbCS12.Checked == true || RbCS13.Checked == true)
                        {
                            LblInformar.Visible = true;
                            LblInformar.Text = "PERDISTE";
                            LblInformar.ForeColor = Color.Red;
                        }
                        break;
                    case 5:

                        if (RbCS11.Checked == true)
                        {
                            LblInformar.Visible = true;
                            LblInformar.Text = "GANASTE, felicitaciones";
                            LblInformar.ForeColor = Color.Green;
                        }
                        if (RbCS11.Checked == false || RbCS12.Checked == true || RbCS13.Checked == true)
                        {
                            LblInformar.Visible = true;
                            LblInformar.Text = "PERDISTE";
                            LblInformar.ForeColor = Color.Red;
                        }
                        break;
                }
            }

            Trmje.Enabled = true;

        }

        private void PCSociales1_Paint(object sender, PaintEventArgs e)
        {
            PCSociales1.BackColor = Color.DarkGray;
            csociales();
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
        }

        private void BtnSegundoG_Click(object sender, EventArgs e)
        {
            PIngles.Visible = true;
            PMatematica.Visible = false;
            PLengua.Visible = false;
            GbEvaluar.Visible = true;
        }
        private void BtnMatematica1_Click(object sender, EventArgs e)
        {
            PMatematica.Visible = true;
            PIngles.Visible = false;
            PLengua.Visible = false;
            PCNaturales.Visible = false;
            PCSociales1.Visible = false;
            GbEvaluar.Visible = true;
        }

        private void BtnLengua1_Click(object sender, EventArgs e)
        {
            PLengua.Visible = true;
            PIngles.Visible = false;
            PMatematica.Visible = false;
            PCNaturales.Visible = false;
            PCSociales1.Visible = false;
            GbEvaluar.Visible = true;

        }

        private void BtnCNaturales1_Click(object sender, EventArgs e)
        {
            PLengua.Visible = false;
            PIngles.Visible = false;
            PMatematica.Visible = false;
            PCNaturales.Visible = true;
            PCSociales1.Visible = false;
            GbEvaluar.Visible = true;
        }
        private void BtnTercerG_Click(object sender, EventArgs e)
        {

        }

        private void BTnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu frm = new FrmMenu();
            frm.ShowDialog();
            this.Close();

        }

        private void BtenVolver1_Click(object sender, EventArgs e)
        {
            PMateria1.Visible = false;
            PMatematica.Visible = false;
            PIngles.Visible = false;
            PLengua.Visible = false;
            PCNaturales.Visible = false;
            PCSociales1.Visible = false;
            GbEvaluar.Visible = false;
        }


        // metedos del form
        public FrmJuego()
        {
            InitializeComponent();
            
        }

        private void FrmJuego_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location; this.Size = Screen.PrimaryScreen.WorkingArea.Size;
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
        }

        //metodos creados
        private void progreso()
        {
            if (bandera == 1)
            {
                mjeboton = tiempo.ToString();
                BtnEvaluar.Text = mjeboton;
                tiempo++;
                if (tiempo == 20)
                {
                    TxtA.Text = "";
                    TxtB.Text = "";
                    TxtC.Text = "";
                    TxtD.Text = "";
                    TxtResultado.Text = "";
                    C++;
                    Matematica();
                    BtnEvaluar.Enabled = true;
                    BtnEvaluar.Text = "¡Evaluar!";
                    Trmje.Enabled = false;
                    LblInformar.Visible = false;
                    Trmje.Stop();
                }
            }

            if (bandera == 2)
            {
                mjeboton = tiempo.ToString();
                BtnEvaluar.Text = mjeboton;
                tiempo++;
                if (tiempo == 20)
                {

                    Cb1.Checked = false;
                    Cb2.Checked = false;
                    Cb3.Checked = false;
                    I++;
                    Ingles();
                    BtnEvaluar.Text = "¡Evaluar!";
                    BtnEvaluar.Enabled = true;
                    Trmje.Enabled = false;
                    LblInformar.Visible = false;
                    Trmje.Stop();
                }
            }
            if (bandera == 3)
            {
                mjeboton = tiempo.ToString();
                BtnEvaluar.Text = mjeboton;
                tiempo++;
                if (tiempo == 20)
                {

                    TxtAL.Text = "";
                    TxtBL.Text = "";
                    TxtCL.Text = "";
                    TxtDL.Text = "";
                    TxtEL.Text = "";
                    L++;
                    lengua();
                    BtnEvaluar.Enabled = true;
                    BtnEvaluar.Text = "¡Evaluar!";
                    Trmje.Enabled = false;
                    LblInformar.Visible = false;
                    Trmje.Stop();
                }
            }
            if (bandera == 4)
            {
                mjeboton = tiempo.ToString();
                BtnEvaluar.Text = mjeboton;
                tiempo++;
                if (tiempo == 20)
                {

                    LbCN1.ClearSelected() ;
                    CN++;
                    CNaturales();
                    BtnEvaluar.Text = "¡Evaluar!";
                    BtnEvaluar.Enabled = true;
                    Trmje.Enabled = false;
                    LblInformar.Visible = false;
                    Trmje.Stop();
                }
            }
            if (bandera == 5)
            {
                mjeboton = tiempo.ToString();
                BtnEvaluar.Text = mjeboton;
                tiempo++;
                if (tiempo == 20)
                {
                RbCS11.Checked = false;
                RbCS12.Checked = false;
                RbCS13.Checked = false;
                CS++;
                csociales();
                BtnEvaluar.Text = "¡Evaluar!";
                BtnEvaluar.Enabled = true;
                Trmje.Enabled = false;
                LblInformar.Visible = false;
                Trmje.Stop();
                }
                
            }
        }

        // Metodos mios
        public void Matematica()
        {

            // primer grado
            /* 1) Carlito esta feliz porque su papa le regalo 3 caramelos 
             * (Imagenes de caramelos),y su mama le compo 5 mas() image de caramelo
             * Cuanto caramelos tiene ahora? x+y=R
             */
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
            FTM1[1] = "Carlito esta feliz por que su papa le regalo 3 caramelos, y su mama le compró 5 mas.\n¿Cuanto caramelos tiene ahora?";
            FTM1[2] = "3";
            FTM1[3] = "5";
            FTM1[4] = "0";
            FTM1[5] = "0";
            FTM1[6] = "8";
            tbmatematica.Rows.Add(FTM1);
            DataRow FTM2 = tbmatematica.NewRow();
            FTM2[0] = "2";
            FTM2[1] = "Lisa tiene 4 hermosas flores, decidio regalar 2 a su abuela.\n¿Cuantas flores le quedaron?";
            FTM2[2] = "4";
            FTM2[3] = "2";
            FTM2[4] = "0";
            FTM2[5] = "0";
            FTM2[6] = "2";
            tbmatematica.Rows.Add(FTM2);
            DataRow FTM3 = tbmatematica.NewRow();
            FTM3[0] = "3";
            FTM3[1] = "10 niños y 10 niñas prarticipan en un maraton, 4 niñas y 1 niño no llegaron a la meta.\n¿cuantos acabaron la carrera?";
            FTM3[2] = "10";
            FTM3[3] = "10";
            FTM3[4] = "4";
            FTM3[5] = "1";
            FTM3[6] = "15";
            tbmatematica.Rows.Add(FTM3);
            DataRow FTM4 = tbmatematica.NewRow();
            FTM4[0] = "4";
            FTM4[1] = "tenemos en la heladera 8 bananas y 12 uva. Nos comemos las 8 bananas.\n¿cuantos acabaron la carrera?";
            FTM4[2] = "8";
            FTM4[3] = "12";
            FTM4[4] = "0";
            FTM4[5] = "0";
            FTM4[6] = "12";
            tbmatematica.Rows.Add(FTM4);

            //Agregar mas operaciones

            codM = int.Parse(tbmatematica.Rows[C][0].ToString());//LEE FILA Y COLUMNA 
            n1 = tbmatematica.Rows[C][2].ToString();
            n2 = tbmatematica.Rows[C][3].ToString();
            n3 = tbmatematica.Rows[C][4].ToString();
            n4 = tbmatematica.Rows[C][5].ToString();
            resuM= tbmatematica.Rows[C][6].ToString();
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
                    LblB.Visible = true;
                    LblB.Text = "=";
                    LblC.Visible = false;
                    

                    break;

                case 2:
                    LblPregunta.Text = tbmatematica.Rows[C][1].ToString();
                    TxtA.Visible = true;
                    TxtB.Visible = true;
                    TxtC.Visible = false;
                    TxtD.Visible = false;
                    LblA.Visible = true;
                    LblA.Text = "-";
                    LblB.Visible = true;
                    LblB.Text = "=";
                    LblC.Visible = false;
                    

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
                   

                    break;
                case 4:
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

            codCN = Convert.ToInt32(tbcnaturales.Rows[CN][0].ToString());
            cn1 = tbcnaturales.Rows[CN][1].ToString();
            cn2 = tbcnaturales.Rows[CN][2].ToString();

            switch (codCN)
            {
                case 1:
                    LblPreguntaCN1.Text = cn1;
                    break;
                case 2:
                    LblPreguntaCN1.Text = cn1;
                    break;
                case 3:
                    LblPreguntaCN1.Text = cn1;
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

            codL=int.Parse(tblengua.Rows[L][0].ToString());
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
                    TxtAL.Enabled = false;
                    TxtCL.Visible = false;
                    TxtDL.Visible = false;
                    TxtEL.Visible = false;
                    LblL2.Visible = false;
                    LblL3.Visible = false;
                    LblL4.Visible = false;
                    break;
                case 2:
                    
                    LblPreguntaL.Text = pl1;
                    TxtAL.Enabled = true;
                    TxtBL.Text = l2;
                    TxtBL.Enabled = false;
                    TxtCL.Visible = false;
                    TxtDL.Visible = false;
                    TxtEL.Visible = false;
                    LblL2.Visible = false;
                    LblL3.Visible = false;
                    LblL4.Visible = false;
                    break;
                case 3:
                    LblPreguntaL.Text = pl1;
                    TxtAL.Enabled = true;
                    TxtBL.Enabled = true;
                    TxtCL.Visible = true;
                    TxtCL.Enabled = false;
                    TxtCL.Text = l3;
                    TxtDL.Visible = false;
                    TxtEL.Visible = false;
                    LblL2.Visible = true;
                    LblL3.Visible = false;
                    LblL4.Visible = false;
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


                    break;
                case 2:
                    LblPreguntaI.Text = p1;

                    Cb3.Text = tbingles.Rows[11][2].ToString();
                    Cb2.Text = tbingles.Rows[5][2].ToString();
                    Cb1.Text = p2;

                    break;
                case 3:
                    LblPreguntaI.Text = p1;
                    Cb1.Text = tbingles.Rows[11][2].ToString();
                    Cb2.Text = p2;
                    Cb3.Text = tbingles.Rows[5][2].ToString();


                    break;
                case 4:
                    LblPreguntaI.Text = p1;

                    Cb2.Text = p2;
                    Cb1.Text = tbingles.Rows[11][2].ToString();
                    Cb3.Text = tbingles.Rows[5][2].ToString();

                    break;
                case 5:
                    LblPreguntaI.Text = p1;

                    Cb3.Text = p2;
                    Cb1.Text = tbingles.Rows[11][2].ToString();
                    Cb2.Text = tbingles.Rows[0][2].ToString();

                    break;
                case 6:
                    LblPreguntaI.Text = p1;

                    Cb1.Text = p2;
                    Cb3.Text = tbingles.Rows[11][2].ToString();
                    Cb2.Text = tbingles.Rows[5][2].ToString();

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
            tbcsociales.Rows.Add(FTCS7);
            DataRow FTCS8 = tbcsociales.NewRow();
            FTCS8[0] = "8";
            FTCS8[1] = "MARINERO";
            tbcsociales.Rows.Add(FTCS8);

            codCS = int.Parse(tbcsociales.Rows[CS][0].ToString());
            cs1 = tbcsociales.Rows[CS][1].ToString();

            switch (codCS)
            {
                case 1:
                    LblPreguntaCS1.Text = cs1;
                    RbCS11.Text = tbcsociales.Rows[7][1].ToString();
                    RbCS12.Text = tbcsociales.Rows[5][1].ToString();
                    RbCS13.Text = cs1;
                    break;
                case 2:
                    LblPreguntaCS1.Text = cs1;
                    RbCS11.Text = tbcsociales.Rows[0][1].ToString();
                    RbCS13.Text = tbcsociales.Rows[4][1].ToString();
                    RbCS12.Text = cs1;
                    break;
                case 3:
                    LblPreguntaCS1.Text = cs1;
                    RbCS11.Text = tbcsociales.Rows[3][1].ToString();
                    RbCS12.Text = tbcsociales.Rows[6][1].ToString();
                    RbCS13.Text = cs1;
                    break;
                case 4:
                    LblPreguntaCS1.Text = cs1;
                    RbCS13.Text = tbcsociales.Rows[7][1].ToString();
                    RbCS12.Text = tbcsociales.Rows[1][1].ToString();
                    RbCS11.Text = cs1;
                    break;
                case 5:
                    LblPreguntaCS1.Text = cs1;
                    RbCS13.Text = tbcsociales.Rows[2][1].ToString();
                    RbCS12.Text = tbcsociales.Rows[3][1].ToString();
                    RbCS11.Text = cs1;
                    break;
            }
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

    }
}
