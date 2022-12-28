using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Jogo_da_Forca
{
    public partial class Jogo : Form
    {
        private MySqlConnection mConn = new MySqlConnection(
            "Persist Security Info = False;" + //Para não pedir confirmação de senha
            "server=localhost;" + //Onde está o banco de dados
            "database=palavrasforca;" + //Nome do banco de dados
            "uid=root;" + //Usuário do banco de dados
            "pwd=" //Senha do banco de dados(ROOT)
            );

        private String[] palavras;
        private String[] temas;
        private String[] letrasPassad = new string[23];
        private String palavra;
        private int contador;
        private int acertos;
        private int numdePalavras;
        private int erros;
        private int numPalavra;

        public Jogo()
        {
            InitializeComponent();
            this.começaVetor();
        }

        private void começaVetor()
        {
            try
            {
                mConn.Open();
                if (mConn.State == ConnectionState.Open)
                {
                    MySqlCommand comando = mConn.CreateCommand();

                    comando.CommandText = "SELECT * FROM palavras";

                    comando.Connection = mConn;

                    MySqlDataReader contando = comando.ExecuteReader();

                    int cont = 0;

                    while (contando.Read())
                    {
                        cont++;
                    }

                    numdePalavras = cont;
                    palavras = new string[cont];
                    temas = new string[cont];

                    contando.Close();

                    MySqlDataReader dados = comando.ExecuteReader();                   

                    int i = 0;

                    while (dados.Read())
                    {
                        palavras[i] = dados["palavra"].ToString();
                        temas[i] = dados["tema"].ToString();
                        i++;
                    }



                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message.ToString());
            }

            mConn.Close();

        }

        private void checaDerrota()
        {
            if(erros == 6)
            {
                MessageBox.Show("DERROTA :(", "DERROTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                erros = 0;
                acertos = 0;
                palavra = "";
                txtPalavra.Text = "";
                lblLetras.Text = "";
                btnComeçarJogo.Visible = true;

                pctBraDire.Visible = false;
                pctBraEsq.Visible = false;
                pctCorpo.Visible = false;
                pctPernaDir.Visible = false;
                pctPernaEsq.Visible = false;
                pctCabeça.Visible = false;

                lblMostraErros.Visible = false;
                lblMostraTema.Visible = false;
            }

        }

        private void checaVitória() 
        {
            if(acertos == palavra.Length)
            {
                MessageBox.Show("VITÓRIA :)", "VITÓRIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                erros = 0;
                acertos = 0;
                palavra = "";
                txtPalavra.Text = "";
                lblLetras.Text = "";
                btnComeçarJogo.Visible = true;

                pctBraDire.Visible = false;
                pctBraEsq.Visible = false;
                pctCorpo.Visible = false;
                pctPernaDir.Visible = false;
                pctPernaEsq.Visible = false;
                pctCabeça.Visible = false;

                lblMostraErros.Visible = false;
                lblMostraTema.Visible = false;
            }
        }

        private void btnFecharJogo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PreparandoJogo()
        {

            Random num = new Random();
            numPalavra = num.Next(numdePalavras);
            palavra = palavras[numPalavra].ToLower();

            txtPalavra.Text = "";

            for(int c = 0; c < palavra.Length; c++)
            {
                txtPalavra.Text += "-";
            }

            lblMostraErros.Visible = true;
            lblMostraTema.Visible = true;
            lblMostraTema.Text = temas[numPalavra];
            
            erros = 0;

            lblMostraErros.Text = erros.ToString();

        }

        private void btnComeçarJogo_Click(object sender, EventArgs e)
        {
            btnComeçarJogo.Visible = false;
            this.PreparandoJogo();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(erros < 6 && txtEntrar.Text != "") 
            {
                string letraMin = txtEntrar.Text.ToLower(); 
                Boolean acerto = false;
                int bloqueador = 0;
                string palavraTemp = "";
                string tela = txtPalavra.Text;
                Char letra = Convert.ToChar(letraMin);
                
              

                for(int i = 0; i < 22; i++)
                {
                    if(letra.ToString() == letrasPassad[i])
                    {
                        bloqueador = 1;
                    }
                }

                if(bloqueador == 0)
                {
                    letrasPassad[contador] = letra.ToString();
                    lblLetras.Text += letra.ToString() + " ";
                    contador++;
                    if (contador == 5 || contador == 10 || contador == 15 || contador == 20)
                    {
                        lblLetras.Text += "\n";
                    }
                }


                for (int c = 0; c < palavra.Length; c++)
                {
                    if (palavra[c] == letra)
                    {
                        if(bloqueador == 0) 
                        { 
                            acertos += 1;
                        }
                        acerto = true;
                        palavraTemp += txtEntrar.Text;
                    }
                    else
                    {
                        palavraTemp += tela[c];
                    }                    
                
                }
                txtPalavra.Text = palavraTemp;


                


                if(acerto == false && erros < 6 && bloqueador == 0)
                {
                    erros += 1;
                    lblMostraErros.Text = erros.ToString();
                    if(erros >= 1)
                    {
                        pctCabeça.Visible = true;
                        if(erros >= 2)
                        {
                            pctCorpo.Visible = true;
                            if (erros >= 3)
                            {
                                pctBraEsq.Visible = true;
                                if (erros >= 4)
                                {
                                    pctBraDire.Visible = true;
                                    if (erros >= 5)
                                    {
                                        pctPernaDir.Visible = true;
                                        if (erros >= 6)
                                        {
                                            pctPernaEsq.Visible = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                txtEntrar.Text = "";
                txtEntrar.Focus();
                checaVitória();
                checaDerrota();



            }
            else
            {
                MessageBox.Show("Campo de entrada está vazio!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
