﻿using System;
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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnJardin_Click(object sender, EventArgs e)
        {

        }

        private void BtnPrimaria_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmJuego frm = new FrmJuego();
            frm.ShowDialog();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
