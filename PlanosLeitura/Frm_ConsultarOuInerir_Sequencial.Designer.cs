
namespace PlanosLeitura
{
    partial class Frm_ConsultarOuInerir_Sequencial
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
            this.lbl_Principal = new System.Windows.Forms.Label();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Principal
            // 
            this.lbl_Principal.AutoSize = true;
            this.lbl_Principal.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Principal.Location = new System.Drawing.Point(16, 68);
            this.lbl_Principal.Name = "lbl_Principal";
            this.lbl_Principal.Size = new System.Drawing.Size(373, 23);
            this.lbl_Principal.TabIndex = 5;
            this.lbl_Principal.Text = "Consultar leitura ou Inserir no Banco?";
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.Location = new System.Drawing.Point(120, 177);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(155, 37);
            this.btn_Inserir.TabIndex = 4;
            this.btn_Inserir.Text = "Inserir";
            this.btn_Inserir.UseVisualStyleBackColor = true;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Location = new System.Drawing.Point(120, 134);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(155, 37);
            this.btn_Consultar.TabIndex = 3;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // Frm_ConsultarOuInerir_Sequencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 268);
            this.Controls.Add(this.lbl_Principal);
            this.Controls.Add(this.btn_Inserir);
            this.Controls.Add(this.btn_Consultar);
            this.Name = "Frm_ConsultarOuInerir_Sequencial";
            this.Text = "SEQUENCIAL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Principal;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.Button btn_Consultar;
    }
}