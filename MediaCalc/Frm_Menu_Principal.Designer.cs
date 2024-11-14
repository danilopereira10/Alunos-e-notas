namespace MediaCalc
{
    partial class Frm_Menu_Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularMédiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarMédiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carregarMédiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarMédiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_carregar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_sobre = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "CalcMedia";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(355, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcularMédiaToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.alterarMédiaToolStripMenuItem,
            this.carregarMédiaToolStripMenuItem,
            this.deletarMédiaToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // calcularMédiaToolStripMenuItem
            // 
            this.calcularMédiaToolStripMenuItem.Name = "calcularMédiaToolStripMenuItem";
            this.calcularMédiaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.calcularMédiaToolStripMenuItem.Text = "Cadastrar Média";
            this.calcularMédiaToolStripMenuItem.Click += new System.EventHandler(this.calcularMédiaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.sairToolStripMenuItem.Text = "Alterar Média";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.sobreToolStripMenuItem.Text = "Sobre...";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // alterarMédiaToolStripMenuItem
            // 
            this.alterarMédiaToolStripMenuItem.Name = "alterarMédiaToolStripMenuItem";
            this.alterarMédiaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.alterarMédiaToolStripMenuItem.Text = "Carregar Média";
            this.alterarMédiaToolStripMenuItem.Click += new System.EventHandler(this.alterarMédiaToolStripMenuItem_Click);
            // 
            // carregarMédiaToolStripMenuItem
            // 
            this.carregarMédiaToolStripMenuItem.Name = "carregarMédiaToolStripMenuItem";
            this.carregarMédiaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.carregarMédiaToolStripMenuItem.Text = "Deletar Média";
            this.carregarMédiaToolStripMenuItem.Click += new System.EventHandler(this.carregarMédiaToolStripMenuItem_Click);
            // 
            // deletarMédiaToolStripMenuItem
            // 
            this.deletarMédiaToolStripMenuItem.Name = "deletarMédiaToolStripMenuItem";
            this.deletarMédiaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.deletarMédiaToolStripMenuItem.Text = "Sair";
            this.deletarMédiaToolStripMenuItem.Click += new System.EventHandler(this.deletarMédiaToolStripMenuItem_Click);
            // 
            // btn_carregar
            // 
            this.btn_carregar.BackgroundImage = global::MediaCalc.Properties.Resources.Loading_3;
            this.btn_carregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_carregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_carregar.Location = new System.Drawing.Point(188, 73);
            this.btn_carregar.Name = "btn_carregar";
            this.btn_carregar.Size = new System.Drawing.Size(126, 102);
            this.btn_carregar.TabIndex = 6;
            this.btn_carregar.Text = "Carregar Média";
            this.btn_carregar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_carregar.UseVisualStyleBackColor = true;
            this.btn_carregar.Click += new System.EventHandler(this.btn_carregar_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.BackgroundImage = global::MediaCalc.Properties.Resources.deletar;
            this.btn_deletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_deletar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_deletar.Location = new System.Drawing.Point(155, 185);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(79, 141);
            this.btn_deletar.TabIndex = 5;
            this.btn_deletar.Text = "Deletar Média";
            this.btn_deletar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackgroundImage = global::MediaCalc.Properties.Resources.Alterar;
            this.btn_alterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_alterar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.Location = new System.Drawing.Point(27, 73);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(135, 102);
            this.btn_alterar.TabIndex = 4;
            this.btn_alterar.Text = "Alterar Médias";
            this.btn_alterar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.BackgroundImage = global::MediaCalc.Properties.Resources.calcular_media;
            this.btn_Calcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Calcular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Location = new System.Drawing.Point(27, 185);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(113, 141);
            this.btn_Calcular.TabIndex = 1;
            this.btn_Calcular.Text = "Cadastrar Média";
            this.btn_Calcular.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_sobre
            // 
            this.btn_sobre.BackgroundImage = global::MediaCalc.Properties.Resources.btn_sobre;
            this.btn_sobre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sobre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sobre.Location = new System.Drawing.Point(253, 185);
            this.btn_sobre.Name = "btn_sobre";
            this.btn_sobre.Size = new System.Drawing.Size(61, 141);
            this.btn_sobre.TabIndex = 0;
            this.btn_sobre.Text = "Sobre";
            this.btn_sobre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_sobre.UseVisualStyleBackColor = true;
            this.btn_sobre.Click += new System.EventHandler(this.btn_sobre_Click);
            // 
            // Frm_Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(355, 338);
            this.Controls.Add(this.btn_carregar);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.btn_sobre);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Menu_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalcMedia";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sobre;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularMédiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_carregar;
        private System.Windows.Forms.ToolStripMenuItem alterarMédiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carregarMédiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletarMédiaToolStripMenuItem;
    }
}