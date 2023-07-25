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
    public partial class FrmFernanda : Form
    {
        public FrmFernanda()
        {
            InitializeComponent();
        }

        private void FrmFernanda_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string dataNascimento = dTPBDate.Value.ToString("yyyy/MM/dd");
            label2.Text = dataNascimento;
        }
    }
}
