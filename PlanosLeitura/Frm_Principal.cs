using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
    }
}
