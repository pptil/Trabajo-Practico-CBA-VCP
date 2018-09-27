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
    public partial class MenuLengua : Form
    {
        public MenuLengua()
        {
            InitializeComponent();
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            FormLengua frmlengua = new FormLengua();
            frmlengua.ShowDialog();
        }

        private void btnActivities_Click(object sender, EventArgs e)
        {
            FormActividades frmact = new FormActividades();
            frmact.ShowDialog();
        }
    }
}
