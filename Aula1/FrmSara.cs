using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1
{
    public partial class FrmSara : Form
    {
        public FrmSara()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string datadenascimento = dtpDatadeNascimento.Value.ToString("yyyy-MM-dd");
            lblDatadeNascimento.Text = datadenascimento;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtpDatadeNascimento_ValueChanged(object sender, EventArgs e)
        {




        }
    }
}
