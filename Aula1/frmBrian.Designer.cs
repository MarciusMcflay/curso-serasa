
namespace Aula1
{
    partial class frmBrian
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
            this.dTPBtirhDay = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.btnCadstr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dTPBtirhDay
            // 
            this.dTPBtirhDay.Location = new System.Drawing.Point(169, 51);
            this.dTPBtirhDay.Name = "dTPBtirhDay";
            this.dTPBtirhDay.Size = new System.Drawing.Size(213, 20);
            this.dTPBtirhDay.TabIndex = 0;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(12, 55);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(133, 16);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Data De Nascimento";
            // 
            // btnCadstr
            // 
            this.btnCadstr.Location = new System.Drawing.Point(672, 392);
            this.btnCadstr.Name = "btnCadstr";
            this.btnCadstr.Size = new System.Drawing.Size(75, 23);
            this.btnCadstr.TabIndex = 2;
            this.btnCadstr.Text = "button1";
            this.btnCadstr.UseVisualStyleBackColor = true;
            this.btnCadstr.Click += new System.EventHandler(this.btnCadstr_Click);
            // 
            // frmBrian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 450);
            this.Controls.Add(this.btnCadstr);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.dTPBtirhDay);
            this.Name = "frmBrian";
            this.Text = "Cadastro Curriculo Brian";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dTPBtirhDay;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnCadstr;
    }
}