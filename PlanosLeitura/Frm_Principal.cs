using System;
using System.Windows.Forms;

namespace PlanosLeitura
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void btn_Sequencial_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ConsultarOuInerir_Sequencial consultarOuInerir_Sequencial = new Frm_ConsultarOuInerir_Sequencial();
            consultarOuInerir_Sequencial.Show();

        }

        private void btn_Robert_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ConsultarOuInserir_Robert consultarOuInserir_Robert = new Frm_ConsultarOuInserir_Robert();
            consultarOuInserir_Robert.Show();
        }
    }
}
