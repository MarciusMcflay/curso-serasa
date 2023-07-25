
namespace Aula1
{
    partial class FormLuis
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
            this.dTPBDate = new System.Windows.Forms.DateTimePicker();
            this.lblDataAniversario = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dTPBDate
            // 
            this.dTPBDate.Location = new System.Drawing.Point(164, 45);
            this.dTPBDate.Name = "dTPBDate";
            this.dTPBDate.Size = new System.Drawing.Size(276, 20);
            this.dTPBDate.TabIndex = 0;
            // 
            // lblDataAniversario
            // 
            this.lblDataAniversario.AutoSize = true;
            this.lblDataAniversario.Location = new System.Drawing.Point(33, 45);
            this.lblDataAniversario.Name = "lblDataAniversario";
            this.lblDataAniversario.Size = new System.Drawing.Size(106, 13);
            this.lblDataAniversario.TabIndex = 1;
            this.lblDataAniversario.Text = "Data De Nascimento";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(153, 139);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(87, 37);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // FormLuis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblDataAniversario);
            this.Controls.Add(this.dTPBDate);
            this.Name = "FormLuis";
            this.Text = "Form Luis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dTPBDate;
        private System.Windows.Forms.Label lblDataAniversario;
        private System.Windows.Forms.Button btnCadastrar;
    }
}