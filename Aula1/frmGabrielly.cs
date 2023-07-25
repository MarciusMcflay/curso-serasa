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
    public partial class FormGabrielly : Form
    {
        public FormGabrielly()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string dataNascimento = dTPBithDate.Value.ToString("yyyy-MM-dd");
            lblNascimento.Text = dataNascimento;
        }
    }
}
