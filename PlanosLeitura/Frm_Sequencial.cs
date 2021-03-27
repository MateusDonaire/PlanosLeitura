using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PlanosLeitura
{
    public partial class Frm_Sequencial : Form
    {
        public Frm_Sequencial()
        {
            InitializeComponent();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Principal frm_Principal = new Frm_Principal();
            frm_Principal.Show();
        }


        private void txb_Dia_TextChanged(object sender, EventArgs e)
        {

            if (txb_Dia.Text.Length > 3)
            {
                txb_Dia.Text = "";
                MessageBox.Show("Valor não pode ter mais que 3 digitos");
            }

        }
        private void txb_Dia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CancelaSeForLetra(e))
            {
                txb_Dia.Text = "";
            }
        }

        private void cbx_Livro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Livro.Text == "---")
            {
                MessageBox.Show("Selecione um Livro válido");
            }
        }
        private void txb_CapituloInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CancelaSeForLetra(e))
            {
                txb_CapituloInicial.Text = "";
            }
        }
        private void txb_CapituloFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CancelaSeForLetra(e))
            {
                txb_CapituloFinal.Text = "";
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            bool podeSalvar = true;
            string capitulo = "";
            int idDia = 0;

            if (txb_Dia.Text.Equals("") || cbx_Livro.Text.Equals("") || txb_CapituloInicial.Equals(""))
            {
                podeSalvar = false;
                MessageBox.Show("Não é possível salvar com algum campo vazio!");
            }


            if (txb_CapituloFinal.Text != "")
            {
                capitulo = txb_CapituloInicial.Text + " - " + txb_CapituloFinal.Text;
            }
            else
            {
                capitulo = txb_CapituloInicial.Text;
            }

            if (txb_Dia.Text != "")
            {
                idDia = Convert.ToInt32(txb_Dia.Text);
                if (idDia > 365)
                {
                    podeSalvar = false;
                    MessageBox.Show("Número máximo de dias é 365");
                }
            }

            if (TemDiaRegistrado(idDia))
            {
                podeSalvar = false;
                MessageBox.Show("Dia " + idDia + " já está cadastrado na Base!");
            }

            SqlConnection conn = new SqlConnection("Data Source=NOTEDONAIRE;Initial Catalog=PlanosLeitura;Persist Security Info=True;User ID=sa;Password=mdon11");
            string sql = "INSERT INTO tbl_Leitura1(ID_Dia_Leitura, Livro, Capitulo) VALUES (@ID_Dia_Leitura, @Livro, @Capitulo)";

            try
            {
                if (podeSalvar)
                {
                    SqlCommand c = new SqlCommand(sql, conn);

                    c.Parameters.Add(new SqlParameter("@ID_Dia_Leitura", idDia));
                    c.Parameters.Add(new SqlParameter("@Livro", cbx_Livro.Text));
                    c.Parameters.Add(new SqlParameter("@Capitulo", capitulo));

                    conn.Open();

                    c.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("Dados Salvos com Sucesso!");

                    int proximoDia = idDia + 1;
                    string proximoDiaString = Convert.ToString(proximoDia);
                    txb_Dia.Text = proximoDiaString;
                    txb_CapituloInicial.Text = "";
                    txb_CapituloFinal.Text = "";
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

        private void btn_UltimoCadastrado_Click(object sender, EventArgs e)
        {

            SqlDataReader reader = null;
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection("Data Source=NOTEDONAIRE;Initial Catalog=PlanosLeitura;Integrated Security=True");

                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM tbl_Leitura1 ORDER BY ID_Dia_Leitura DESC", conn);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MessageBox.Show(" Dia: " + reader["ID_Dia_Leitura"].ToString() + "\r\n Livro: " + reader["Livro"].ToString() + "\r\n Capítulo: " + reader["Capitulo"].ToString());
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
