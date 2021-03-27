using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlanosLeitura
{
    public partial class Frm_ConsultarOuInerir_Sequencial : Form
    {
        public Frm_ConsultarOuInerir_Sequencial()
        {            
            InitializeComponent();
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Sequencial sequencial = new Frm_Sequencial();
            sequencial.Show();
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Sequencial_Consultar sequencial_Consultar = new Frm_Sequencial_Consultar();
            sequencial_Consultar.Show();
        }
    }
}
