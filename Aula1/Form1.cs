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

        private void Matheus_Click(object sender, EventArgs e)
        {
            lblName.Text = "Matheus Bertolote";
            Form frmMatheusBertolote = new frmMatheusBertolote();
            // Coloquei o novo formulário no código. O "new" significa novo e coloquei através de um objeto que tem todas as ações, e o objeto foi colocado em uma variável. O frmMatheusBertolote é uma variável que precisa ser carregada por isso ela está declarada.
            // Tela criada através do código

            frmMatheusBertolote.WindowState = FormWindowState.Maximized;
            //WindowState pega o status da minha janela, ela guarda o status que ela está. O maximized significa que a janela vai abrir no máximo sem mudar os botões e outras ferramentas

            frmMatheusBertolote.Show();
            // Mostrar o formulário na tela através do "show"
            
            
        }
    }
}
