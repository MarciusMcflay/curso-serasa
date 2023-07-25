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
    public partial class FormLuis : Form
    {
        public FormLuis()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string dataNascimento = dTPBDate.Value.ToString("yyyy-MM-dd");
            lblDataAniversario.Text = dataNascimento;
        }
    }
}
