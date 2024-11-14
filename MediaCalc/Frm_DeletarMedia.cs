using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MediaCalc
{
    public partial class Frm_DeletarMedia : Form
    {
        public Frm_DeletarMedia()
        {
            InitializeComponent();
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            string folder = @"C:\Media\";
            File.Delete(folder + txt_NomeArq.Text + ".txt");
            MessageBox.Show("Arquivo deletado com sucesso!");
        }
    }
}
