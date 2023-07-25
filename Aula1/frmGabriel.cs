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
    public partial class frmGabriel : Form
    {
        public frmGabriel()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string datanascimento = dTPDataNascimento.Value.ToString("yyyy/MM/dd");
            lblDataNascimento.Text = datanascimento;
        }
    }
}
