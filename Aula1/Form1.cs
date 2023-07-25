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
            Form frmMarcius = new FrmMarcius();
            frmMarcius.WindowState = FormWindowState.Maximized;
            frmMarcius.Show();
        }

        private void btnAnaC_Click(object sender, EventArgs e)
        {
            lblName.Text = "Ana Carolina";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblName.Text = "Alana";
        }

        private void btnSara_Click(object sender, EventArgs e)
        {
            Form frmSara = new FrmSara();
            frmSara.WindowState = FormWindowState.Maximized;
            frmSara.Show();
        }
    }
}
