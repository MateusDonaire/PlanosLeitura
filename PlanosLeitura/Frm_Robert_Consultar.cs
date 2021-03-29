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
    }
}
