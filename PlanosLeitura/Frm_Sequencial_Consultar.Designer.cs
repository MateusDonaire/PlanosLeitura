
namespace PlanosLeitura
{
    partial class Frm_Sequencial_Consultar
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
            this.lbl_Livro = new System.Windows.Forms.Label();
            this.lbl_Capitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Dia:";
            // 
            // txt_Dia
            // 
            this.txt_Dia.Location = new System.Drawing.Point(99, 49);
            this.txt_Dia.Name = "txt_Dia";
            this.txt_Dia.Size = new System.Drawing.Size(65, 23);
            this.txt_Dia.TabIndex = 1;
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(12, 12);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_Voltar.TabIndex = 2;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Location = new System.Drawing.Point(174, 49);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(75, 23);
            this.btn_Pesquisar.TabIndex = 3;
            this.btn_Pesquisar.Text = "Pesquisar";
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // btn_Anterior
            // 
            this.btn_Anterior.Location = new System.Drawing.Point(12, 282);
            this.btn_Anterior.Name = "btn_Anterior";
            this.btn_Anterior.Size = new System.Drawing.Size(75, 23);
            this.btn_Anterior.TabIndex = 4;
            this.btn_Anterior.Text = "Anterior";
            this.btn_Anterior.UseVisualStyleBackColor = true;
            // 
            // btn_Proximo
            // 
            this.btn_Proximo.Location = new System.Drawing.Point(174, 282);
            this.btn_Proximo.Name = "btn_Proximo";
            this.btn_Proximo.Size = new System.Drawing.Size(75, 23);
            this.btn_Proximo.TabIndex = 5;
            this.btn_Proximo.Text = "Próximo";
            this.btn_Proximo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Livro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Capitulo:";
            // 
            // lbl_Dia
            // 
            this.lbl_Dia.AutoSize = true;
            this.lbl_Dia.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Dia.Location = new System.Drawing.Point(99, 113);
            this.lbl_Dia.Name = "lbl_Dia";
            this.lbl_Dia.Size = new System.Drawing.Size(45, 25);
            this.lbl_Dia.TabIndex = 9;
            this.lbl_Dia.Text = "000";
            // 
            // lbl_Livro
            // 
            this.lbl_Livro.AutoSize = true;
            this.lbl_Livro.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Livro.Location = new System.Drawing.Point(98, 160);
            this.lbl_Livro.Name = "lbl_Livro";
            this.lbl_Livro.Size = new System.Drawing.Size(57, 25);
            this.lbl_Livro.TabIndex = 10;
            this.lbl_Livro.Text = "Livro";
            // 
            // lbl_Capitulo
            // 
            this.lbl_Capitulo.AutoSize = true;
            this.lbl_Capitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Capitulo.Location = new System.Drawing.Point(98, 205);
            this.lbl_Capitulo.Name = "lbl_Capitulo";
            this.lbl_Capitulo.Size = new System.Drawing.Size(87, 25);
            this.lbl_Capitulo.TabIndex = 11;
            this.lbl_Capitulo.Text = "Capítulo";
            // 
            // Frm_Sequencial_Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 322);
            this.Controls.Add(this.lbl_Capitulo);
            this.Controls.Add(this.lbl_Livro);
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
            this.Name = "Frm_Sequencial_Consultar";
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
        private System.Windows.Forms.Label lbl_Livro;
        private System.Windows.Forms.Label lbl_Capitulo;
    }
}