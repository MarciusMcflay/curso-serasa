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

        private void btnMicael_Click(object sender, EventArgs e)
        {
            lblName.Text = "Micael Nunes";
            Form frmMicael = new frmMicael();
            frmMicael.WindowState = FormWindowState.Maximized;
            frmMicael.Show();
        }
    }
}
