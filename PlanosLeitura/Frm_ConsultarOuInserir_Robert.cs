using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlanosLeitura
{
    public partial class Frm_ConsultarOuInserir_Robert : Form
    {
        public Frm_ConsultarOuInserir_Robert()
        {
            InitializeComponent();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Principal principal = new Frm_Principal();
            principal.Show();
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Robert_Inserir robert = new Frm_Robert_Inserir();
            robert.Show();
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Robert_Consultar robert_Consultar = new Frm_Robert_Consultar();
            robert_Consultar.Show();
        }
    }
}
