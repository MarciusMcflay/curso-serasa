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
    public partial class frmMatheusBertolote : Form
    {
        public frmMatheusBertolote()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            string DatadeNascimento = Date.Value.ToString("yyyy-MM-dd");
            // Criei uma string chamada data de nascimento, onde a data vai ser convertida em string. Como string é uma função é necessário(). "YYYY" significa 4 digitos em questão do ano. "MM" significa o mês em 2 digítos. "dd" significa dias em 2 digítos
            this.DatadeNascimento.Text = DatadeNascimento;
        }
    }
}
