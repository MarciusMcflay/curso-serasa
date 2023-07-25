
namespace Aula1
{
    partial class FormGabrielly
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
            this.dTPBithDate = new System.Windows.Forms.DateTimePicker();
            this.lblNasc = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dTPBithDate
            // 
            this.dTPBithDate.Location = new System.Drawing.Point(125, 43);
            this.dTPBithDate.Name = "dTPBithDate";
            this.dTPBithDate.Size = new System.Drawing.Size(213, 20);
            this.dTPBithDate.TabIndex = 0;
            this.dTPBithDate.Value = new System.DateTime(2001, 2, 3, 20, 48, 0, 0);
            // 
            // lblNasc
            // 
            this.lblNasc.AutoSize = true;
            this.lblNasc.Location = new System.Drawing.Point(12, 50);
            this.lblNasc.Name = "lblNasc";
            this.lblNasc.Size = new System.Drawing.Size(107, 13);
            this.lblNasc.TabIndex = 1;
            this.lblNasc.Text = "Data de Nascimento:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(636, 388);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(131, 82);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(10, 13);
            this.lblNascimento.TabIndex = 3;
            this.lblNascimento.Text = ".";
            // 
            // FormGabrielly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblNasc);
            this.Controls.Add(this.dTPBithDate);
            this.Name = "FormGabrielly";
            this.Text = "Cadastro do Curriculo da Gabrielly";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dTPBithDate;
        private System.Windows.Forms.Label lblNasc;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblNascimento;
    }
}