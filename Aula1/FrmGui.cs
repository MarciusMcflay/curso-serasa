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
    public partial class FrmGui : Form
    {
        public FrmGui()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string datanascimento = dTPBirthDate.Value.ToString("yyyy-MM-dd");
            


        }
    }
}
