namespace MediaCalc
{
    partial class Frm_CarregarMedia
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
            this.txt_consulta = new System.Windows.Forms.TextBox();
            this.btn_Carregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NomeArq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_consulta
            // 
            this.txt_consulta.Location = new System.Drawing.Point(21, 78);
            this.txt_consulta.Multiline = true;
            this.txt_consulta.Name = "txt_consulta";
            this.txt_consulta.Size = new System.Drawing.Size(447, 438);
            this.txt_consulta.TabIndex = 0;
            // 
            // btn_Carregar
            // 
            this.btn_Carregar.Location = new System.Drawing.Point(93, 38);
            this.btn_Carregar.Name = "btn_Carregar";
            this.btn_Carregar.Size = new System.Drawing.Size(279, 23);
            this.btn_Carregar.TabIndex = 1;
            this.btn_Carregar.Text = "Carregar arquivo";
            this.btn_Carregar.UseVisualStyleBackColor = true;
            this.btn_Carregar.Click += new System.EventHandler(this.btn_Carregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite o nome do arquivo sem a extensão:";
            // 
            // txt_NomeArq
            // 
            this.txt_NomeArq.Location = new System.Drawing.Point(285, 12);
            this.txt_NomeArq.Name = "txt_NomeArq";
            this.txt_NomeArq.Size = new System.Drawing.Size(100, 20);
            this.txt_NomeArq.TabIndex = 3;
            // 
            // Frm_CarregarMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(494, 528);
            this.Controls.Add(this.txt_NomeArq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Carregar);
            this.Controls.Add(this.txt_consulta);
            this.Name = "Frm_CarregarMedia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_CarregarMedia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_consulta;
        private System.Windows.Forms.Button btn_Carregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NomeArq;
    }
}