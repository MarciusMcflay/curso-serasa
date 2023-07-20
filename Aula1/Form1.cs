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
            string[] vetorDeAPIs = new string[3];

            vetorDeAPIs[0] = "API 1";
            vetorDeAPIs[1] = "API 2";
            vetorDeAPIs[2] = "API 3";

            string textoAPIs = "";
            for (int i = 0; i < vetorDeAPIs.Length; i++)
            {
                textoAPIs += vetorDeAPIs[i] + "\n";
            }

            lblAPIs.Text = textoAPIs;
        }

        private void btnGabriel_Click(object sender, EventArgs e)
        {
            lblName.Text = "Gabriel";
        }
    }
}
