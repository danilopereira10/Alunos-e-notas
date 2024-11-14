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
    public partial class Frm_CarregarMedia : Form
    {
        public Frm_CarregarMedia()
        {
            InitializeComponent();
        }

        private void btn_Carregar_Click(object sender, EventArgs e)
        {
            string folder = @"C:\Media\";
            txt_consulta.Text = File.ReadAllText(folder + txt_NomeArq.Text + ".txt");
        }
    }
}
