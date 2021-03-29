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
    public partial class Frm_Robert_Consultar : Form
    {
        public Frm_Robert_Consultar()
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
                        SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Leitura2 WHERE  ID_Dia_Leitura = @idDia", conn);

                        cmd.Parameters.Add(new SqlParameter("@idDia", dia));

                        conn.Open();

                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            lbl_Dia.Text = reader["ID_Dia_Leitura"].ToString();
                            lbl_LivroA.Text = reader["LivroA"].ToString();
                            lbl_CapituloA.Text = reader["CapituloA"].ToString();
                            lbl_LivroB.Text = reader["LivroB"].ToString();
                            lbl_CapituloB.Text = reader["CapituloB"].ToString();
                            lbl_LivroC.Text = reader["LivroC"].ToString();
                            lbl_CapituloC.Text = reader["CapituloC"].ToString();

                            FormatarNomeLivroA(lbl_LivroA.Text);
                            FormatarNomeLivroB(lbl_LivroB.Text);
                            FormatarNomeLivroC(lbl_LivroC.Text);
                        }

                        conn.Close();
                        reader.Close();

                    } else MessageBox.Show("Dia " + dia + " não está cadastrado na base.");
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
                SqlCommand cmd = new SqlCommand("SELECT ID_Dia_Leitura FROM tbl_Leitura2 WHERE  ID_Dia_Leitura = @idDia", conn);

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
            Frm_ConsultarOuInserir_Robert consultarOuInserir_Robert = new Frm_ConsultarOuInserir_Robert();
            consultarOuInserir_Robert.Show();
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
                        SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Leitura2 WHERE  ID_Dia_Leitura = @idDia", conn);

                        cmd.Parameters.Add(new SqlParameter("@idDia", dia));

                        conn.Open();

                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            lbl_Dia.Text = reader["ID_Dia_Leitura"].ToString();
                            lbl_LivroA.Text = reader["LivroA"].ToString();
                            lbl_CapituloA.Text = reader["CapituloA"].ToString();
                            lbl_LivroB.Text = reader["LivroB"].ToString();
                            lbl_CapituloB.Text = reader["CapituloB"].ToString();
                            lbl_LivroC.Text = reader["LivroC"].ToString();
                            lbl_CapituloC.Text = reader["CapituloC"].ToString();

                            FormatarNomeLivroA(lbl_LivroA.Text);
                            FormatarNomeLivroB(lbl_LivroB.Text);
                            FormatarNomeLivroC(lbl_LivroC.Text);
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
                    SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Leitura2 WHERE  ID_Dia_Leitura = @idDia", conn);

                    cmd.Parameters.Add(new SqlParameter("@idDia", dia));

                    conn.Open();

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        lbl_Dia.Text = reader["ID_Dia_Leitura"].ToString();
                        lbl_LivroA.Text = reader["LivroA"].ToString();
                        lbl_CapituloA.Text = reader["CapituloA"].ToString();
                        lbl_LivroB.Text = reader["LivroB"].ToString();
                        lbl_CapituloB.Text = reader["CapituloB"].ToString();
                        lbl_LivroC.Text = reader["LivroC"].ToString();
                        lbl_CapituloC.Text = reader["CapituloC"].ToString();

                        FormatarNomeLivroA(lbl_LivroA.Text);
                        FormatarNomeLivroB(lbl_LivroB.Text);
                        FormatarNomeLivroC(lbl_LivroC.Text);
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

        public void FormatarNomeLivroA(string nomeLivroA)
        {
            if (nomeLivroA == "Gn") lbl_LivroA.Text = "Gênesis";
            if (nomeLivroA == "Ex") lbl_LivroA.Text = "Êxodo";
            if (nomeLivroA == "Lv") lbl_LivroA.Text = "Levítico";
            if (nomeLivroA == "Nm") lbl_LivroA.Text = "Números";
            if (nomeLivroA == "Dt") lbl_LivroA.Text = "Deuteronômio";
            if (nomeLivroA == "Js") lbl_LivroA.Text = "Josué";
            if (nomeLivroA == "Jz") lbl_LivroA.Text = "Juízes";
            if (nomeLivroA == "Rt") lbl_LivroA.Text = "Rute";
            if (nomeLivroA == "1Sm") lbl_LivroA.Text = "1 Samuel";
            if (nomeLivroA == "2Sm") lbl_LivroA.Text = "2 Samuel";
            if (nomeLivroA == "1Rs") lbl_LivroA.Text = "1 Reis";
            if (nomeLivroA == "2Rs") lbl_LivroA.Text = "2 Reis";
            if (nomeLivroA == "1Cr") lbl_LivroA.Text = "1 Crônicas";
            if (nomeLivroA == "2Cr") lbl_LivroA.Text = "2 Crônicas";
            if (nomeLivroA == "Ed") lbl_LivroA.Text = "Esdras";
            if (nomeLivroA == "Ne") lbl_LivroA.Text = "Neemias";
            if (nomeLivroA == "Et") lbl_LivroA.Text = "Ester";
            if (nomeLivroA == "Jo") lbl_LivroA.Text = "Jó";
            if (nomeLivroA == "Sl") lbl_LivroA.Text = "Salmos";
            if (nomeLivroA == "Pv") lbl_LivroA.Text = "Provérbios";
            if (nomeLivroA == "Ec") lbl_LivroA.Text = "Eclesiastes";
            if (nomeLivroA == "Ct") lbl_LivroA.Text = "Cantares";
            if (nomeLivroA == "Is") lbl_LivroA.Text = "Isaías";
            if (nomeLivroA == "Jr") lbl_LivroA.Text = "Jeremias";
            if (nomeLivroA == "Lm") lbl_LivroA.Text = "Lamentações";
            if (nomeLivroA == "Ez") lbl_LivroA.Text = "Ezequiel";
            if (nomeLivroA == "Dn") lbl_LivroA.Text = "Daniel";
            if (nomeLivroA == "Os") lbl_LivroA.Text = "Oseias";
            if (nomeLivroA == "Jl") lbl_LivroA.Text = "Joel";
            if (nomeLivroA == "Am") lbl_LivroA.Text = "Amós";
            if (nomeLivroA == "Ob") lbl_LivroA.Text = "Obadias";
            if (nomeLivroA == "Jn") lbl_LivroA.Text = "Jonas";
            if (nomeLivroA == "Mq") lbl_LivroA.Text = "Miqueias";
            if (nomeLivroA == "Na") lbl_LivroA.Text = "Naum";
            if (nomeLivroA == "Hc") lbl_LivroA.Text = "Habacuque";
            if (nomeLivroA == "Sf") lbl_LivroA.Text = "Sofonias";
            if (nomeLivroA == "Ag") lbl_LivroA.Text = "Ageu";
            if (nomeLivroA == "Zc") lbl_LivroA.Text = "Zacarias";
            if (nomeLivroA == "Ml") lbl_LivroA.Text = "Malaquias";

            if (nomeLivroA == "Mt") lbl_LivroA.Text = "Mateus";
            if (nomeLivroA == "Mc") lbl_LivroA.Text = "Marcos";
            if (nomeLivroA == "Lc") lbl_LivroA.Text = "Lucas";
            if (nomeLivroA == "Jo") lbl_LivroA.Text = "João";
            if (nomeLivroA == "At") lbl_LivroA.Text = "Atos dos Apóstolos	";
            if (nomeLivroA == "Rm") lbl_LivroA.Text = "Romanos";
            if (nomeLivroA == "1Co") lbl_LivroA.Text = "1 Coríntios";
            if (nomeLivroA == "2Co") lbl_LivroA.Text = "2 Coríntios";
            if (nomeLivroA == "Gl") lbl_LivroA.Text = "Gálatas";
            if (nomeLivroA == "Ef") lbl_LivroA.Text = "Efésios";
            if (nomeLivroA == "Fp") lbl_LivroA.Text = "Filipenses";
            if (nomeLivroA == "Cl") lbl_LivroA.Text = "Colossenses";
            if (nomeLivroA == "1Ts") lbl_LivroA.Text = "1 Tessalonicenses";
            if (nomeLivroA == "2Ts") lbl_LivroA.Text = "2 Tessalonicenses";
            if (nomeLivroA == "1Tm") lbl_LivroA.Text = "1 Timóteo";
            if (nomeLivroA == "2Tm") lbl_LivroA.Text = "2 Timóteo";
            if (nomeLivroA == "Tt") lbl_LivroA.Text = "Tito";
            if (nomeLivroA == "Fm") lbl_LivroA.Text = "Filemom";
            if (nomeLivroA == "Hb") lbl_LivroA.Text = "Hebreus";
            if (nomeLivroA == "Tg") lbl_LivroA.Text = "Tiago";
            if (nomeLivroA == "1Pe") lbl_LivroA.Text = "1 Pedro";
            if (nomeLivroA == "2Pe") lbl_LivroA.Text = "2 Pedro";
            if (nomeLivroA == "1Jo") lbl_LivroA.Text = "1 João";
            if (nomeLivroA == "2Jo") lbl_LivroA.Text = "2 João";
            if (nomeLivroA == "3Jo") lbl_LivroA.Text = "3 João";
            if (nomeLivroA == "Jd") lbl_LivroA.Text = "Judas";
            if (nomeLivroA == "Ap") lbl_LivroA.Text = "Apocalipse";
        }

        public void FormatarNomeLivroB(string nomeLivroB)
        {
            if (nomeLivroB == "Gn") lbl_LivroB.Text = "Gênesis";
            if (nomeLivroB == "Ex") lbl_LivroB.Text = "Êxodo";
            if (nomeLivroB == "Lv") lbl_LivroB.Text = "Levítico";
            if (nomeLivroB == "Nm") lbl_LivroB.Text = "Números";
            if (nomeLivroB == "Dt") lbl_LivroB.Text = "Deuteronômio";
            if (nomeLivroB == "Js") lbl_LivroB.Text = "Josué";
            if (nomeLivroB == "Jz") lbl_LivroB.Text = "Juízes";
            if (nomeLivroB == "Rt") lbl_LivroB.Text = "Rute";
            if (nomeLivroB == "1Sm") lbl_LivroB.Text = "1 Samuel";
            if (nomeLivroB == "2Sm") lbl_LivroB.Text = "2 Samuel";
            if (nomeLivroB == "1Rs") lbl_LivroB.Text = "1 Reis";
            if (nomeLivroB == "2Rs") lbl_LivroB.Text = "2 Reis";
            if (nomeLivroB == "1Cr") lbl_LivroB.Text = "1 Crônicas";
            if (nomeLivroB == "2Cr") lbl_LivroB.Text = "2 Crônicas";
            if (nomeLivroB == "Ed") lbl_LivroB.Text = "Esdras";
            if (nomeLivroB == "Ne") lbl_LivroB.Text = "Neemias";
            if (nomeLivroB == "Et") lbl_LivroB.Text = "Ester";
            if (nomeLivroB == "Jo") lbl_LivroB.Text = "Jó";
            if (nomeLivroB == "Sl") lbl_LivroB.Text = "Salmos";
            if (nomeLivroB == "Pv") lbl_LivroB.Text = "Provérbios";
            if (nomeLivroB == "Ec") lbl_LivroB.Text = "Eclesiastes";
            if (nomeLivroB == "Ct") lbl_LivroB.Text = "Cantares";
            if (nomeLivroB == "Is") lbl_LivroB.Text = "Isaías";
            if (nomeLivroB == "Jr") lbl_LivroB.Text = "Jeremias";
            if (nomeLivroB == "Lm") lbl_LivroB.Text = "Lamentações";
            if (nomeLivroB == "Ez") lbl_LivroB.Text = "Ezequiel";
            if (nomeLivroB == "Dn") lbl_LivroB.Text = "Daniel";
            if (nomeLivroB == "Os") lbl_LivroB.Text = "Oseias";
            if (nomeLivroB == "Jl") lbl_LivroB.Text = "Joel";
            if (nomeLivroB == "Am") lbl_LivroB.Text = "Amós";
            if (nomeLivroB == "Ob") lbl_LivroB.Text = "Obadias";
            if (nomeLivroB == "Jn") lbl_LivroB.Text = "Jonas";
            if (nomeLivroB == "Mq") lbl_LivroB.Text = "Miqueias";
            if (nomeLivroB == "Na") lbl_LivroB.Text = "Naum";
            if (nomeLivroB == "Hc") lbl_LivroB.Text = "Habacuque";
            if (nomeLivroB == "Sf") lbl_LivroB.Text = "Sofonias";
            if (nomeLivroB == "Ag") lbl_LivroB.Text = "Ageu";
            if (nomeLivroB == "Zc") lbl_LivroB.Text = "Zacarias";
            if (nomeLivroB == "Ml") lbl_LivroB.Text = "Malaquias";

            if (nomeLivroB == "Mt") lbl_LivroB.Text = "Mateus";
            if (nomeLivroB == "Mc") lbl_LivroB.Text = "Marcos";
            if (nomeLivroB == "Lc") lbl_LivroB.Text = "Lucas";
            if (nomeLivroB == "Jo") lbl_LivroB.Text = "João";
            if (nomeLivroB == "At") lbl_LivroB.Text = "Atos dos Apóstolos	";
            if (nomeLivroB == "Rm") lbl_LivroB.Text = "Romanos";
            if (nomeLivroB == "1Co") lbl_LivroB.Text = "1 Coríntios";
            if (nomeLivroB == "2Co") lbl_LivroB.Text = "2 Coríntios";
            if (nomeLivroB == "Gl") lbl_LivroB.Text = "Gálatas";
            if (nomeLivroB == "Ef") lbl_LivroB.Text = "Efésios";
            if (nomeLivroB == "Fp") lbl_LivroB.Text = "Filipenses";
            if (nomeLivroB == "Cl") lbl_LivroB.Text = "Colossenses";
            if (nomeLivroB == "1Ts") lbl_LivroB.Text = "1 Tessalonicenses";
            if (nomeLivroB == "2Ts") lbl_LivroB.Text = "2 Tessalonicenses";
            if (nomeLivroB == "1Tm") lbl_LivroB.Text = "1 Timóteo";
            if (nomeLivroB == "2Tm") lbl_LivroB.Text = "2 Timóteo";
            if (nomeLivroB == "Tt") lbl_LivroB.Text = "Tito";
            if (nomeLivroB == "Fm") lbl_LivroB.Text = "Filemom";
            if (nomeLivroB == "Hb") lbl_LivroB.Text = "Hebreus";
            if (nomeLivroB == "Tg") lbl_LivroB.Text = "Tiago";
            if (nomeLivroB == "1Pe") lbl_LivroB.Text = "1 Pedro";
            if (nomeLivroB == "2Pe") lbl_LivroB.Text = "2 Pedro";
            if (nomeLivroB == "1Jo") lbl_LivroB.Text = "1 João";
            if (nomeLivroB == "2Jo") lbl_LivroB.Text = "2 João";
            if (nomeLivroB == "3Jo") lbl_LivroB.Text = "3 João";
            if (nomeLivroB == "Jd") lbl_LivroB.Text = "Judas";
            if (nomeLivroB == "Ap") lbl_LivroB.Text = "Apocalipse";
        }

        public void FormatarNomeLivroC(string nomeLivroC)
        {
            if (nomeLivroC == "Gn") lbl_LivroC.Text = "Gênesis";
            if (nomeLivroC == "Ex") lbl_LivroC.Text = "Êxodo";
            if (nomeLivroC == "Lv") lbl_LivroC.Text = "Levítico";
            if (nomeLivroC == "Nm") lbl_LivroC.Text = "Números";
            if (nomeLivroC == "Dt") lbl_LivroC.Text = "Deuteronômio";
            if (nomeLivroC == "Js") lbl_LivroC.Text = "Josué";
            if (nomeLivroC == "Jz") lbl_LivroC.Text = "Juízes";
            if (nomeLivroC == "Rt") lbl_LivroC.Text = "Rute";
            if (nomeLivroC == "1Sm") lbl_LivroC.Text = "1 Samuel";
            if (nomeLivroC == "2Sm") lbl_LivroC.Text = "2 Samuel";
            if (nomeLivroC == "1Rs") lbl_LivroC.Text = "1 Reis";
            if (nomeLivroC == "2Rs") lbl_LivroC.Text = "2 Reis";
            if (nomeLivroC == "1Cr") lbl_LivroC.Text = "1 Crônicas";
            if (nomeLivroC == "2Cr") lbl_LivroC.Text = "2 Crônicas";
            if (nomeLivroC == "Ed") lbl_LivroC.Text = "Esdras";
            if (nomeLivroC == "Ne") lbl_LivroC.Text = "Neemias";
            if (nomeLivroC == "Et") lbl_LivroC.Text = "Ester";
            if (nomeLivroC == "Jo") lbl_LivroC.Text = "Jó";
            if (nomeLivroC == "Sl") lbl_LivroC.Text = "Salmos";
            if (nomeLivroC == "Pv") lbl_LivroC.Text = "Provérbios";
            if (nomeLivroC == "Ec") lbl_LivroC.Text = "Eclesiastes";
            if (nomeLivroC == "Ct") lbl_LivroC.Text = "Cantares";
            if (nomeLivroC == "Is") lbl_LivroC.Text = "Isaías";
            if (nomeLivroC == "Jr") lbl_LivroC.Text = "Jeremias";
            if (nomeLivroC == "Lm") lbl_LivroC.Text = "Lamentações";
            if (nomeLivroC == "Ez") lbl_LivroC.Text = "Ezequiel";
            if (nomeLivroC == "Dn") lbl_LivroC.Text = "Daniel";
            if (nomeLivroC == "Os") lbl_LivroC.Text = "Oseias";
            if (nomeLivroC == "Jl") lbl_LivroC.Text = "Joel";
            if (nomeLivroC == "Am") lbl_LivroC.Text = "Amós";
            if (nomeLivroC == "Ob") lbl_LivroC.Text = "Obadias";
            if (nomeLivroC == "Jn") lbl_LivroC.Text = "Jonas";
            if (nomeLivroC == "Mq") lbl_LivroC.Text = "Miqueias";
            if (nomeLivroC == "Na") lbl_LivroC.Text = "Naum";
            if (nomeLivroC == "Hc") lbl_LivroC.Text = "Habacuque";
            if (nomeLivroC == "Sf") lbl_LivroC.Text = "Sofonias";
            if (nomeLivroC == "Ag") lbl_LivroC.Text = "Ageu";
            if (nomeLivroC == "Zc") lbl_LivroC.Text = "Zacarias";
            if (nomeLivroC == "Ml") lbl_LivroC.Text = "Malaquias";

            if (nomeLivroC == "Mt") lbl_LivroC.Text = "Mateus";
            if (nomeLivroC == "Mc") lbl_LivroC.Text = "Marcos";
            if (nomeLivroC == "Lc") lbl_LivroC.Text = "Lucas";
            if (nomeLivroC == "Jo") lbl_LivroC.Text = "João";
            if (nomeLivroC == "At") lbl_LivroC.Text = "Atos dos Apóstolos	";
            if (nomeLivroC == "Rm") lbl_LivroC.Text = "Romanos";
            if (nomeLivroC == "1Co") lbl_LivroC.Text = "1 Coríntios";
            if (nomeLivroC == "2Co") lbl_LivroC.Text = "2 Coríntios";
            if (nomeLivroC == "Gl") lbl_LivroC.Text = "Gálatas";
            if (nomeLivroC == "Ef") lbl_LivroC.Text = "Efésios";
            if (nomeLivroC == "Fp") lbl_LivroC.Text = "Filipenses";
            if (nomeLivroC == "Cl") lbl_LivroC.Text = "Colossenses";
            if (nomeLivroC == "1Ts") lbl_LivroC.Text = "1 Tessalonicenses";
            if (nomeLivroC == "2Ts") lbl_LivroC.Text = "2 Tessalonicenses";
            if (nomeLivroC == "1Tm") lbl_LivroC.Text = "1 Timóteo";
            if (nomeLivroC == "2Tm") lbl_LivroC.Text = "2 Timóteo";
            if (nomeLivroC == "Tt") lbl_LivroC.Text = "Tito";
            if (nomeLivroC == "Fm") lbl_LivroC.Text = "Filemom";
            if (nomeLivroC == "Hb") lbl_LivroC.Text = "Hebreus";
            if (nomeLivroC == "Tg") lbl_LivroC.Text = "Tiago";
            if (nomeLivroC == "1Pe") lbl_LivroC.Text = "1 Pedro";
            if (nomeLivroC == "2Pe") lbl_LivroC.Text = "2 Pedro";
            if (nomeLivroC == "1Jo") lbl_LivroC.Text = "1 João";
            if (nomeLivroC == "2Jo") lbl_LivroC.Text = "2 João";
            if (nomeLivroC == "3Jo") lbl_LivroC.Text = "3 João";
            if (nomeLivroC == "Jd") lbl_LivroC.Text = "Judas";
            if (nomeLivroC == "Ap") lbl_LivroC.Text = "Apocalipse";
        }

    }
}
