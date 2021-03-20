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
            Frm_Sequencial frm_Sequencial = new Frm_Sequencial();
            frm_Sequencial.Show();
        }

        private void btn_Robert_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Robert frm_Robert = new Frm_Robert();
            frm_Robert.Show();
        }
    }
}
