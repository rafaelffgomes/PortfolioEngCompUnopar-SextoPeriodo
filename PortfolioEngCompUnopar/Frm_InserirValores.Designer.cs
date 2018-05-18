namespace PortfolioEngCompUnopar
{
    partial class Frm_InserirValores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_InserirValores));
            this.Tab_Transformacao = new System.Windows.Forms.TabControl();
            this.Tab_Escala = new System.Windows.Forms.TabPage();
            this.Bt_EscExcluir = new System.Windows.Forms.Button();
            this.Bt_EscCima = new System.Windows.Forms.Button();
            this.Bt_EscBaixo = new System.Windows.Forms.Button();
            this.Bt_EscSalvar = new System.Windows.Forms.Button();
            this.Tb_ValorEscala = new System.Windows.Forms.TextBox();
            this.Lbl_Escala = new System.Windows.Forms.Label();
            this.Tab_Translacao = new System.Windows.Forms.TabPage();
            this.Bt_TransExcluir = new System.Windows.Forms.Button();
            this.Bt_TransSalvar = new System.Windows.Forms.Button();
            this.Bt_TransCima = new System.Windows.Forms.Button();
            this.Bt_TransBaixo = new System.Windows.Forms.Button();
            this.Bt_TransEsquerda = new System.Windows.Forms.Button();
            this.Bt_TransDireita = new System.Windows.Forms.Button();
            this.Lb_Trans_EixoY = new System.Windows.Forms.Label();
            this.Lb_Trans_EixoX = new System.Windows.Forms.Label();
            this.Tb_ValorYTranslacao = new System.Windows.Forms.TextBox();
            this.Tb_ValorXTranslacao = new System.Windows.Forms.TextBox();
            this.Lbl_Translacao = new System.Windows.Forms.Label();
            this.Tab_Rotacao = new System.Windows.Forms.TabPage();
            this.Bt_RotExcluir = new System.Windows.Forms.Button();
            this.Lbl_Rotacao = new System.Windows.Forms.Label();
            this.Bt_RotEsquerda = new System.Windows.Forms.Button();
            this.Bt_RotDireita = new System.Windows.Forms.Button();
            this.Tb_ValorRotacao = new System.Windows.Forms.TextBox();
            this.Bt_RotSalvar = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Tb_Log = new System.Windows.Forms.TextBox();
            this.Tab_Transformacao.SuspendLayout();
            this.Tab_Escala.SuspendLayout();
            this.Tab_Translacao.SuspendLayout();
            this.Tab_Rotacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab_Transformacao
            // 
            this.Tab_Transformacao.Controls.Add(this.Tab_Escala);
            this.Tab_Transformacao.Controls.Add(this.Tab_Translacao);
            this.Tab_Transformacao.Controls.Add(this.Tab_Rotacao);
            this.Tab_Transformacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab_Transformacao.Location = new System.Drawing.Point(4, 0);
            this.Tab_Transformacao.Name = "Tab_Transformacao";
            this.Tab_Transformacao.SelectedIndex = 0;
            this.Tab_Transformacao.Size = new System.Drawing.Size(516, 379);
            this.Tab_Transformacao.TabIndex = 0;
            // 
            // Tab_Escala
            // 
            this.Tab_Escala.Controls.Add(this.Bt_EscExcluir);
            this.Tab_Escala.Controls.Add(this.Bt_EscCima);
            this.Tab_Escala.Controls.Add(this.Bt_EscBaixo);
            this.Tab_Escala.Controls.Add(this.Bt_EscSalvar);
            this.Tab_Escala.Controls.Add(this.Tb_ValorEscala);
            this.Tab_Escala.Controls.Add(this.Lbl_Escala);
            this.Tab_Escala.Location = new System.Drawing.Point(4, 27);
            this.Tab_Escala.Name = "Tab_Escala";
            this.Tab_Escala.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Escala.Size = new System.Drawing.Size(508, 348);
            this.Tab_Escala.TabIndex = 2;
            this.Tab_Escala.Text = "   Escala   ";
            this.Tab_Escala.UseVisualStyleBackColor = true;
            // 
            // Bt_EscExcluir
            // 
            this.Bt_EscExcluir.Image = global::PortfolioEngCompUnopar.Properties.Resources.Deletar;
            this.Bt_EscExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Bt_EscExcluir.Location = new System.Drawing.Point(304, 199);
            this.Bt_EscExcluir.Name = "Bt_EscExcluir";
            this.Bt_EscExcluir.Size = new System.Drawing.Size(157, 72);
            this.Bt_EscExcluir.TabIndex = 17;
            this.Bt_EscExcluir.Text = "Excluir Valor";
            this.Bt_EscExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Bt_EscExcluir.UseVisualStyleBackColor = true;
            this.Bt_EscExcluir.Click += new System.EventHandler(this.Bt_EscDeletar_Click);
            // 
            // Bt_EscCima
            // 
            this.Bt_EscCima.Image = global::PortfolioEngCompUnopar.Properties.Resources.SetaCima;
            this.Bt_EscCima.Location = new System.Drawing.Point(141, 163);
            this.Bt_EscCima.Name = "Bt_EscCima";
            this.Bt_EscCima.Size = new System.Drawing.Size(45, 45);
            this.Bt_EscCima.TabIndex = 15;
            this.Bt_EscCima.UseVisualStyleBackColor = true;
            this.Bt_EscCima.Click += new System.EventHandler(this.Bt_EscCima_Click);
            // 
            // Bt_EscBaixo
            // 
            this.Bt_EscBaixo.Image = global::PortfolioEngCompUnopar.Properties.Resources.SetaBaixo;
            this.Bt_EscBaixo.Location = new System.Drawing.Point(141, 226);
            this.Bt_EscBaixo.Name = "Bt_EscBaixo";
            this.Bt_EscBaixo.Size = new System.Drawing.Size(45, 45);
            this.Bt_EscBaixo.TabIndex = 16;
            this.Bt_EscBaixo.UseVisualStyleBackColor = true;
            this.Bt_EscBaixo.Click += new System.EventHandler(this.Bt_EscBaixo_Click);
            // 
            // Bt_EscSalvar
            // 
            this.Bt_EscSalvar.Image = global::PortfolioEngCompUnopar.Properties.Resources.Escala;
            this.Bt_EscSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Bt_EscSalvar.Location = new System.Drawing.Point(304, 101);
            this.Bt_EscSalvar.Name = "Bt_EscSalvar";
            this.Bt_EscSalvar.Size = new System.Drawing.Size(157, 72);
            this.Bt_EscSalvar.TabIndex = 8;
            this.Bt_EscSalvar.Text = "Salvar Escala";
            this.Bt_EscSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Bt_EscSalvar.UseVisualStyleBackColor = true;
            this.Bt_EscSalvar.Click += new System.EventHandler(this.Bt_EcsSalvar_Click);
            // 
            // Tb_ValorEscala
            // 
            this.Tb_ValorEscala.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_ValorEscala.ForeColor = System.Drawing.Color.Red;
            this.Tb_ValorEscala.Location = new System.Drawing.Point(105, 101);
            this.Tb_ValorEscala.Name = "Tb_ValorEscala";
            this.Tb_ValorEscala.Size = new System.Drawing.Size(117, 38);
            this.Tb_ValorEscala.TabIndex = 7;
            this.Tb_ValorEscala.Text = "100";
            this.Tb_ValorEscala.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tb_ValorEscala.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Valores_KeyPress);
            // 
            // Lbl_Escala
            // 
            this.Lbl_Escala.AutoSize = true;
            this.Lbl_Escala.Location = new System.Drawing.Point(64, 18);
            this.Lbl_Escala.Name = "Lbl_Escala";
            this.Lbl_Escala.Size = new System.Drawing.Size(395, 18);
            this.Lbl_Escala.TabIndex = 6;
            this.Lbl_Escala.Text = "Informe o valor em PORCENTAGEM para a escala:";
            // 
            // Tab_Translacao
            // 
            this.Tab_Translacao.Controls.Add(this.Bt_TransExcluir);
            this.Tab_Translacao.Controls.Add(this.Bt_TransSalvar);
            this.Tab_Translacao.Controls.Add(this.Bt_TransCima);
            this.Tab_Translacao.Controls.Add(this.Bt_TransBaixo);
            this.Tab_Translacao.Controls.Add(this.Bt_TransEsquerda);
            this.Tab_Translacao.Controls.Add(this.Bt_TransDireita);
            this.Tab_Translacao.Controls.Add(this.Lb_Trans_EixoY);
            this.Tab_Translacao.Controls.Add(this.Lb_Trans_EixoX);
            this.Tab_Translacao.Controls.Add(this.Tb_ValorYTranslacao);
            this.Tab_Translacao.Controls.Add(this.Tb_ValorXTranslacao);
            this.Tab_Translacao.Controls.Add(this.Lbl_Translacao);
            this.Tab_Translacao.Location = new System.Drawing.Point(4, 27);
            this.Tab_Translacao.Name = "Tab_Translacao";
            this.Tab_Translacao.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Translacao.Size = new System.Drawing.Size(515, 348);
            this.Tab_Translacao.TabIndex = 1;
            this.Tab_Translacao.Text = "   Translação   ";
            this.Tab_Translacao.UseVisualStyleBackColor = true;
            // 
            // Bt_TransExcluir
            // 
            this.Bt_TransExcluir.Image = global::PortfolioEngCompUnopar.Properties.Resources.Deletar;
            this.Bt_TransExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Bt_TransExcluir.Location = new System.Drawing.Point(304, 199);
            this.Bt_TransExcluir.Name = "Bt_TransExcluir";
            this.Bt_TransExcluir.Size = new System.Drawing.Size(157, 72);
            this.Bt_TransExcluir.TabIndex = 16;
            this.Bt_TransExcluir.Text = "Excluir Valores";
            this.Bt_TransExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Bt_TransExcluir.UseVisualStyleBackColor = true;
            this.Bt_TransExcluir.Click += new System.EventHandler(this.Bt_TransDeletar_Click);
            // 
            // Bt_TransSalvar
            // 
            this.Bt_TransSalvar.Image = global::PortfolioEngCompUnopar.Properties.Resources.Translação;
            this.Bt_TransSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Bt_TransSalvar.Location = new System.Drawing.Point(304, 101);
            this.Bt_TransSalvar.Name = "Bt_TransSalvar";
            this.Bt_TransSalvar.Size = new System.Drawing.Size(157, 72);
            this.Bt_TransSalvar.TabIndex = 15;
            this.Bt_TransSalvar.Text = "Salvar Translação";
            this.Bt_TransSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Bt_TransSalvar.UseVisualStyleBackColor = true;
            this.Bt_TransSalvar.Click += new System.EventHandler(this.Bt_TransSalvar_Click);
            // 
            // Bt_TransCima
            // 
            this.Bt_TransCima.Image = global::PortfolioEngCompUnopar.Properties.Resources.SetaCima;
            this.Bt_TransCima.Location = new System.Drawing.Point(141, 170);
            this.Bt_TransCima.Name = "Bt_TransCima";
            this.Bt_TransCima.Size = new System.Drawing.Size(45, 45);
            this.Bt_TransCima.TabIndex = 13;
            this.Bt_TransCima.UseVisualStyleBackColor = true;
            this.Bt_TransCima.Click += new System.EventHandler(this.Bt_TransCima_Click);
            // 
            // Bt_TransBaixo
            // 
            this.Bt_TransBaixo.Image = global::PortfolioEngCompUnopar.Properties.Resources.SetaBaixo;
            this.Bt_TransBaixo.Location = new System.Drawing.Point(141, 272);
            this.Bt_TransBaixo.Name = "Bt_TransBaixo";
            this.Bt_TransBaixo.Size = new System.Drawing.Size(45, 45);
            this.Bt_TransBaixo.TabIndex = 14;
            this.Bt_TransBaixo.UseVisualStyleBackColor = true;
            this.Bt_TransBaixo.Click += new System.EventHandler(this.Bt_TransBaixo_Click);
            // 
            // Bt_TransEsquerda
            // 
            this.Bt_TransEsquerda.Image = global::PortfolioEngCompUnopar.Properties.Resources.SetaEsquerda;
            this.Bt_TransEsquerda.Location = new System.Drawing.Point(90, 221);
            this.Bt_TransEsquerda.Name = "Bt_TransEsquerda";
            this.Bt_TransEsquerda.Size = new System.Drawing.Size(45, 45);
            this.Bt_TransEsquerda.TabIndex = 11;
            this.Bt_TransEsquerda.UseVisualStyleBackColor = true;
            this.Bt_TransEsquerda.Click += new System.EventHandler(this.Bt_TransEsquerda_Click);
            // 
            // Bt_TransDireita
            // 
            this.Bt_TransDireita.Image = global::PortfolioEngCompUnopar.Properties.Resources.SetaDireita;
            this.Bt_TransDireita.Location = new System.Drawing.Point(192, 221);
            this.Bt_TransDireita.Name = "Bt_TransDireita";
            this.Bt_TransDireita.Size = new System.Drawing.Size(45, 45);
            this.Bt_TransDireita.TabIndex = 12;
            this.Bt_TransDireita.UseVisualStyleBackColor = true;
            this.Bt_TransDireita.Click += new System.EventHandler(this.Bt_TransDireita_Click);
            // 
            // Lb_Trans_EixoY
            // 
            this.Lb_Trans_EixoY.AutoSize = true;
            this.Lb_Trans_EixoY.Location = new System.Drawing.Point(32, 126);
            this.Lb_Trans_EixoY.Name = "Lb_Trans_EixoY";
            this.Lb_Trans_EixoY.Size = new System.Drawing.Size(67, 18);
            this.Lb_Trans_EixoY.TabIndex = 10;
            this.Lb_Trans_EixoY.Text = "EIXO Y:";
            // 
            // Lb_Trans_EixoX
            // 
            this.Lb_Trans_EixoX.AutoSize = true;
            this.Lb_Trans_EixoX.Location = new System.Drawing.Point(32, 82);
            this.Lb_Trans_EixoX.Name = "Lb_Trans_EixoX";
            this.Lb_Trans_EixoX.Size = new System.Drawing.Size(68, 18);
            this.Lb_Trans_EixoX.TabIndex = 9;
            this.Lb_Trans_EixoX.Text = "EIXO X:";
            // 
            // Tb_ValorYTranslacao
            // 
            this.Tb_ValorYTranslacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_ValorYTranslacao.ForeColor = System.Drawing.Color.Red;
            this.Tb_ValorYTranslacao.Location = new System.Drawing.Point(105, 116);
            this.Tb_ValorYTranslacao.Name = "Tb_ValorYTranslacao";
            this.Tb_ValorYTranslacao.Size = new System.Drawing.Size(117, 38);
            this.Tb_ValorYTranslacao.TabIndex = 8;
            this.Tb_ValorYTranslacao.Text = "0";
            this.Tb_ValorYTranslacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tb_ValorYTranslacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Valores_KeyPress);
            // 
            // Tb_ValorXTranslacao
            // 
            this.Tb_ValorXTranslacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_ValorXTranslacao.ForeColor = System.Drawing.Color.Red;
            this.Tb_ValorXTranslacao.Location = new System.Drawing.Point(105, 72);
            this.Tb_ValorXTranslacao.Name = "Tb_ValorXTranslacao";
            this.Tb_ValorXTranslacao.Size = new System.Drawing.Size(117, 38);
            this.Tb_ValorXTranslacao.TabIndex = 7;
            this.Tb_ValorXTranslacao.Text = "0";
            this.Tb_ValorXTranslacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tb_ValorXTranslacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Valores_KeyPress);
            // 
            // Lbl_Translacao
            // 
            this.Lbl_Translacao.AutoSize = true;
            this.Lbl_Translacao.Location = new System.Drawing.Point(51, 18);
            this.Lbl_Translacao.Name = "Lbl_Translacao";
            this.Lbl_Translacao.Size = new System.Drawing.Size(420, 18);
            this.Lbl_Translacao.TabIndex = 6;
            this.Lbl_Translacao.Text = "Informe o valor em PONTOS de X e Y para translação:";
            this.Lbl_Translacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tab_Rotacao
            // 
            this.Tab_Rotacao.Controls.Add(this.Bt_RotExcluir);
            this.Tab_Rotacao.Controls.Add(this.Lbl_Rotacao);
            this.Tab_Rotacao.Controls.Add(this.Bt_RotEsquerda);
            this.Tab_Rotacao.Controls.Add(this.Bt_RotDireita);
            this.Tab_Rotacao.Controls.Add(this.Tb_ValorRotacao);
            this.Tab_Rotacao.Controls.Add(this.Bt_RotSalvar);
            this.Tab_Rotacao.Location = new System.Drawing.Point(4, 27);
            this.Tab_Rotacao.Name = "Tab_Rotacao";
            this.Tab_Rotacao.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Rotacao.Size = new System.Drawing.Size(515, 348);
            this.Tab_Rotacao.TabIndex = 0;
            this.Tab_Rotacao.Text = "   Rotação   ";
            this.Tab_Rotacao.UseVisualStyleBackColor = true;
            // 
            // Bt_RotExcluir
            // 
            this.Bt_RotExcluir.Image = global::PortfolioEngCompUnopar.Properties.Resources.Deletar;
            this.Bt_RotExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Bt_RotExcluir.Location = new System.Drawing.Point(304, 199);
            this.Bt_RotExcluir.Name = "Bt_RotExcluir";
            this.Bt_RotExcluir.Size = new System.Drawing.Size(157, 72);
            this.Bt_RotExcluir.TabIndex = 6;
            this.Bt_RotExcluir.Text = "Excluir Valor";
            this.Bt_RotExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Bt_RotExcluir.UseVisualStyleBackColor = true;
            this.Bt_RotExcluir.Click += new System.EventHandler(this.Bt_RotDeletar_Click);
            // 
            // Lbl_Rotacao
            // 
            this.Lbl_Rotacao.AutoSize = true;
            this.Lbl_Rotacao.Location = new System.Drawing.Point(102, 18);
            this.Lbl_Rotacao.Name = "Lbl_Rotacao";
            this.Lbl_Rotacao.Size = new System.Drawing.Size(319, 18);
            this.Lbl_Rotacao.TabIndex = 5;
            this.Lbl_Rotacao.Text = "Informe o valor em GRAUS para rotação:";
            // 
            // Bt_RotEsquerda
            // 
            this.Bt_RotEsquerda.Image = global::PortfolioEngCompUnopar.Properties.Resources.SetaEsquerda;
            this.Bt_RotEsquerda.Location = new System.Drawing.Point(105, 160);
            this.Bt_RotEsquerda.Name = "Bt_RotEsquerda";
            this.Bt_RotEsquerda.Size = new System.Drawing.Size(45, 45);
            this.Bt_RotEsquerda.TabIndex = 1;
            this.Bt_RotEsquerda.UseVisualStyleBackColor = true;
            this.Bt_RotEsquerda.Click += new System.EventHandler(this.Bt_RotEsquerda_Click);
            // 
            // Bt_RotDireita
            // 
            this.Bt_RotDireita.Image = global::PortfolioEngCompUnopar.Properties.Resources.SetaDireita;
            this.Bt_RotDireita.Location = new System.Drawing.Point(177, 160);
            this.Bt_RotDireita.Name = "Bt_RotDireita";
            this.Bt_RotDireita.Size = new System.Drawing.Size(45, 45);
            this.Bt_RotDireita.TabIndex = 2;
            this.Bt_RotDireita.UseVisualStyleBackColor = true;
            this.Bt_RotDireita.Click += new System.EventHandler(this.Bt_RotDireita_Click);
            // 
            // Tb_ValorRotacao
            // 
            this.Tb_ValorRotacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_ValorRotacao.ForeColor = System.Drawing.Color.Red;
            this.Tb_ValorRotacao.Location = new System.Drawing.Point(105, 101);
            this.Tb_ValorRotacao.Name = "Tb_ValorRotacao";
            this.Tb_ValorRotacao.Size = new System.Drawing.Size(117, 38);
            this.Tb_ValorRotacao.TabIndex = 3;
            this.Tb_ValorRotacao.Text = "0";
            this.Tb_ValorRotacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tb_ValorRotacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Valores_KeyPress);
            // 
            // Bt_RotSalvar
            // 
            this.Bt_RotSalvar.Image = global::PortfolioEngCompUnopar.Properties.Resources.Rotação;
            this.Bt_RotSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Bt_RotSalvar.Location = new System.Drawing.Point(304, 101);
            this.Bt_RotSalvar.Name = "Bt_RotSalvar";
            this.Bt_RotSalvar.Size = new System.Drawing.Size(157, 72);
            this.Bt_RotSalvar.TabIndex = 4;
            this.Bt_RotSalvar.Text = "Salvar Rotação";
            this.Bt_RotSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Bt_RotSalvar.UseVisualStyleBackColor = true;
            this.Bt_RotSalvar.Click += new System.EventHandler(this.Bt_RotSalvar_Click);
            // 
            // button5
            // 
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(317, 138);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(157, 72);
            this.button5.TabIndex = 15;
            this.button5.Text = "Salvar Translação";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Tb_Log
            // 
            this.Tb_Log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tb_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Log.Location = new System.Drawing.Point(7, 381);
            this.Tb_Log.Multiline = true;
            this.Tb_Log.Name = "Tb_Log";
            this.Tb_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tb_Log.Size = new System.Drawing.Size(501, 92);
            this.Tb_Log.TabIndex = 1;
            // 
            // Frm_InserirValores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(515, 480);
            this.Controls.Add(this.Tb_Log);
            this.Controls.Add(this.Tab_Transformacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_InserirValores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Valores";
            this.Tab_Transformacao.ResumeLayout(false);
            this.Tab_Escala.ResumeLayout(false);
            this.Tab_Escala.PerformLayout();
            this.Tab_Translacao.ResumeLayout(false);
            this.Tab_Translacao.PerformLayout();
            this.Tab_Rotacao.ResumeLayout(false);
            this.Tab_Rotacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Tab_Transformacao;
        private System.Windows.Forms.TabPage Tab_Rotacao;
        private System.Windows.Forms.TabPage Tab_Translacao;
        private System.Windows.Forms.TabPage Tab_Escala;
        private System.Windows.Forms.Label Lbl_Rotacao;
        private System.Windows.Forms.Button Bt_RotEsquerda;
        private System.Windows.Forms.Button Bt_RotDireita;
        private System.Windows.Forms.TextBox Tb_ValorRotacao;
        private System.Windows.Forms.Button Bt_RotSalvar;
        private System.Windows.Forms.Label Lbl_Translacao;
        private System.Windows.Forms.TextBox Tb_ValorYTranslacao;
        private System.Windows.Forms.TextBox Tb_ValorXTranslacao;
        private System.Windows.Forms.Button Bt_TransCima;
        private System.Windows.Forms.Button Bt_TransBaixo;
        private System.Windows.Forms.Button Bt_TransEsquerda;
        private System.Windows.Forms.Button Bt_TransDireita;
        private System.Windows.Forms.Label Lb_Trans_EixoY;
        private System.Windows.Forms.Label Lb_Trans_EixoX;
        private System.Windows.Forms.Button Bt_TransSalvar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label Lbl_Escala;
        private System.Windows.Forms.Button Bt_EscCima;
        private System.Windows.Forms.Button Bt_EscBaixo;
        private System.Windows.Forms.Button Bt_EscSalvar;
        private System.Windows.Forms.TextBox Tb_ValorEscala;
        private System.Windows.Forms.TextBox Tb_Log;
        private System.Windows.Forms.Button Bt_RotExcluir;
        private System.Windows.Forms.Button Bt_TransExcluir;
        private System.Windows.Forms.Button Bt_EscExcluir;
    }
}