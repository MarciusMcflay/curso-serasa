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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            lblName.Text = "Marcius Leandro";
        }


        private void btnFernanda_Click_1(object sender, EventArgs e)
        {
            lblName.Text = "Fernanda Souza";
            Form FrmFernanda = new FrmFernanda();
            //declaramos uma variavel com o nome de FrmFernanda

            FrmFernanda.Show();
            //para abrir o segundo forms usamos esse modelo acima

            FrmFernanda.WindowState = FormWindowState.Maximized; 
            //É somente para ter um tamanho "padrão" já definido pelo programador.
        }
    }
}
