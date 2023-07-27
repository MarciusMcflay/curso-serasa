using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Aula1
{
    public partial class FrmMarcius : Form
    {
        public FrmMarcius()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;

            string dataNascimento = dpDataNascimento.Value.ToString("yyyy-MM-dd");
            DateTime today = DateTime.Now;
            DateTime birthDate = dpDataNascimento.Value;
            int age = (int)((today - birthDate).TotalDays / 365.25);

            string sexo = cbSexo.SelectedItem.ToString();

            string[] skills = new string[ltSkills.Items.Count];
            string mSkills = "";
            for (int i = 0; i < ltSkills.Items.Count; i++)
            {
                skills[i] = ltSkills.Items[i].ToString();
                mSkills += skills[i] + ", ";
            }

            string pretencao = "";
            if (rbJunior.Checked){
                pretencao = "Junior";
            }else if (rbPleno.Checked){
                pretencao = "Pleno";
            } else if (rbSenior.Checked){
                pretencao = "Senior";
            } else {
                MessageBox.Show("Selecione uma pretenção");
                return;
            }

            MessageBox.Show("Dados salvos: "+name+"\n"
                + "Nasceu: "+dataNascimento + " com: "+age+" anos\n"
                + "do sexo:"+sexo+"\n"
                + "com as habilidades:" + mSkills + "\n"
                + "pretenção:" + pretencao + "\n"
            );
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tbskill_MouseClick(object sender, MouseEventArgs e)
        {
            string skill = tbskill.Text;
            for (int i = 0; i < ltSkills.Items.Count; i++)
            {
                string pega = ltSkills.Items[i].ToString();
                if(pega == skill)
                {
                    MessageBox.Show("Ja tem");
                    return;
                }
            }
            ltSkills.Items.Add(skill);
            tbskill.Text = "";
        }

        private void tbEmail_Validated(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            Regex regex = new Regex(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$");
            if (!regex.IsMatch(email))
            {
                MessageBox.Show("Email inválido");
                tbEmail.BackColor = Color.Red;
            }
        }

        private void pbPass_Click(object sender, EventArgs e)
        {
            if (tbPass.PasswordChar == '*')
            {
                tbPass.PasswordChar = '\0'; // Mostrar a senha
                pbPass.Image = Image.FromFile(@"..\..\Images\view.png");
            }
            else
            {
                tbPass.PasswordChar = '*'; // Ocultar a senha
                pbPass.Image = Image.FromFile(@"..\..\Images\hide.png"); 
            }
        }
    }
}
