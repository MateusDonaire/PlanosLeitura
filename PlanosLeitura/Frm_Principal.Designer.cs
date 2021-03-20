
namespace PlanosLeitura
{
    partial class Frm_Principal
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
            this.btn_Sequencial = new System.Windows.Forms.Button();
            this.btn_Robert = new System.Windows.Forms.Button();
            this.lbl_Principal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Sequencial
            // 
            this.btn_Sequencial.Location = new System.Drawing.Point(68, 99);
            this.btn_Sequencial.Name = "btn_Sequencial";
            this.btn_Sequencial.Size = new System.Drawing.Size(155, 37);
            this.btn_Sequencial.TabIndex = 0;
            this.btn_Sequencial.Text = "Sequencial";
            this.btn_Sequencial.UseVisualStyleBackColor = true;
            this.btn_Sequencial.Click += new System.EventHandler(this.btn_Sequencial_Click);
            // 
            // btn_Robert
            // 
            this.btn_Robert.Location = new System.Drawing.Point(68, 142);
            this.btn_Robert.Name = "btn_Robert";
            this.btn_Robert.Size = new System.Drawing.Size(155, 37);
            this.btn_Robert.TabIndex = 1;
            this.btn_Robert.Text = "Robert Roberts";
            this.btn_Robert.UseVisualStyleBackColor = true;
            this.btn_Robert.Click += new System.EventHandler(this.btn_Robert_Click);
            // 
            // lbl_Principal
            // 
            this.lbl_Principal.AutoSize = true;
            this.lbl_Principal.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Principal.Location = new System.Drawing.Point(18, 49);
            this.lbl_Principal.Name = "lbl_Principal";
            this.lbl_Principal.Size = new System.Drawing.Size(257, 23);
            this.lbl_Principal.TabIndex = 2;
            this.lbl_Principal.Text = "Qual o plano de Leitura ?";
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 216);
            this.Controls.Add(this.lbl_Principal);
            this.Controls.Add(this.btn_Robert);
            this.Controls.Add(this.btn_Sequencial);
            this.Name = "Frm_Principal";
            this.Text = "Planos de Leitura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sequencial;
        private System.Windows.Forms.Button btn_Robert;
        private System.Windows.Forms.Label lbl_Principal;
    }
}