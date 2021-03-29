using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlanosLeitura
{
    public partial class Frm_Sequencial_Consultar : Form
    {
        public Frm_Sequencial_Consultar()
        {
            InitializeComponent();
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            if (!txt_Dia.Text.Equals(""))
            {
                int dia = Convert.ToInt32(txt_Dia.Text);
                PesquisarDia(dia);
            }
            else MessageBox.Show("Digite um dia para consultar.");

        }

        public void PesquisarDia(int dia)
        {
            SqlConnection conn = new SqlConnection("Data Source=NOTEDONAIRE;Initial Catalog=PlanosLeitura;Persist Security Info=True;User ID=sa;Password=mdon11");
            SqlDataReader reader = null;

            try
            {

                if (TemDiaRegistrado(dia))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Leitura1 WHERE  ID_Dia_Leitura = @idDia", conn);

                    cmd.Parameters.Add(new SqlParameter("@idDia", dia));

                    conn.Open();

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        lbl_Dia.Text = reader["ID_Dia_Leitura"].ToString();
                        lbl_Capitulo.Text = reader["Capitulo"].ToString();
                        lbl_Livro.Text = reader["Livro"].ToString();

                        FormatarNomeLivro(lbl_Livro.Text);
                    }

                    conn.Close();
                    reader.Close();

                }
                else MessageBox.Show("Dia " + dia + " não está cadastrado na base.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERRO: " + ex);
            }
        }

        public bool TemDiaRegistrado(int idDia)
        {
            SqlConnection conn = new SqlConnection("Data Source=NOTEDONAIRE;Initial Catalog=PlanosLeitura;Persist Security Info=True;User ID=sa;Password=mdon11");
            SqlDataReader reader = null;

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT ID_Dia_Leitura FROM tbl_Leitura1 WHERE  ID_Dia_Leitura = @idDia", conn);

                cmd.Parameters.Add(new SqlParameter("@idDia", idDia));

                conn.Open();

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    return true;
                }

                conn.Close();
                reader.Close();

                return false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERRO: " + ex);
                return false;
            }

        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ConsultarOuInerir_Sequencial consultarOuInerir_Sequencial = new Frm_ConsultarOuInerir_Sequencial();
            consultarOuInerir_Sequencial.Show();
        }

        private void txt_Dia_KeyPress(object sender, KeyPressEventArgs e)
        {
            CancelaSeForLetra(e);
        }

        public bool CancelaSeForLetra(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Apenas número é permitido!");
                return true;
            }
            return false;
        }

        private void btn_Proximo_Click(object sender, EventArgs e)
        {
            if (!lbl_Dia.Text.Equals("000"))
            {
                SqlConnection conn = new SqlConnection("Data Source=NOTEDONAIRE;Initial Catalog=PlanosLeitura;Persist Security Info=True;User ID=sa;Password=mdon11");
                SqlDataReader reader = null;
                int dia = Convert.ToInt32(lbl_Dia.Text);
                dia++;

                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Leitura1 WHERE  ID_Dia_Leitura = @idDia", conn);

                    cmd.Parameters.Add(new SqlParameter("@idDia", dia));

                    conn.Open();

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        lbl_Dia.Text = reader["ID_Dia_Leitura"].ToString();
                        lbl_Capitulo.Text = reader["Capitulo"].ToString();
                        lbl_Livro.Text = reader["Livro"].ToString();

                        FormatarNomeLivro(lbl_Livro.Text);

                        txt_Dia.Text = "";

                    }

                    conn.Close();
                    reader.Close();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("ERRO: " + ex);
                }
            }
            else MessageBox.Show("Para saber qual o próximo dia é necessário realizar uma primeira consulta.");
        }

        private void btn_Anterior_Click(object sender, EventArgs e)
        {
            if (!lbl_Dia.Text.Equals("000"))
            {
                SqlConnection conn = new SqlConnection("Data Source=NOTEDONAIRE;Initial Catalog=PlanosLeitura;Persist Security Info=True;User ID=sa;Password=mdon11");
                SqlDataReader reader = null;
                int dia = Convert.ToInt32(lbl_Dia.Text);
                dia--;

                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Leitura1 WHERE  ID_Dia_Leitura = @idDia", conn);

                    cmd.Parameters.Add(new SqlParameter("@idDia", dia));

                    conn.Open();

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        lbl_Dia.Text = reader["ID_Dia_Leitura"].ToString();
                        lbl_Capitulo.Text = reader["Capitulo"].ToString();
                        lbl_Livro.Text = reader["Livro"].ToString();

                        FormatarNomeLivro(lbl_Livro.Text);

                        txt_Dia.Text = "";
                    }

                    conn.Close();
                    reader.Close();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("ERRO: " + ex);
                }
            }
            else MessageBox.Show("Para saber qual o dia anterior é necessário realizar uma primeira consulta.");
        }

        public void FormatarNomeLivro(string nomeLivro)
        {
            if (nomeLivro == "Gn") lbl_Livro.Text = "Gênesis";
            if (nomeLivro == "Ex") lbl_Livro.Text = "Êxodo";
            if (nomeLivro == "Lv") lbl_Livro.Text = "Levítico";
            if (nomeLivro == "Nm") lbl_Livro.Text = "Números";
            if (nomeLivro == "Dt") lbl_Livro.Text = "Deuteronômio";
            if (nomeLivro == "Js") lbl_Livro.Text = "Josué";
            if (nomeLivro == "Jz") lbl_Livro.Text = "Juízes";
            if (nomeLivro == "Rt") lbl_Livro.Text = "Rute";
            if (nomeLivro == "1Sm") lbl_Livro.Text = "1 Samuel";
            if (nomeLivro == "2Sm") lbl_Livro.Text = "2 Samuel";
            if (nomeLivro == "1Rs") lbl_Livro.Text = "1 Reis";
            if (nomeLivro == "2Rs") lbl_Livro.Text = "2 Reis";
            if (nomeLivro == "1Cr") lbl_Livro.Text = "1 Crônicas";
            if (nomeLivro == "2Cr") lbl_Livro.Text = "2 Crônicas";
            if (nomeLivro == "Ed") lbl_Livro.Text = "Esdras";
            if (nomeLivro == "Ne") lbl_Livro.Text = "Neemias";
            if (nomeLivro == "Et") lbl_Livro.Text = "Ester";
            if (nomeLivro == "Jo") lbl_Livro.Text = "Jó";
            if (nomeLivro == "Sl") lbl_Livro.Text = "Salmos";
            if (nomeLivro == "Pv") lbl_Livro.Text = "Provérbios";
            if (nomeLivro == "Ec") lbl_Livro.Text = "Eclesiastes";
            if (nomeLivro == "Ct") lbl_Livro.Text = "Cantares";
            if (nomeLivro == "Is") lbl_Livro.Text = "Isaías";
            if (nomeLivro == "Jr") lbl_Livro.Text = "Jeremias";
            if (nomeLivro == "Lm") lbl_Livro.Text = "Lamentações";
            if (nomeLivro == "Ez") lbl_Livro.Text = "Ezequiel";
            if (nomeLivro == "Dn") lbl_Livro.Text = "Daniel";
            if (nomeLivro == "Os") lbl_Livro.Text = "Oseias";
            if (nomeLivro == "Jl") lbl_Livro.Text = "Joel";
            if (nomeLivro == "Am") lbl_Livro.Text = "Amós";
            if (nomeLivro == "Ob") lbl_Livro.Text = "Obadias";
            if (nomeLivro == "Jn") lbl_Livro.Text = "Jonas";
            if (nomeLivro == "Mq") lbl_Livro.Text = "Miqueias";
            if (nomeLivro == "Na") lbl_Livro.Text = "Naum";
            if (nomeLivro == "Hc") lbl_Livro.Text = "Habacuque";
            if (nomeLivro == "Sf") lbl_Livro.Text = "Sofonias";
            if (nomeLivro == "Ag") lbl_Livro.Text = "Ageu";
            if (nomeLivro == "Zc") lbl_Livro.Text = "Zacarias";
            if (nomeLivro == "Ml") lbl_Livro.Text = "Malaquias";

            if (nomeLivro == "Mt") lbl_Livro.Text = "Mateus";
            if (nomeLivro == "Mc") lbl_Livro.Text = "Marcos";
            if (nomeLivro == "Lc") lbl_Livro.Text = "Lucas";
            if (nomeLivro == "Jo") lbl_Livro.Text = "João";
            if (nomeLivro == "At") lbl_Livro.Text = "Atos dos Apóstolos	";
            if (nomeLivro == "Rm") lbl_Livro.Text = "Romanos";
            if (nomeLivro == "1Co") lbl_Livro.Text = "1 Coríntios";
            if (nomeLivro == "2Co") lbl_Livro.Text = "2 Coríntios";
            if (nomeLivro == "Gl") lbl_Livro.Text = "Gálatas";
            if (nomeLivro == "Ef") lbl_Livro.Text = "Efésios";
            if (nomeLivro == "Fp") lbl_Livro.Text = "Filipenses";
            if (nomeLivro == "Cl") lbl_Livro.Text = "Colossenses";
            if (nomeLivro == "1Ts") lbl_Livro.Text = "1 Tessalonicenses";
            if (nomeLivro == "2Ts") lbl_Livro.Text = "2 Tessalonicenses";
            if (nomeLivro == "1Tm") lbl_Livro.Text = "1 Timóteo";
            if (nomeLivro == "2Tm") lbl_Livro.Text = "2 Timóteo";
            if (nomeLivro == "Tt") lbl_Livro.Text = "Tito";
            if (nomeLivro == "Fm") lbl_Livro.Text = "Filemom";
            if (nomeLivro == "Hb") lbl_Livro.Text = "Hebreus";
            if (nomeLivro == "Tg") lbl_Livro.Text = "Tiago";
            if (nomeLivro == "1Pe") lbl_Livro.Text = "1 Pedro";
            if (nomeLivro == "2Pe") lbl_Livro.Text = "2 Pedro";
            if (nomeLivro == "1Jo") lbl_Livro.Text = "1 João";
            if (nomeLivro == "2Jo") lbl_Livro.Text = "2 João";
            if (nomeLivro == "3Jo") lbl_Livro.Text = "3 João";
            if (nomeLivro == "Jd") lbl_Livro.Text = "Judas";
            if (nomeLivro == "Ap") lbl_Livro.Text = "Apocalipse";

        }
    }
}
