namespace MediaCalc
{
    partial class Frm_DeletarMedia
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
            this.txt_NomeArq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_NomeArq
            // 
            this.txt_NomeArq.Location = new System.Drawing.Point(273, 31);
            this.txt_NomeArq.Name = "txt_NomeArq";
            this.txt_NomeArq.Size = new System.Drawing.Size(100, 20);
            this.txt_NomeArq.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite o nome do arquivo sem a extensão:";
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.Location = new System.Drawing.Point(81, 57);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(279, 23);
            this.btn_Deletar.TabIndex = 4;
            this.btn_Deletar.Text = "Deletar arquivo";
            this.btn_Deletar.UseVisualStyleBackColor = true;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // Frm_DeletarMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(451, 110);
            this.Controls.Add(this.txt_NomeArq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Deletar);
            this.Name = "Frm_DeletarMedia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_DeletarMedia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NomeArq;
    }
}