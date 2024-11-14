using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MediaCalc
{
    public partial class Frm_Menu_Principal : Form
    {
        public Frm_Menu_Principal()
        {
            InitializeComponent();
        }

        private void btn_sobre_Click(object sender, EventArgs e)
        {
            Frm_AboutBox Frm_sobre = new Frm_AboutBox();
            Frm_sobre.ShowDialog();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            Frm_CalcMedia Frm_Calcular = new Frm_CalcMedia();
            Frm_Calcular.Show();
        }

        private void calcularMédiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CalcMedia Frm_Calcular = new Frm_CalcMedia();
            Frm_Calcular.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CalcMedia Frm_alterar = new Frm_CalcMedia();
            Frm_alterar.Show();
        }
        DialogResult resposta;
        void Sair()
        {
            resposta =
                MessageBox.Show("Deseja encerrar a aplicação?", "Saindo?", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                Frm_CalcMedia SplashScreen = new Frm_CalcMedia();
                SplashScreen.Close();
                this.Close();
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_AboutBox Frm_sobre = new Frm_AboutBox();
            Frm_sobre.ShowDialog();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            Frm_CalcMedia alt_media = new Frm_CalcMedia();
            alt_media.Show();
        }

        private void btn_carregar_Click(object sender, EventArgs e)
        {
            Frm_CarregarMedia Carregar_Media = new Frm_CarregarMedia();
            Carregar_Media.Show();
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            Frm_DeletarMedia Deletar_Media = new Frm_DeletarMedia();
            Deletar_Media.Show();
        }

        private void alterarMédiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CarregarMedia Carregar = new Frm_CarregarMedia();
            Carregar.Show();
        }

        private void carregarMédiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DeletarMedia Deletar = new Frm_DeletarMedia();
            Deletar.Show();
        }

        private void deletarMédiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sair();
        }
    }
}
