namespace PortfolioEngCompUnopar
{
    partial class Frm_ProcessarImagens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ProcessarImagens));
            this.Rb1 = new System.Windows.Forms.Ribbon();
            this.Rb_Arquivo = new System.Windows.Forms.RibbonTab();
            this.Rb_Arquivo2 = new System.Windows.Forms.RibbonPanel();
            this.Bt_Abrir = new System.Windows.Forms.RibbonButton();
            this.Bt_Salvar = new System.Windows.Forms.RibbonButton();
            this.Bt_Fechar = new System.Windows.Forms.RibbonButton();
            this.Rb_Transformacao = new System.Windows.Forms.RibbonTab();
            this.Rb_Transformacao2 = new System.Windows.Forms.RibbonPanel();
            this.Bt_Escala = new System.Windows.Forms.RibbonButton();
            this.Bt_Translacao = new System.Windows.Forms.RibbonButton();
            this.Bt_Rotacao = new System.Windows.Forms.RibbonButton();
            this.Rb_Sobre = new System.Windows.Forms.RibbonTab();
            this.Rb_Sobre2 = new System.Windows.Forms.RibbonPanel();
            this.Bt_Sobre = new System.Windows.Forms.RibbonButton();
            this.Pb1 = new System.Windows.Forms.PictureBox();
            this.Ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.Sfd1 = new System.Windows.Forms.SaveFileDialog();
            this.Pnl1 = new System.Windows.Forms.Panel();
            this.Tb_Log = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // Rb1
            // 
            this.Rb1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rb1.CaptionBarVisible = false;
            this.Rb1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Rb1.Location = new System.Drawing.Point(0, 0);
            this.Rb1.Minimized = false;
            this.Rb1.Name = "Rb1";
            // 
            // 
            // 
            this.Rb1.OrbDropDown.BorderRoundness = 8;
            this.Rb1.OrbDropDown.Enabled = false;
            this.Rb1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.Rb1.OrbDropDown.Name = "";
            this.Rb1.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.Rb1.OrbDropDown.TabIndex = 0;
            this.Rb1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            this.Rb1.OrbVisible = false;
            this.Rb1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.Rb1.Size = new System.Drawing.Size(800, 133);
            this.Rb1.TabIndex = 0;
            this.Rb1.Tabs.Add(this.Rb_Arquivo);
            this.Rb1.Tabs.Add(this.Rb_Transformacao);
            this.Rb1.Tabs.Add(this.Rb_Sobre);
            this.Rb1.TabsMargin = new System.Windows.Forms.Padding(5, 2, 20, 0);
            this.Rb1.TabSpacing = 4;
            this.Rb1.Text = "Ribbon";
            this.Rb1.ThemeColor = System.Windows.Forms.RibbonTheme.JellyBelly;
            // 
            // Rb_Arquivo
            // 
            this.Rb_Arquivo.Name = "Rb_Arquivo";
            this.Rb_Arquivo.Panels.Add(this.Rb_Arquivo2);
            this.Rb_Arquivo.Text = "Arquivo";
            // 
            // Rb_Arquivo2
            // 
            this.Rb_Arquivo2.Items.Add(this.Bt_Abrir);
            this.Rb_Arquivo2.Items.Add(this.Bt_Salvar);
            this.Rb_Arquivo2.Items.Add(this.Bt_Fechar);
            this.Rb_Arquivo2.Name = "Rb_Arquivo2";
            this.Rb_Arquivo2.Text = "Arquivo";
            // 
            // Bt_Abrir
            // 
            this.Bt_Abrir.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Abrir.Image")));
            this.Bt_Abrir.LargeImage = ((System.Drawing.Image)(resources.GetObject("Bt_Abrir.LargeImage")));
            this.Bt_Abrir.MinimumSize = new System.Drawing.Size(80, 50);
            this.Bt_Abrir.Name = "Bt_Abrir";
            this.Bt_Abrir.SmallImage = ((System.Drawing.Image)(resources.GetObject("Bt_Abrir.SmallImage")));
            this.Bt_Abrir.Text = "Abrir";
            this.Bt_Abrir.Click += new System.EventHandler(this.Bt_Abrir_Click);
            // 
            // Bt_Salvar
            // 
            this.Bt_Salvar.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Salvar.Image")));
            this.Bt_Salvar.LargeImage = ((System.Drawing.Image)(resources.GetObject("Bt_Salvar.LargeImage")));
            this.Bt_Salvar.MinimumSize = new System.Drawing.Size(80, 50);
            this.Bt_Salvar.Name = "Bt_Salvar";
            this.Bt_Salvar.SmallImage = ((System.Drawing.Image)(resources.GetObject("Bt_Salvar.SmallImage")));
            this.Bt_Salvar.Text = "Salvar";
            this.Bt_Salvar.Click += new System.EventHandler(this.Bt_Salvar_Click);
            // 
            // Bt_Fechar
            // 
            this.Bt_Fechar.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Fechar.Image")));
            this.Bt_Fechar.LargeImage = ((System.Drawing.Image)(resources.GetObject("Bt_Fechar.LargeImage")));
            this.Bt_Fechar.MinimumSize = new System.Drawing.Size(80, 50);
            this.Bt_Fechar.Name = "Bt_Fechar";
            this.Bt_Fechar.SmallImage = ((System.Drawing.Image)(resources.GetObject("Bt_Fechar.SmallImage")));
            this.Bt_Fechar.Text = "Fechar";
            this.Bt_Fechar.Click += new System.EventHandler(this.Bt_Fechar_Click);
            // 
            // Rb_Transformacao
            // 
            this.Rb_Transformacao.Name = "Rb_Transformacao";
            this.Rb_Transformacao.Panels.Add(this.Rb_Transformacao2);
            this.Rb_Transformacao.Text = "Transformação";
            // 
            // Rb_Transformacao2
            // 
            this.Rb_Transformacao2.Items.Add(this.Bt_Escala);
            this.Rb_Transformacao2.Items.Add(this.Bt_Translacao);
            this.Rb_Transformacao2.Items.Add(this.Bt_Rotacao);
            this.Rb_Transformacao2.Name = "Rb_Transformacao2";
            this.Rb_Transformacao2.Text = "Transformação";
            // 
            // Bt_Escala
            // 
            this.Bt_Escala.Image = global::PortfolioEngCompUnopar.Properties.Resources.Escala;
            this.Bt_Escala.LargeImage = global::PortfolioEngCompUnopar.Properties.Resources.Escala;
            this.Bt_Escala.MinimumSize = new System.Drawing.Size(80, 50);
            this.Bt_Escala.Name = "Bt_Escala";
            this.Bt_Escala.SmallImage = ((System.Drawing.Image)(resources.GetObject("Bt_Escala.SmallImage")));
            this.Bt_Escala.Text = "Aplicar Escala";
            this.Bt_Escala.Click += new System.EventHandler(this.Bt_Escala_Click);
            // 
            // Bt_Translacao
            // 
            this.Bt_Translacao.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Translacao.Image")));
            this.Bt_Translacao.LargeImage = ((System.Drawing.Image)(resources.GetObject("Bt_Translacao.LargeImage")));
            this.Bt_Translacao.MinimumSize = new System.Drawing.Size(80, 50);
            this.Bt_Translacao.Name = "Bt_Translacao";
            this.Bt_Translacao.SmallImage = ((System.Drawing.Image)(resources.GetObject("Bt_Translacao.SmallImage")));
            this.Bt_Translacao.Text = "Aplicar Translação";
            this.Bt_Translacao.Click += new System.EventHandler(this.Bt_Translacao_Click);
            // 
            // Bt_Rotacao
            // 
            this.Bt_Rotacao.Image = global::PortfolioEngCompUnopar.Properties.Resources.Rotação;
            this.Bt_Rotacao.LargeImage = global::PortfolioEngCompUnopar.Properties.Resources.Rotação;
            this.Bt_Rotacao.MinimumSize = new System.Drawing.Size(80, 50);
            this.Bt_Rotacao.Name = "Bt_Rotacao";
            this.Bt_Rotacao.SmallImage = ((System.Drawing.Image)(resources.GetObject("Bt_Rotacao.SmallImage")));
            this.Bt_Rotacao.Text = "Aplicar Rotaçao";
            this.Bt_Rotacao.Click += new System.EventHandler(this.Bt_Rotacao_Click);
            // 
            // Rb_Sobre
            // 
            this.Rb_Sobre.Name = "Rb_Sobre";
            this.Rb_Sobre.Panels.Add(this.Rb_Sobre2);
            this.Rb_Sobre.Text = "Sobre";
            // 
            // Rb_Sobre2
            // 
            this.Rb_Sobre2.Items.Add(this.Bt_Sobre);
            this.Rb_Sobre2.Name = "Rb_Sobre2";
            this.Rb_Sobre2.Text = "Sobre";
            // 
            // Bt_Sobre
            // 
            this.Bt_Sobre.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Sobre.Image")));
            this.Bt_Sobre.LargeImage = ((System.Drawing.Image)(resources.GetObject("Bt_Sobre.LargeImage")));
            this.Bt_Sobre.MinimumSize = new System.Drawing.Size(80, 50);
            this.Bt_Sobre.Name = "Bt_Sobre";
            this.Bt_Sobre.SmallImage = ((System.Drawing.Image)(resources.GetObject("Bt_Sobre.SmallImage")));
            this.Bt_Sobre.Text = "Sobre";
            this.Bt_Sobre.Click += new System.EventHandler(this.Bt_Sobre_Click);
            // 
            // Pb1
            // 
            this.Pb1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pb1.BackColor = System.Drawing.Color.White;
            this.Pb1.Location = new System.Drawing.Point(12, 139);
            this.Pb1.Name = "Pb1";
            this.Pb1.Size = new System.Drawing.Size(776, 362);
            this.Pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Pb1.TabIndex = 1;
            this.Pb1.TabStop = false;
            // 
            // Pnl1
            // 
            this.Pnl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl1.AutoSize = true;
            this.Pnl1.BackColor = System.Drawing.Color.White;
            this.Pnl1.Location = new System.Drawing.Point(1, 131);
            this.Pnl1.Name = "Pnl1";
            this.Pnl1.Size = new System.Drawing.Size(800, 382);
            this.Pnl1.TabIndex = 2;
            // 
            // Tb_Log
            // 
            this.Tb_Log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tb_Log.BackColor = System.Drawing.Color.White;
            this.Tb_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Log.Location = new System.Drawing.Point(269, 33);
            this.Tb_Log.Multiline = true;
            this.Tb_Log.Name = "Tb_Log";
            this.Tb_Log.ReadOnly = true;
            this.Tb_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tb_Log.Size = new System.Drawing.Size(519, 92);
            this.Tb_Log.TabIndex = 3;
            // 
            // Frm_ProcessarImagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.Tb_Log);
            this.Controls.Add(this.Pb1);
            this.Controls.Add(this.Rb1);
            this.Controls.Add(this.Pnl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Frm_ProcessarImagens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Processar Imagens";
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Ribbon Rb1;
        private System.Windows.Forms.RibbonTab Rb_Arquivo;
        private System.Windows.Forms.RibbonPanel Rb_Arquivo2;
        private System.Windows.Forms.RibbonButton Bt_Abrir;
        private System.Windows.Forms.RibbonButton Bt_Salvar;
        private System.Windows.Forms.RibbonButton Bt_Fechar;
        private System.Windows.Forms.RibbonTab Rb_Transformacao;
        private System.Windows.Forms.RibbonPanel Rb_Transformacao2;
        private System.Windows.Forms.RibbonButton Bt_Escala;
        private System.Windows.Forms.RibbonButton Bt_Translacao;
        private System.Windows.Forms.RibbonButton Bt_Rotacao;
        private System.Windows.Forms.RibbonTab Rb_Sobre;
        private System.Windows.Forms.RibbonPanel Rb_Sobre2;
        private System.Windows.Forms.RibbonButton Bt_Sobre;
        private System.Windows.Forms.PictureBox Pb1;
        private System.Windows.Forms.OpenFileDialog Ofd1;
        private System.Windows.Forms.SaveFileDialog Sfd1;
        private System.Windows.Forms.Panel Pnl1;
        private System.Windows.Forms.TextBox Tb_Log;
    }
}