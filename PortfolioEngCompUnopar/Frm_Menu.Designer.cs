namespace PortfolioEngCompUnopar
{
    partial class Frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
            this.Bt_InserirValores = new System.Windows.Forms.Button();
            this.Bt_ProcessarImagens = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bt_InserirValores
            // 
            this.Bt_InserirValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_InserirValores.Location = new System.Drawing.Point(12, 12);
            this.Bt_InserirValores.Name = "Bt_InserirValores";
            this.Bt_InserirValores.Size = new System.Drawing.Size(313, 59);
            this.Bt_InserirValores.TabIndex = 0;
            this.Bt_InserirValores.Text = "Inserir Valores";
            this.Bt_InserirValores.UseVisualStyleBackColor = true;
            this.Bt_InserirValores.Click += new System.EventHandler(this.Bt_InserirValores_Click);
            // 
            // Bt_ProcessarImagens
            // 
            this.Bt_ProcessarImagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_ProcessarImagens.Location = new System.Drawing.Point(12, 85);
            this.Bt_ProcessarImagens.Name = "Bt_ProcessarImagens";
            this.Bt_ProcessarImagens.Size = new System.Drawing.Size(313, 59);
            this.Bt_ProcessarImagens.TabIndex = 1;
            this.Bt_ProcessarImagens.Text = "Processar Imagens";
            this.Bt_ProcessarImagens.UseVisualStyleBackColor = true;
            this.Bt_ProcessarImagens.Click += new System.EventHandler(this.Bt_ProcessarImagens_Click);
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 155);
            this.Controls.Add(this.Bt_ProcessarImagens);
            this.Controls.Add(this.Bt_InserirValores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bt_InserirValores;
        private System.Windows.Forms.Button Bt_ProcessarImagens;
    }
}

