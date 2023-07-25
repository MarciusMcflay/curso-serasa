
namespace Aula1
{
    partial class frmMatheusBertolote
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
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.Birth = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.DatadeNascimento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(214, 103);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(226, 20);
            this.Date.TabIndex = 0;
            this.Date.Value = new System.DateTime(2023, 7, 24, 20, 56, 46, 0);
            // 
            // Birth
            // 
            this.Birth.AutoSize = true;
            this.Birth.Location = new System.Drawing.Point(73, 109);
            this.Birth.Name = "Birth";
            this.Birth.Size = new System.Drawing.Size(107, 13);
            this.Birth.TabIndex = 1;
            this.Birth.Text = "Data de Nascimento:";
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(229, 188);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(75, 23);
            this.Register.TabIndex = 2;
            this.Register.Text = "Cadastrar";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // DatadeNascimento
            // 
            this.DatadeNascimento.AutoSize = true;
            this.DatadeNascimento.Location = new System.Drawing.Point(482, 110);
            this.DatadeNascimento.Name = "DatadeNascimento";
            this.DatadeNascimento.Size = new System.Drawing.Size(35, 13);
            this.DatadeNascimento.TabIndex = 3;
            this.DatadeNascimento.Text = "label1";
            // 
            // frmMatheusBertolote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DatadeNascimento);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Birth);
            this.Controls.Add(this.Date);
            this.Name = "frmMatheusBertolote";
            this.Text = "Cadastro do Currículo Matheus Bertolote ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Label Birth;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Label DatadeNascimento;
    }
}