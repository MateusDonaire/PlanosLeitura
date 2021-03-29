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
            int dia = Convert.ToInt32(txt_Dia.Text);
            PesquisarDia(dia);
        }

        public void PesquisarDia(int dia)
        {
            SqlConnection conn = new SqlConnection("Data Source=NOTEDONAIRE;Initial Catalog=PlanosLeitura;Persist Security Info=True;User ID=sa;Password=mdon11");
            SqlDataReader reader = null;

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
                }

                conn.Close();
                reader.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERRO: " + ex);
            }
        }
    }
}
