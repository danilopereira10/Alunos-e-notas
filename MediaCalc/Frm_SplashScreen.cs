using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace MediaCalc
{
    public partial class Frm_SplashScreen : Form
    {
        public Frm_SplashScreen()
        {
            InitializeComponent();
            this.Show();
            Application.DoEvents();
            Thread.Sleep(1000);
            Thread.Sleep(1000);
            Thread.Sleep(1000);
            this.Dispose();
        }


        public void Splash()
        {

        }





    }
}