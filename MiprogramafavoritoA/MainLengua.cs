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
    public partial class MainLengua : Form
    {
        public MainLengua()
        {
            InitializeComponent();
        }

        private void btnCigarra_Click(object sender, EventArgs e)
        {
            MenuLengua frmlengua = new MenuLengua();
            frmlengua.ShowDialog();
            

        }
    }
}
