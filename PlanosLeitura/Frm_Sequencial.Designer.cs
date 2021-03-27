
namespace PlanosLeitura
{
    partial class Frm_Sequencial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.lbl_Dia = new System.Windows.Forms.Label();
            this.txb_Dia = new System.Windows.Forms.TextBox();
            this.txb_CapituloInicial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_CapituloFinal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Livro = new System.Windows.Forms.Label();
            this.cbx_Livro = new System.Windows.Forms.ComboBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_UltimoCadastrado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(12, 12);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_Voltar.TabIndex = 7;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // lbl_Dia
            // 
            this.lbl_Dia.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Dia.Location = new System.Drawing.Point(65, 83);
            this.lbl_Dia.Name = "lbl_Dia";
            this.lbl_Dia.Size = new System.Drawing.Size(100, 23);
            this.lbl_Dia.TabIndex = 0;
            this.lbl_Dia.Text = "Dia";
            // 
            // txb_Dia
            // 
            this.txb_Dia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_Dia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txb_Dia.Location = new System.Drawing.Point(118, 83);
            this.txb_Dia.Name = "txb_Dia";
            this.txb_Dia.Size = new System.Drawing.Size(53, 25);
            this.txb_Dia.TabIndex = 0;
            this.txb_Dia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_Dia.TextChanged += new System.EventHandler(this.txb_Dia_TextChanged);
            this.txb_Dia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_Dia_KeyPress);
            // 
            // txb_CapituloInicial
            // 
            this.txb_CapituloInicial.ForeColor = System.Drawing.Color.Black;
            this.txb_CapituloInicial.Location = new System.Drawing.Point(118, 186);
            this.txb_CapituloInicial.Name = "txb_CapituloInicial";
            this.txb_CapituloInicial.Size = new System.Drawing.Size(26, 23);
            this.txb_CapituloInicial.TabIndex = 2;
            this.txb_CapituloInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_CapituloInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_CapituloInicial_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Capítulos";
            // 
            // txb_CapituloFinal
            // 
            this.txb_CapituloFinal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txb_CapituloFinal.Location = new System.Drawing.Point(167, 186);
            this.txb_CapituloFinal.Name = "txb_CapituloFinal";
            this.txb_CapituloFinal.Size = new System.Drawing.Size(26, 23);
            this.txb_CapituloFinal.TabIndex = 3;
            this.txb_CapituloFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_CapituloFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_CapituloFinal_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(147, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "-";
            // 
            // lbl_Livro
            // 
            this.lbl_Livro.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Livro.Location = new System.Drawing.Point(51, 127);
            this.lbl_Livro.Name = "lbl_Livro";
            this.lbl_Livro.Size = new System.Drawing.Size(100, 38);
            this.lbl_Livro.TabIndex = 5;
            this.lbl_Livro.Text = "Livro";
            // 
            // cbx_Livro
            // 
            this.cbx_Livro.FormattingEnabled = true;
            this.cbx_Livro.Items.AddRange(new object[] {
            "Gn",
            "Ex",
            "Lv",
            "Nm",
            "Dt",
            "Js",
            "Jz",
            "Rt",
            "1Sm",
            "2Sm",
            "1Rs",
            "2Rs",
            "1Cr",
            "2Cr",
            "Ed",
            "Ne",
            "Et",
            "Jo",
            "Sl",
            "Pv",
            "Ec",
            "Ct",
            "Is",
            "Jr",
            "Lm",
            "Ez",
            "Dn",
            "Os",
            "Jl",
            "Am",
            "Ob",
            "Jn",
            "Mq",
            "Na",
            "Hc",
            "Sf",
            "Ag",
            "Zc",
            "Ml",
            "---",
            "Mt",
            "Mc",
            "Lc",
            "Jo",
            "At",
            "Rm",
            "1Co",
            "2Co",
            "Gl",
            "Ef",
            "Fp",
            "Cl",
            "1Ts",
            "2Ts",
            "1Tm",
            "2Tm",
            "Tt",
            "Fm",
            "Hb",
            "Tg",
            "1Pe",
            "2Pe",
            "1Jo",
            "2Jo",
            "3Jo",
            "Jd",
            "Ap"});
            this.cbx_Livro.Location = new System.Drawing.Point(118, 135);
            this.cbx_Livro.Name = "cbx_Livro";
            this.cbx_Livro.Size = new System.Drawing.Size(53, 23);
            this.cbx_Livro.TabIndex = 1;
            this.cbx_Livro.SelectedIndexChanged += new System.EventHandler(this.cbx_Livro_SelectedIndexChanged);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(80, 250);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(113, 39);
            this.btn_Salvar.TabIndex = 4;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_UltimoCadastrado
            // 
            this.btn_UltimoCadastrado.Location = new System.Drawing.Point(147, 12);
            this.btn_UltimoCadastrado.Name = "btn_UltimoCadastrado";
            this.btn_UltimoCadastrado.Size = new System.Drawing.Size(119, 23);
            this.btn_UltimoCadastrado.TabIndex = 8;
            this.btn_UltimoCadastrado.Text = "Ultimo Cadastrado";
            this.btn_UltimoCadastrado.UseVisualStyleBackColor = true;
            this.btn_UltimoCadastrado.Click += new System.EventHandler(this.btn_UltimoCadastrado_Click);
            // 
            // Frm_Sequencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 311);
            this.Controls.Add(this.btn_UltimoCadastrado);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.cbx_Livro);
            this.Controls.Add(this.lbl_Livro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_CapituloFinal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_CapituloInicial);
            this.Controls.Add(this.txb_Dia);
            this.Controls.Add(this.lbl_Dia);
            this.Controls.Add(this.btn_Voltar);
            this.Name = "Frm_Sequencial";
            this.Text = "SEQUENCIAL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Label lbl_Dia;
        private System.Windows.Forms.TextBox txb_Dia;
        private System.Windows.Forms.TextBox txb_CapituloInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_CapituloFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Livro;
        private System.Windows.Forms.ComboBox cbx_Livro;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_UltimoCadastrado;
    }
}