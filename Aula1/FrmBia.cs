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
    public partial class FrmBia : Form
    {
        public FrmBia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string dataNascimento = dTPDNascimento.Value.ToString("yyyy-MM-dd");
            lblDataNascimento.Text = dataNascimento;

        }
    }
}
