
namespace Aula1
{
    partial class FrmSara
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
            this.dtpDatadeNascimento = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblDatadeNascimento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpDatadeNascimento
            // 
            this.dtpDatadeNascimento.Location = new System.Drawing.Point(229, 82);
            this.dtpDatadeNascimento.Name = "dtpDatadeNascimento";
            this.dtpDatadeNascimento.Size = new System.Drawing.Size(200, 20);
            this.dtpDatadeNascimento.TabIndex = 0;
            this.dtpDatadeNascimento.ValueChanged += new System.EventHandler(this.dtpDatadeNascimento_ValueChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(534, 82);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblDatadeNascimento
            // 
            this.lblDatadeNascimento.AutoSize = true;
            this.lblDatadeNascimento.Location = new System.Drawing.Point(65, 92);
            this.lblDatadeNascimento.Name = "lblDatadeNascimento";
            this.lblDatadeNascimento.Size = new System.Drawing.Size(100, 13);
            this.lblDatadeNascimento.TabIndex = 2;
            this.lblDatadeNascimento.Text = "data de nascimento";
            this.lblDatadeNascimento.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmSara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDatadeNascimento);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtpDatadeNascimento);
            this.Name = "FrmSara";
            this.Text = "Cadastro curriculo sara ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDatadeNascimento;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblDatadeNascimento;
    }
}