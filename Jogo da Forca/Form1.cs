using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Forca
{
    public partial class frmMenuu : Form
    {
        public frmMenuu()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCréditos_Click(object sender, EventArgs e)
        {
            
            Creditos frmCred = new Creditos();

            frmCred.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jogo frmJogar = new Jogo();

            frmJogar.ShowDialog();
        }
    }
}
