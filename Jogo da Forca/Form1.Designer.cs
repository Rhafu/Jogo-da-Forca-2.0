namespace Jogo_da_Forca
{
    partial class frmMenuu
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
            this.btnJogar = new System.Windows.Forms.Button();
            this.txtBanner = new System.Windows.Forms.Label();
            this.btnCréditos = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.Black;
            this.btnJogar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnJogar.Location = new System.Drawing.Point(73, 127);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(183, 57);
            this.btnJogar.TabIndex = 0;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBanner
            // 
            this.txtBanner.BackColor = System.Drawing.SystemColors.Info;
            this.txtBanner.Font = new System.Drawing.Font("BigNoodleTitling", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanner.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtBanner.Location = new System.Drawing.Point(-1, 36);
            this.txtBanner.Name = "txtBanner";
            this.txtBanner.Size = new System.Drawing.Size(332, 63);
            this.txtBanner.TabIndex = 1;
            this.txtBanner.Text = "JOGO DA FORCA";
            this.txtBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCréditos
            // 
            this.btnCréditos.BackColor = System.Drawing.Color.Black;
            this.btnCréditos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCréditos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCréditos.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCréditos.Location = new System.Drawing.Point(73, 219);
            this.btnCréditos.Name = "btnCréditos";
            this.btnCréditos.Size = new System.Drawing.Size(183, 57);
            this.btnCréditos.TabIndex = 2;
            this.btnCréditos.Text = "Créditos";
            this.btnCréditos.UseVisualStyleBackColor = false;
            this.btnCréditos.Click += new System.EventHandler(this.btnCréditos_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Black;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSair.Location = new System.Drawing.Point(73, 311);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(183, 57);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmMenuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(331, 408);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCréditos);
            this.Controls.Add(this.txtBanner);
            this.Controls.Add(this.btnJogar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forca";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Label txtBanner;
        private System.Windows.Forms.Button btnCréditos;
        private System.Windows.Forms.Button btnSair;
    }
}

