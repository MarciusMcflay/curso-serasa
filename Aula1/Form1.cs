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
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            lblName.Text = "Marcius Leandro";
        }

        private void btnLuiza_Click(object sender, EventArgs e)
        {
            lblName.Text = "Luma";
           
            Form FrmLuiza = new FrmLuiza();
            FrmLuiza.WindowState = this.WindowState;
            FrmLuiza.Show();

        }
    }
}
