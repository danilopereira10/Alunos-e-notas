using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;

namespace MediaCalc
{
    public partial class Frm_CalcMedia : Form
    {
        public Frm_CalcMedia()
        {
            InitializeComponent();
        }

        double nt1, nt2, nt3, nt4, np1, np2, np3, np4, pt1, pt2, pt3, pt4, pp1, pp2, pp3, pp4, m1, m2, m3, m4;
        bool flag_salvar;

        private void txt_nt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_nt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_nt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_nt4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_np1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txt_np2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_np3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_np4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_pt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_pt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_pt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_pt4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_pp1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_pp2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_pp3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_pp4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        public double Calc_Media(double n1, double n2, double n3, double n4)
        {
            double media = (n1 + n2 + n3 + n4) / 4;
            return Math.Round(2*media,2)/2;
        }
        public void validacao_e_calculo_da_media_e_salvar()
        {
            if (txt_nt1.Text.Equals("") || txt_nt2.Text.Equals("") || txt_nt3.Text.Equals("") || txt_nt4.Text.Equals("") ||
                txt_np1.Text.Equals("") || txt_np2.Text.Equals("") || txt_np3.Text.Equals("") || txt_np4.Text.Equals("") || txt_pt1.Text.Equals("") || txt_pt2.Text.Equals("") ||
                txt_pt3.Text.Equals("") || txt_pt4.Text.Equals("") || txt_pp1.Text.Equals("") || txt_pp2.Text.Equals("") || txt_pp3.Text.Equals("") || txt_pp4.Text.Equals("")
                || txt_nome.Text.Equals("") || txt_discip.Text.Equals("") || txt_professor.Text.Equals("") || cmb_serie.Text.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos antes de continuar");
            }
            else
            {
                nt1 = double.Parse(txt_nt1.Text);
                nt2 = double.Parse(txt_nt2.Text);
                nt3 = double.Parse(txt_nt3.Text);
                nt4 = double.Parse(txt_nt4.Text);
                np1 = double.Parse(txt_np1.Text);
                np2 = double.Parse(txt_np2.Text);
                np3 = double.Parse(txt_np3.Text);
                np4 = double.Parse(txt_np4.Text);
                pt1 = double.Parse(txt_pt1.Text);
                pt2 = double.Parse(txt_pt2.Text);
                pt3 = double.Parse(txt_pt3.Text);
                pt4 = double.Parse(txt_pt4.Text);
                pp1 = double.Parse(txt_pp1.Text);
                pp2 = double.Parse(txt_pp2.Text);
                pp3 = double.Parse(txt_pp3.Text);
                pp4 = double.Parse(txt_pp4.Text);
                if (nt1 >= 0 && nt2 >= 0 && nt3 >= 0 && nt4 >= 0 && np1 >= 0 && np2 >= 0 && np3 >= 0 && np4 >= 0 && pp1 >= 0 && pp2 >= 0 && pp3 >= 0 && pp4 >= 0 && pt1 >= 0 && pt2 >= 0 && pt3 >= 0 && pt4 >= 0)
                {
                    m1 = ((nt1 * pt1) + (np1 * pp1)) / (pt1 + pp1);
                    lbl_M1.Text = "Média do 1º Bimestre: " + Math.Round(2 * m1, 2) / 2;
                    m2 = ((nt2 * pt2) + (np2 * pp2)) / (pt2 + pp2);
                    lbl_M2.Text = "Média do 2º Bimestre: " + Math.Round(2 * m2, 2) / 2;
                    m3 = ((nt3 * pt3) + (np3 * pp3)) / (pt3 + pp3);
                    lbl_M3.Text = "Média do 3º Bimestre: " + Math.Round(2 * m3, 2) / 2;
                    m4 = ((nt4 * pt4) + (np4 * pp4)) / (pt4 + pp4);
                    lbl_M4.Text = "Média do 4º Bimestre: " + Math.Round(2 * m4, 2) / 2;
                    lbl_Media.Text = Calc_Media(m1, m2, m3, m4).ToString();
                    lbl_Media.Visible = true;
                    if(flag_salvar == true)
                    {
                        string folder = @"C:\Media"; //nome do diretorio a ser criado
                        int x = 1;
                        //Se o diretório não existir...
                        if (!Directory.Exists(folder))
                        {
                            Directory.CreateDirectory(folder);
                        }

                        string TodoOTexto =

                        "Nome do aluno: " + txt_nome.Text + "\r\r\n" +
                        "Disciplina: " + txt_discip.Text + "\r\n" +
                        "Professor: " + txt_professor.Text + "\r\n" +
                        "Série cursando: " + cmb_serie.Text + "\r\n" + "\r\n" +
                        "1º Bimestre:" + "\r\n" +
                        lbl_nt1.Text + txt_nt1.Text + "\r\n" +
                        lbl_pt1.Text + txt_pt1.Text + "\r\n" +
                        lbl_np1.Text + txt_np1.Text + "\r\n" +
                        lbl_pp1.Text + txt_pp1.Text + "\r\n" + "\r\n" +
                        "2º Bimestre" + "\r\n" +
                        lbl_nt1.Text + txt_nt2.Text + "\r\n" +
                        lbl_pt1.Text + txt_pt2.Text + "\r\n" +
                        lbl_np1.Text + txt_np2.Text + "\r\n" +
                        lbl_pp1.Text + txt_pp2.Text + "\r\n" + "\r\n" +
                        "3º Bimestre" + "\r\n" +
                        lbl_nt1.Text + txt_nt3.Text + "\r\n" +
                        lbl_pt1.Text + txt_pt3.Text + "\r\n" +
                        lbl_np1.Text + txt_np3.Text + "\r\n" +
                        lbl_pp1.Text + txt_pp3.Text + "\r\n" + "\r\n" +
                        "4º Bimestre" + "\r\n" +
                        lbl_nt1.Text + txt_nt4.Text + "\r\n" +
                        lbl_pt1.Text + txt_pt4.Text + "\r\n" +
                        lbl_np1.Text + txt_np4.Text + "\r\n" +
                        lbl_pp1.Text + txt_pp4.Text + "\r\n" + "\r\n" +
                        "Média Anual: " + lbl_Media.Text;

                        if (chk_alterar_media.Checked == false)
                        {
                            for (x = 1; File.Exists(folder + "\\Media" + x + ".txt"); x++)
                            { }
                            File.WriteAllText(folder + "\\Media" + x + ".txt", TodoOTexto);
                            MessageBox.Show("Arquivo salvo com sucesso no endereço C:/Media/Media" + x + ".txt!");
                        }
                        else
                            if (txt_NomeArq.Equals(""))
                        {
                            MessageBox.Show("Digite o nome do arquivo que deseja modificar");
                        }
                        else
                        {
                            File.WriteAllText(folder + txt_NomeArq.Text + ".txt", TodoOTexto);
                            MessageBox.Show("Arquivo " + txt_NomeArq.Text + ".txt foi alterado com sucesso!");
                        }



                    }
                }

                else
                {
                    MessageBox.Show("Erros na digitação das notas. Há notas negativas");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sair();
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

        private void chk_alterar_media_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_alterar_media.Checked == true)
            {
                lbl_alt_media.Visible = true;
                txt_NomeArq.Visible = true;
                btn_gravar.Text = "Atualizar dados";
            }
            else
            {
                lbl_alt_media.Visible = false;
                txt_NomeArq.Visible = false;
                btn_gravar .Text = "Cadastrar dados";
            }
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            flag_salvar = false;
            validacao_e_calculo_da_media_e_salvar();
        }

    
        private void txt_N1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_N2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_N3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_N4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            flag_salvar = true;
            validacao_e_calculo_da_media_e_salvar();
        }

        private void cmb_serie_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Frm_CalcMedia_Load(object sender, EventArgs e)
        {

        }

        private void lbl_1B_Click(object sender, EventArgs e)
        {

        }

        private void txt_discip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsNumber(e.KeyChar) && e.KeyChar != ' ' && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_professor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }




    }
}