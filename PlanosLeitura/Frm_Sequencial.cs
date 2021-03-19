﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
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
          
            if(txb_Dia.Text.Length > 3)
            {
                txb_Dia.Text = "";
                MessageBox.Show("Valor deve ser entre 0 e 365");
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
           if(cbx_Livro.Text == "---")
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

            if(txb_CapituloFinal.Text != "")
            {
                capitulo = txb_CapituloInicial.Text + " - " + txb_CapituloFinal.Text;
            }
            else
            {
                capitulo = txb_CapituloInicial.Text;
            }

           if(txb_Dia.Text != "")
            {
               idDia = Convert.ToInt32(txb_Dia.Text);
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
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERRO: " + ex);
            }
            finally
            {
                idDia++;
                txb_CapituloInicial.Text = "";
                txb_CapituloFinal.Text = "";
            }
        }


        public bool CancelaSeForLetra(KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Apenas número é permitido!");
                return true;
            }
            return false;
        }

    }
}
