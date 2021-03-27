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

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Robert robert = new Frm_Robert();
            robert.Show();
        }
    }
}
