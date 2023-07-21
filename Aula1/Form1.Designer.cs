
namespace Aula1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.btnProfessor = new System.Windows.Forms.Button();
            this.btnbruno_click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(208, 484);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            // 
            // btnProfessor
            // 
            this.btnProfessor.Location = new System.Drawing.Point(830, 478);
            this.btnProfessor.Margin = new System.Windows.Forms.Padding(2);
            this.btnProfessor.Name = "btnProfessor";
            this.btnProfessor.Size = new System.Drawing.Size(56, 19);
            this.btnProfessor.TabIndex = 1;
            this.btnProfessor.Text = "Professor";
            this.btnProfessor.UseVisualStyleBackColor = true;
            this.btnProfessor.Click += new System.EventHandler(this.btnProfessor_Click);
            // 
            // btnbruno_click
            // 
            this.btnbruno_click.Location = new System.Drawing.Point(830, 402);
            this.btnbruno_click.Name = "btnbruno_click";
            this.btnbruno_click.Size = new System.Drawing.Size(69, 27);
            this.btnbruno_click.TabIndex = 2;
            this.btnbruno_click.Text = "Bruno";
            this.btnbruno_click.UseVisualStyleBackColor = true;
            this.btnbruno_click.Click += new System.EventHandler(this.btnBruno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 554);
            this.Controls.Add(this.btnbruno_click);
            this.Controls.Add(this.btnProfessor);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnProfessor;
        private System.Windows.Forms.Button btnbruno_click;
    }
}

