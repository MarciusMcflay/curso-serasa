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
    public partial class FMBruno : Form
    {
        public FMBruno()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            string dataNascimento = dTPDatadeNascimento.Value.ToString("yyyy-mm-dd");
            lblData.Text = dataNascimento;

        }

        private void dTPDatadeNascimento_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
