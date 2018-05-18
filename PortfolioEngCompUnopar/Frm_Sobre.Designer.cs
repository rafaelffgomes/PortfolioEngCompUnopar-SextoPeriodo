namespace PortfolioEngCompUnopar
{
    partial class Frm_Sobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Sobre));
            this.Pnl1 = new System.Windows.Forms.Panel();
            this.Pb1 = new System.Windows.Forms.PictureBox();
            this.Label_Sobre_Integrantes = new System.Windows.Forms.Label();
            this.Label_Sobre = new System.Windows.Forms.Label();
            this.Pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl1
            // 
            this.Pnl1.BackColor = System.Drawing.Color.White;
            this.Pnl1.Controls.Add(this.Pb1);
            this.Pnl1.Location = new System.Drawing.Point(0, 0);
            this.Pnl1.Name = "Pnl1";
            this.Pnl1.Size = new System.Drawing.Size(438, 104);
            this.Pnl1.TabIndex = 0;
            // 
            // Pb1
            // 
            this.Pb1.Image = ((System.Drawing.Image)(resources.GetObject("Pb1.Image")));
            this.Pb1.Location = new System.Drawing.Point(160, 2);
            this.Pb1.Name = "Pb1";
            this.Pb1.Size = new System.Drawing.Size(118, 101);
            this.Pb1.TabIndex = 0;
            this.Pb1.TabStop = false;
            // 
            // Label_Sobre_Integrantes
            // 
            this.Label_Sobre_Integrantes.AutoSize = true;
            this.Label_Sobre_Integrantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Sobre_Integrantes.Location = new System.Drawing.Point(10, 172);
            this.Label_Sobre_Integrantes.Name = "Label_Sobre_Integrantes";
            this.Label_Sobre_Integrantes.Size = new System.Drawing.Size(364, 120);
            this.Label_Sobre_Integrantes.TabIndex = 5;
            this.Label_Sobre_Integrantes.Text = "Integrantes do Grupo:\r\n\r\nRAFAEL FIGUEIREDO FERREIRA GOMES\r\nMARCOS FONSECA DE MOUR" +
    "A\r\nJOSÉ RAIMUNDO ALVES\r\nJHONATA DA SILVA RAMOS";
            // 
            // Label_Sobre
            // 
            this.Label_Sobre.AutoSize = true;
            this.Label_Sobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Sobre.Location = new System.Drawing.Point(10, 110);
            this.Label_Sobre.Name = "Label_Sobre";
            this.Label_Sobre.Size = new System.Drawing.Size(419, 40);
            this.Label_Sobre.TabIndex = 4;
            this.Label_Sobre.Text = "Portfólio de Engenharia da Computação - UNOPAR\r\n6º Período";
            this.Label_Sobre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Frm_Sobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 300);
            this.Controls.Add(this.Label_Sobre_Integrantes);
            this.Controls.Add(this.Label_Sobre);
            this.Controls.Add(this.Pnl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Sobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            this.Pnl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl1;
        private System.Windows.Forms.PictureBox Pb1;
        private System.Windows.Forms.Label Label_Sobre_Integrantes;
        private System.Windows.Forms.Label Label_Sobre;
    }
}