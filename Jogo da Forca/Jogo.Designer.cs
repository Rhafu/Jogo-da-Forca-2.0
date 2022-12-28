namespace Jogo_da_Forca
{
    partial class Jogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jogo));
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.btnFecharJogo = new System.Windows.Forms.Button();
            this.pctForca = new System.Windows.Forms.PictureBox();
            this.pctCabeça = new System.Windows.Forms.PictureBox();
            this.pctCorpo = new System.Windows.Forms.PictureBox();
            this.pctBraEsq = new System.Windows.Forms.PictureBox();
            this.pctBraDire = new System.Windows.Forms.PictureBox();
            this.pctPernaDir = new System.Windows.Forms.PictureBox();
            this.pctPernaEsq = new System.Windows.Forms.PictureBox();
            this.btnComeçarJogo = new System.Windows.Forms.Button();
            this.txtEntrar = new System.Windows.Forms.TextBox();
            this.lblEntrar = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblMostraErros = new System.Windows.Forms.Label();
            this.lblErros = new System.Windows.Forms.Label();
            this.lblTema = new System.Windows.Forms.Label();
            this.lblMostraTema = new System.Windows.Forms.Label();
            this.lblLetras = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctForca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCabeça)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCorpo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBraEsq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBraDire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPernaDir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPernaEsq)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPalavra
            // 
            this.txtPalavra.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtPalavra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPalavra.Font = new System.Drawing.Font("Franklin Gothic Book", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalavra.Location = new System.Drawing.Point(1, 312);
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.ReadOnly = true;
            this.txtPalavra.Size = new System.Drawing.Size(792, 109);
            this.txtPalavra.TabIndex = 2;
            this.txtPalavra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFecharJogo
            // 
            this.btnFecharJogo.BackColor = System.Drawing.Color.Black;
            this.btnFecharJogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFecharJogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharJogo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnFecharJogo.Location = new System.Drawing.Point(665, 427);
            this.btnFecharJogo.Name = "btnFecharJogo";
            this.btnFecharJogo.Size = new System.Drawing.Size(116, 39);
            this.btnFecharJogo.TabIndex = 6;
            this.btnFecharJogo.Text = "Fechar";
            this.btnFecharJogo.UseVisualStyleBackColor = false;
            this.btnFecharJogo.Click += new System.EventHandler(this.btnFecharJogo_Click);
            // 
            // pctForca
            // 
            this.pctForca.Image = ((System.Drawing.Image)(resources.GetObject("pctForca.Image")));
            this.pctForca.Location = new System.Drawing.Point(1, 3);
            this.pctForca.Name = "pctForca";
            this.pctForca.Size = new System.Drawing.Size(302, 331);
            this.pctForca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctForca.TabIndex = 1;
            this.pctForca.TabStop = false;
            // 
            // pctCabeça
            // 
            this.pctCabeça.Image = ((System.Drawing.Image)(resources.GetObject("pctCabeça.Image")));
            this.pctCabeça.Location = new System.Drawing.Point(215, 57);
            this.pctCabeça.Name = "pctCabeça";
            this.pctCabeça.Size = new System.Drawing.Size(59, 57);
            this.pctCabeça.TabIndex = 7;
            this.pctCabeça.TabStop = false;
            this.pctCabeça.Visible = false;
            // 
            // pctCorpo
            // 
            this.pctCorpo.Image = ((System.Drawing.Image)(resources.GetObject("pctCorpo.Image")));
            this.pctCorpo.Location = new System.Drawing.Point(215, 106);
            this.pctCorpo.Name = "pctCorpo";
            this.pctCorpo.Size = new System.Drawing.Size(59, 159);
            this.pctCorpo.TabIndex = 8;
            this.pctCorpo.TabStop = false;
            this.pctCorpo.Visible = false;
            // 
            // pctBraEsq
            // 
            this.pctBraEsq.Image = ((System.Drawing.Image)(resources.GetObject("pctBraEsq.Image")));
            this.pctBraEsq.Location = new System.Drawing.Point(189, 120);
            this.pctBraEsq.Name = "pctBraEsq";
            this.pctBraEsq.Size = new System.Drawing.Size(51, 58);
            this.pctBraEsq.TabIndex = 9;
            this.pctBraEsq.TabStop = false;
            this.pctBraEsq.Visible = false;
            // 
            // pctBraDire
            // 
            this.pctBraDire.Image = ((System.Drawing.Image)(resources.GetObject("pctBraDire.Image")));
            this.pctBraDire.Location = new System.Drawing.Point(247, 120);
            this.pctBraDire.Name = "pctBraDire";
            this.pctBraDire.Size = new System.Drawing.Size(56, 58);
            this.pctBraDire.TabIndex = 10;
            this.pctBraDire.TabStop = false;
            this.pctBraDire.Visible = false;
            // 
            // pctPernaDir
            // 
            this.pctPernaDir.Image = ((System.Drawing.Image)(resources.GetObject("pctPernaDir.Image")));
            this.pctPernaDir.Location = new System.Drawing.Point(244, 253);
            this.pctPernaDir.Name = "pctPernaDir";
            this.pctPernaDir.Size = new System.Drawing.Size(56, 58);
            this.pctPernaDir.TabIndex = 11;
            this.pctPernaDir.TabStop = false;
            this.pctPernaDir.Visible = false;
            // 
            // pctPernaEsq
            // 
            this.pctPernaEsq.Image = ((System.Drawing.Image)(resources.GetObject("pctPernaEsq.Image")));
            this.pctPernaEsq.Location = new System.Drawing.Point(192, 253);
            this.pctPernaEsq.Name = "pctPernaEsq";
            this.pctPernaEsq.Size = new System.Drawing.Size(51, 58);
            this.pctPernaEsq.TabIndex = 12;
            this.pctPernaEsq.TabStop = false;
            this.pctPernaEsq.Visible = false;
            // 
            // btnComeçarJogo
            // 
            this.btnComeçarJogo.BackColor = System.Drawing.Color.Black;
            this.btnComeçarJogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnComeçarJogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComeçarJogo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnComeçarJogo.Location = new System.Drawing.Point(665, 18);
            this.btnComeçarJogo.Name = "btnComeçarJogo";
            this.btnComeçarJogo.Size = new System.Drawing.Size(116, 39);
            this.btnComeçarJogo.TabIndex = 14;
            this.btnComeçarJogo.Text = "Começar Jogo";
            this.btnComeçarJogo.UseVisualStyleBackColor = false;
            this.btnComeçarJogo.Click += new System.EventHandler(this.btnComeçarJogo_Click);
            // 
            // txtEntrar
            // 
            this.txtEntrar.Location = new System.Drawing.Point(13, 445);
            this.txtEntrar.MaxLength = 1;
            this.txtEntrar.Name = "txtEntrar";
            this.txtEntrar.Size = new System.Drawing.Size(100, 20);
            this.txtEntrar.TabIndex = 17;
            // 
            // lblEntrar
            // 
            this.lblEntrar.AutoSize = true;
            this.lblEntrar.Location = new System.Drawing.Point(10, 427);
            this.lblEntrar.Name = "lblEntrar";
            this.lblEntrar.Size = new System.Drawing.Size(44, 13);
            this.lblEntrar.TabIndex = 18;
            this.lblEntrar.Text = "Entrada";
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Black;
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEntrar.Location = new System.Drawing.Point(119, 445);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(94, 21);
            this.btnEntrar.TabIndex = 20;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblMostraErros
            // 
            this.lblMostraErros.Location = new System.Drawing.Point(463, 46);
            this.lblMostraErros.Name = "lblMostraErros";
            this.lblMostraErros.Size = new System.Drawing.Size(84, 38);
            this.lblMostraErros.TabIndex = 22;
            this.lblMostraErros.Text = "erros";
            this.lblMostraErros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMostraErros.Visible = false;
            // 
            // lblErros
            // 
            this.lblErros.AutoSize = true;
            this.lblErros.Font = new System.Drawing.Font("BigNoodleTitling", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErros.Location = new System.Drawing.Point(462, 23);
            this.lblErros.Name = "lblErros";
            this.lblErros.Size = new System.Drawing.Size(48, 23);
            this.lblErros.TabIndex = 23;
            this.lblErros.Text = "Erros";
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("BigNoodleTitling", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTema.Location = new System.Drawing.Point(347, 23);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(40, 23);
            this.lblTema.TabIndex = 25;
            this.lblTema.Text = "Tema";
            // 
            // lblMostraTema
            // 
            this.lblMostraTema.Location = new System.Drawing.Point(348, 46);
            this.lblMostraTema.Name = "lblMostraTema";
            this.lblMostraTema.Size = new System.Drawing.Size(84, 38);
            this.lblMostraTema.TabIndex = 24;
            this.lblMostraTema.Text = "tema";
            this.lblMostraTema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMostraTema.Visible = false;
            // 
            // lblLetras
            // 
            this.lblLetras.Font = new System.Drawing.Font("Basaro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetras.ForeColor = System.Drawing.Color.Blue;
            this.lblLetras.Location = new System.Drawing.Point(650, 120);
            this.lblLetras.Name = "lblLetras";
            this.lblLetras.Size = new System.Drawing.Size(131, 145);
            this.lblLetras.TabIndex = 27;
            this.lblLetras.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BigNoodleTitling", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(644, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Letras que já Foram";
            // 
            // Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(793, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLetras);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.lblMostraTema);
            this.Controls.Add(this.lblErros);
            this.Controls.Add(this.lblMostraErros);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblEntrar);
            this.Controls.Add(this.txtEntrar);
            this.Controls.Add(this.btnComeçarJogo);
            this.Controls.Add(this.pctPernaEsq);
            this.Controls.Add(this.pctPernaDir);
            this.Controls.Add(this.pctBraDire);
            this.Controls.Add(this.pctBraEsq);
            this.Controls.Add(this.pctCabeça);
            this.Controls.Add(this.btnFecharJogo);
            this.Controls.Add(this.txtPalavra);
            this.Controls.Add(this.pctCorpo);
            this.Controls.Add(this.pctForca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Jogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada";
            ((System.ComponentModel.ISupportInitialize)(this.pctForca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCabeça)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCorpo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBraEsq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBraDire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPernaDir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPernaEsq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pctForca;
        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.Button btnFecharJogo;
        private System.Windows.Forms.PictureBox pctCabeça;
        private System.Windows.Forms.PictureBox pctCorpo;
        private System.Windows.Forms.PictureBox pctBraEsq;
        private System.Windows.Forms.PictureBox pctBraDire;
        private System.Windows.Forms.PictureBox pctPernaDir;
        private System.Windows.Forms.PictureBox pctPernaEsq;
        private System.Windows.Forms.Button btnComeçarJogo;
        private System.Windows.Forms.TextBox txtEntrar;
        private System.Windows.Forms.Label lblEntrar;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblMostraErros;
        private System.Windows.Forms.Label lblErros;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Label lblMostraTema;
        private System.Windows.Forms.Label lblLetras;
        private System.Windows.Forms.Label label1;
    }
}