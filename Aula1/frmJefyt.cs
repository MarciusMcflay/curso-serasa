﻿using System;
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
    public partial class frmJefyt : Form
    {
        public frmJefyt()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            string dataNascimento =  dTBdataNascimento.Value.ToString("yyyy-MM-dd");
            
        }
    }
}
