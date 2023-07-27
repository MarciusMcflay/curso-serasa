
namespace Aula1
{
    partial class FrmMarcius
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.curriculumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ltSkills = new System.Windows.Forms.ListBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbskill = new System.Windows.Forms.TextBox();
            this.rbJunior = new System.Windows.Forms.RadioButton();
            this.rbPleno = new System.Windows.Forms.RadioButton();
            this.rbSenior = new System.Windows.Forms.RadioButton();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.pbPass = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).BeginInit();
            this.SuspendLayout();
            // 
            // dpDataNascimento
            // 
            this.dpDataNascimento.Location = new System.Drawing.Point(165, 112);
            this.dpDataNascimento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpDataNascimento.Name = "dpDataNascimento";
            this.dpDataNascimento.Size = new System.Drawing.Size(200, 22);
            this.dpDataNascimento.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data de nascimento:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(1332, 641);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(97, 23);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.curriculumToolStripMenuItem,
            this.configuraçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1531, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.alunoToolStripMenuItem,
            this.professorToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.alunoToolStripMenuItem.Text = "Aluno";
            // 
            // professorToolStripMenuItem
            // 
            this.professorToolStripMenuItem.Name = "professorToolStripMenuItem";
            this.professorToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.professorToolStripMenuItem.Text = "Professor";
            // 
            // curriculumToolStripMenuItem
            // 
            this.curriculumToolStripMenuItem.Name = "curriculumToolStripMenuItem";
            this.curriculumToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.curriculumToolStripMenuItem.Text = "Curriculum";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // ltSkills
            // 
            this.ltSkills.FormattingEnabled = true;
            this.ltSkills.ItemHeight = 16;
            this.ltSkills.Location = new System.Drawing.Point(165, 241);
            this.ltSkills.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ltSkills.Name = "ltSkills";
            this.ltSkills.Size = new System.Drawing.Size(200, 84);
            this.ltSkills.TabIndex = 5;
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Não Definido"});
            this.cbSexo.Location = new System.Drawing.Point(165, 160);
            this.cbSexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(200, 24);
            this.cbSexo.TabIndex = 6;
            this.cbSexo.Text = "sexo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sexo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Soft skill:";
            // 
            // tbskill
            // 
            this.tbskill.Location = new System.Drawing.Point(165, 210);
            this.tbskill.Margin = new System.Windows.Forms.Padding(4);
            this.tbskill.Name = "tbskill";
            this.tbskill.Size = new System.Drawing.Size(200, 22);
            this.tbskill.TabIndex = 9;
            this.tbskill.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbskill_MouseClick);
            // 
            // rbJunior
            // 
            this.rbJunior.AutoSize = true;
            this.rbJunior.Checked = true;
            this.rbJunior.Location = new System.Drawing.Point(9, 52);
            this.rbJunior.Margin = new System.Windows.Forms.Padding(4);
            this.rbJunior.Name = "rbJunior";
            this.rbJunior.Size = new System.Drawing.Size(64, 21);
            this.rbJunior.TabIndex = 10;
            this.rbJunior.TabStop = true;
            this.rbJunior.Text = "junior";
            this.rbJunior.UseVisualStyleBackColor = true;
            // 
            // rbPleno
            // 
            this.rbPleno.AutoSize = true;
            this.rbPleno.Location = new System.Drawing.Point(92, 52);
            this.rbPleno.Margin = new System.Windows.Forms.Padding(4);
            this.rbPleno.Name = "rbPleno";
            this.rbPleno.Size = new System.Drawing.Size(64, 21);
            this.rbPleno.TabIndex = 11;
            this.rbPleno.Text = "pleno";
            this.rbPleno.UseVisualStyleBackColor = true;
            // 
            // rbSenior
            // 
            this.rbSenior.AutoSize = true;
            this.rbSenior.Location = new System.Drawing.Point(202, 52);
            this.rbSenior.Margin = new System.Windows.Forms.Padding(4);
            this.rbSenior.Name = "rbSenior";
            this.rbSenior.Size = new System.Drawing.Size(68, 21);
            this.rbSenior.TabIndex = 12;
            this.rbSenior.Text = "senior";
            this.rbSenior.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(165, 64);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 22);
            this.tbName.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nome Completo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbJunior);
            this.groupBox1.Controls.Add(this.rbPleno);
            this.groupBox1.Controls.Add(this.rbSenior);
            this.groupBox1.Location = new System.Drawing.Point(54, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretenção";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(653, 61);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(200, 22);
            this.tbEmail.TabIndex = 19;
            this.tbEmail.Validated += new System.EventHandler(this.tbEmail_Validated);
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(653, 112);
            this.tbPass.Margin = new System.Windows.Forms.Padding(4);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(200, 22);
            this.tbPass.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(593, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Senha:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(578, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Telefone:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(652, 160);
            this.maskedTextBox1.Mask = "(00) 00000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(201, 22);
            this.maskedTextBox1.TabIndex = 24;
            // 
            // pbPass
            // 
            this.pbPass.Image = global::Aula1.Properties.Resources.hide;
            this.pbPass.Location = new System.Drawing.Point(891, 112);
            this.pbPass.Name = "pbPass";
            this.pbPass.Size = new System.Drawing.Size(23, 21);
            this.pbPass.TabIndex = 22;
            this.pbPass.TabStop = false;
            this.pbPass.Click += new System.EventHandler(this.pbPass_Click);
            // 
            // FrmMarcius
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 726);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbPass);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbskill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.ltSkills);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dpDataNascimento);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMarcius";
            this.Text = "Cadastro do Currilum do Professor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dpDataNascimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem curriculumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ListBox ltSkills;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbskill;
        private System.Windows.Forms.RadioButton rbJunior;
        private System.Windows.Forms.RadioButton rbPleno;
        private System.Windows.Forms.RadioButton rbSenior;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}