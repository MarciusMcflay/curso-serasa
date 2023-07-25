
namespace Aula1
{
    partial class FrmMatheusCamargo
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
            this.dTPDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.dTPBithDate = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dTPDataNascimento
            // 
            this.dTPDataNascimento.Location = new System.Drawing.Point(193, 151);
            this.dTPDataNascimento.Name = "dTPDataNascimento";
            this.dTPDataNascimento.Size = new System.Drawing.Size(303, 20);
            this.dTPDataNascimento.TabIndex = 0;
            this.dTPDataNascimento.Value = new System.DateTime(2005, 2, 18, 0, 0, 0, 0);
            // 
            // dTPBithDate
            // 
            this.dTPBithDate.AutoSize = true;
            this.dTPBithDate.Location = new System.Drawing.Point(38, 158);
            this.dTPBithDate.Name = "dTPBithDate";
            this.dTPBithDate.Size = new System.Drawing.Size(104, 13);
            this.dTPBithDate.TabIndex = 1;
            this.dTPBithDate.Text = "Data de Nascimento";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(284, 240);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(121, 40);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(90, 229);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(35, 13);
            this.lblDataNascimento.TabIndex = 3;
            this.lblDataNascimento.Text = "label1";
            // 
            // FrmMatheusCamargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dTPBithDate);
            this.Controls.Add(this.dTPDataNascimento);
            this.Name = "FrmMatheusCamargo";
            this.Text = "Cadastro do Curricullum do Matheus Camargo";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dTPDataNascimento;
        private System.Windows.Forms.Label dTPBithDate;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblDataNascimento;
    }
}