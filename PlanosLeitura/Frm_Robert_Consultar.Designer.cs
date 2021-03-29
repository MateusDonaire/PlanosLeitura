
namespace PlanosLeitura
{
    partial class Frm_Robert_Consultar
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Dia = new System.Windows.Forms.TextBox();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.btn_Anterior = new System.Windows.Forms.Button();
            this.btn_Proximo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Dia = new System.Windows.Forms.Label();
            this.lbl_LivroA = new System.Windows.Forms.Label();
            this.lbl_CapituloA = new System.Windows.Forms.Label();
            this.lbl_CapituloB = new System.Windows.Forms.Label();
            this.lbl_LivroB = new System.Windows.Forms.Label();
            this.lbl_CapituloC = new System.Windows.Forms.Label();
            this.lbl_LivroC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Dia:";
            // 
            // txt_Dia
            // 
            this.txt_Dia.Location = new System.Drawing.Point(313, 12);
            this.txt_Dia.Name = "txt_Dia";
            this.txt_Dia.Size = new System.Drawing.Size(65, 23);
            this.txt_Dia.TabIndex = 1;
            this.txt_Dia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Dia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Dia_KeyPress);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(12, 12);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_Voltar.TabIndex = 2;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Location = new System.Drawing.Point(388, 12);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(75, 23);
            this.btn_Pesquisar.TabIndex = 3;
            this.btn_Pesquisar.Text = "Pesquisar";
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // btn_Anterior
            // 
            this.btn_Anterior.Location = new System.Drawing.Point(12, 206);
            this.btn_Anterior.Name = "btn_Anterior";
            this.btn_Anterior.Size = new System.Drawing.Size(75, 23);
            this.btn_Anterior.TabIndex = 4;
            this.btn_Anterior.Text = "Anterior";
            this.btn_Anterior.UseVisualStyleBackColor = true;
            this.btn_Anterior.Click += new System.EventHandler(this.btn_Anterior_Click);
            // 
            // btn_Proximo
            // 
            this.btn_Proximo.Location = new System.Drawing.Point(388, 206);
            this.btn_Proximo.Name = "btn_Proximo";
            this.btn_Proximo.Size = new System.Drawing.Size(75, 23);
            this.btn_Proximo.TabIndex = 5;
            this.btn_Proximo.Text = "Próximo";
            this.btn_Proximo.UseVisualStyleBackColor = true;
            this.btn_Proximo.Click += new System.EventHandler(this.btn_Proximo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Livro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Capitulo:";
            // 
            // lbl_Dia
            // 
            this.lbl_Dia.AutoSize = true;
            this.lbl_Dia.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Dia.Location = new System.Drawing.Point(96, 63);
            this.lbl_Dia.Name = "lbl_Dia";
            this.lbl_Dia.Size = new System.Drawing.Size(45, 25);
            this.lbl_Dia.TabIndex = 9;
            this.lbl_Dia.Text = "000";
            // 
            // lbl_LivroA
            // 
            this.lbl_LivroA.AutoSize = true;
            this.lbl_LivroA.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_LivroA.Location = new System.Drawing.Point(95, 110);
            this.lbl_LivroA.Name = "lbl_LivroA";
            this.lbl_LivroA.Size = new System.Drawing.Size(57, 25);
            this.lbl_LivroA.TabIndex = 10;
            this.lbl_LivroA.Text = "Livro";
            // 
            // lbl_CapituloA
            // 
            this.lbl_CapituloA.AutoSize = true;
            this.lbl_CapituloA.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CapituloA.Location = new System.Drawing.Point(95, 155);
            this.lbl_CapituloA.Name = "lbl_CapituloA";
            this.lbl_CapituloA.Size = new System.Drawing.Size(87, 25);
            this.lbl_CapituloA.TabIndex = 11;
            this.lbl_CapituloA.Text = "Capítulo";
            // 
            // lbl_CapituloB
            // 
            this.lbl_CapituloB.AutoSize = true;
            this.lbl_CapituloB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CapituloB.Location = new System.Drawing.Point(219, 155);
            this.lbl_CapituloB.Name = "lbl_CapituloB";
            this.lbl_CapituloB.Size = new System.Drawing.Size(87, 25);
            this.lbl_CapituloB.TabIndex = 13;
            this.lbl_CapituloB.Text = "Capítulo";
            // 
            // lbl_LivroB
            // 
            this.lbl_LivroB.AutoSize = true;
            this.lbl_LivroB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_LivroB.Location = new System.Drawing.Point(219, 110);
            this.lbl_LivroB.Name = "lbl_LivroB";
            this.lbl_LivroB.Size = new System.Drawing.Size(57, 25);
            this.lbl_LivroB.TabIndex = 12;
            this.lbl_LivroB.Text = "Livro";
            // 
            // lbl_CapituloC
            // 
            this.lbl_CapituloC.AutoSize = true;
            this.lbl_CapituloC.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CapituloC.Location = new System.Drawing.Point(342, 155);
            this.lbl_CapituloC.Name = "lbl_CapituloC";
            this.lbl_CapituloC.Size = new System.Drawing.Size(87, 25);
            this.lbl_CapituloC.TabIndex = 15;
            this.lbl_CapituloC.Text = "Capítulo";
            // 
            // lbl_LivroC
            // 
            this.lbl_LivroC.AutoSize = true;
            this.lbl_LivroC.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_LivroC.Location = new System.Drawing.Point(342, 110);
            this.lbl_LivroC.Name = "lbl_LivroC";
            this.lbl_LivroC.Size = new System.Drawing.Size(57, 25);
            this.lbl_LivroC.TabIndex = 14;
            this.lbl_LivroC.Text = "Livro";
            // 
            // Frm_Robert_Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 243);
            this.Controls.Add(this.lbl_CapituloC);
            this.Controls.Add(this.lbl_LivroC);
            this.Controls.Add(this.lbl_CapituloB);
            this.Controls.Add(this.lbl_LivroB);
            this.Controls.Add(this.lbl_CapituloA);
            this.Controls.Add(this.lbl_LivroA);
            this.Controls.Add(this.lbl_Dia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Proximo);
            this.Controls.Add(this.btn_Anterior);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.txt_Dia);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_Robert_Consultar";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Leitura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Dia;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.Button btn_Anterior;
        private System.Windows.Forms.Button btn_Proximo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Dia;
        private System.Windows.Forms.Label lbl_LivroA;
        private System.Windows.Forms.Label lbl_CapituloA;
        private System.Windows.Forms.Label lbl_CapituloB;
        private System.Windows.Forms.Label lbl_LivroB;
        private System.Windows.Forms.Label lbl_CapituloC;
        private System.Windows.Forms.Label lbl_LivroC;
    }
}