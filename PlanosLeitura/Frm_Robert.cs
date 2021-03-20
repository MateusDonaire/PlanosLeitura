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
            string sql = "SELECT ID_Dia_Leitura FROM tbl_Leitura1 WHERE  ID_Dia_Leitura = @idDia";

            SqlCommand c = new SqlCommand(sql, conn);

            c.Parameters.Add(new SqlParameter("@idDia", idDia));

            conn.Open();

            var resultadoSelect = c.ExecuteNonQuery();

            if (resultadoSelect != 0)
            {
                return true;
            }

            conn.Close();

            return false;
        }



    }
}
