using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PlanosLeitura
{
    public partial class Frm_Robert : Form
    {
        public Frm_Robert()
        {
            InitializeComponent();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Principal frm_Principal = new Frm_Principal();
            frm_Principal.Show();
        }

        private void txb_Dia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CancelaSeForLetra(e))
            {
                txb_Dia.Text = "";
            }
        }
        private void txb_Dia_TextChanged(object sender, EventArgs e)
        {
            if (txb_Dia.Text.Length > 3)
            {
                txb_Dia.Text = "";
                MessageBox.Show("Valor deve ser entre 0 e 365");
            }
        }

        private void txb_CapituloInicialA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CancelaSeForLetra(e))
            {
                txb_CapituloInicialA.Text = "";
            }
        }

        private void txb_CapituloInicialB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CancelaSeForLetra(e))
            {
                txb_CapituloInicialB.Text = "";
            }
        }

        private void txb_CapituloInicialC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CancelaSeForLetra(e))
            {
                txb_CapituloInicialC.Text = "";
            }
        }
        private void txb_CapituloFinalA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CancelaSeForLetra(e))
            {
                txb_CapituloFinalA.Text = "";
            }
        }

        private void txb_CapituloFinalB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CancelaSeForLetra(e))
            {
                txb_CapituloFinalB.Text = "";
            }
        }

        private void txb_CapituloFinalC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CancelaSeForLetra(e))
            {
                txb_CapituloFinalC.Text = "";
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            bool podeSalvar = true;
            string capituloA = "", capituloB = "", capituloC = "";
            int idDia = 0;

            if (txb_Dia.Text.Equals("") || cbx_LivroA.Text.Equals("") || txb_CapituloInicialA.Equals("") || cbx_LivroB.Text.Equals("") || txb_CapituloInicialB.Equals("")
                || cbx_LivroC.Text.Equals("") || txb_CapituloInicialC.Equals(""))
            {
                podeSalvar = false;
                MessageBox.Show("Não é possível salvar com algum campo vazio!");
            }

            if (txb_CapituloFinalA.Text != "")
            {
                capituloA = txb_CapituloInicialA.Text + " - " + txb_CapituloFinalA.Text;
            }
            else
            {
                capituloA = txb_CapituloInicialA.Text;
            }

            if (txb_CapituloFinalB.Text != "")
            {
                capituloB = txb_CapituloInicialB.Text + " - " + txb_CapituloFinalB.Text;
            }
            else
            {
                capituloB = txb_CapituloInicialB.Text;
            }

            if (txb_CapituloFinalC.Text != "")
            {
                capituloC = txb_CapituloInicialC.Text + " - " + txb_CapituloFinalC.Text;
            }
            else
            {
                capituloC = txb_CapituloInicialC.Text;
            }


            if (txb_Dia.Text != "")
            {
                idDia = Convert.ToInt32(txb_Dia.Text);
            }

            if (TemDiaRegistrado(idDia))
            {
               podeSalvar = false;
               MessageBox.Show("Dia " + idDia + " já está cadastrado na Base!");
            }

            SqlConnection conn = new SqlConnection("Data Source=NOTEDONAIRE;Initial Catalog=PlanosLeitura;Persist Security Info=True;User ID=sa;Password=mdon11");
            string sql = "INSERT INTO tbl_Leitura2(ID_Dia_Leitura, LivroA, CapituloA, LivroB, CapituloB, LivroC, CapituloC) VALUES (@ID_Dia_Leitura, @LivroA, @CapituloA, @LivroB, @CapituloB, @LivroC, @CapituloC)";

            try
            {
                if (podeSalvar)
                {
                    SqlCommand c = new SqlCommand(sql, conn);

                    c.Parameters.Add(new SqlParameter("@ID_Dia_Leitura", idDia));
                    c.Parameters.Add(new SqlParameter("@LivroA", cbx_LivroA.Text));
                    c.Parameters.Add(new SqlParameter("@CapituloA", capituloA));
                    c.Parameters.Add(new SqlParameter("@LivroB", cbx_LivroB.Text));
                    c.Parameters.Add(new SqlParameter("@CapituloB", capituloB));
                    c.Parameters.Add(new SqlParameter("@LivroC", cbx_LivroC.Text));
                    c.Parameters.Add(new SqlParameter("@CapituloC", capituloC));

                    conn.Open();

                    c.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("Dados Salvos com Sucesso!");

                    int proximoDia = idDia + 1;
                    string proximoDiaString = Convert.ToString(proximoDia);
                    txb_Dia.Text = proximoDiaString;
                    txb_CapituloInicialA.Text = "";
                    txb_CapituloFinalA.Text = "";
                    txb_CapituloInicialB.Text = "";
                    txb_CapituloFinalB.Text = "";
                    txb_CapituloInicialC.Text = "";
                    txb_CapituloFinalC.Text = "";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERRO: " + ex);
            }

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
    

        private void btn_UltimoCadastrado_Click(object sender, EventArgs e)
        {

            SqlDataReader reader = null;
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection("Data Source=NOTEDONAIRE;Initial Catalog=PlanosLeitura;Integrated Security=True");

                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM tbl_Leitura2 ORDER BY ID_Dia_Leitura DESC", conn);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MessageBox.Show(" Dia: " + reader["ID_Dia_Leitura"].ToString() + "\r\n" + "\r\n Livro: " + reader["LivroA"].ToString() + "\r\n Capítulo: " + reader["CapituloA"].ToString() + "\r\n" +
                                                                                              "\r\n Livro: " + reader["LivroB"].ToString() + "\r\n Capítulo: " + reader["CapituloB"].ToString() + "\r\n" +
                                                                                              "\r\n Livro: " + reader["LivroC"].ToString() + "\r\n Capítulo: " + reader["CapituloC"].ToString());
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show("ERRO: " + ex);

            }

            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }

                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}

