
namespace Aula1
{
    partial class FrmBia
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
            this.dTPDNascimento = new System.Windows.Forms.DateTimePicker();
            this.dTPBDate = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dTPDNascimento
            // 
            this.dTPDNascimento.Location = new System.Drawing.Point(151, 18);
            this.dTPDNascimento.Name = "dTPDNascimento";
            this.dTPDNascimento.Size = new System.Drawing.Size(226, 20);
            this.dTPDNascimento.TabIndex = 0;
            // 
            // dTPBDate
            // 
            this.dTPBDate.AutoSize = true;
            this.dTPBDate.Location = new System.Drawing.Point(40, 18);
            this.dTPBDate.Name = "dTPBDate";
            this.dTPBDate.Size = new System.Drawing.Size(105, 13);
            this.dTPBDate.TabIndex = 1;
            this.dTPBDate.Text = "Data de nascimento:";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(83, 62);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(35, 13);
            this.lblDataNascimento.TabIndex = 2;
            this.lblDataNascimento.Text = "label1";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(553, 366);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 36);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // FrmBia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 414);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.dTPBDate);
            this.Controls.Add(this.dTPDNascimento);
            this.Name = "FrmBia";
            this.Text = "Cadastro do Curriculum da Beatriz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dTPDNascimento;
        private System.Windows.Forms.Label dTPBDate;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Button btnCadastrar;
    }
}