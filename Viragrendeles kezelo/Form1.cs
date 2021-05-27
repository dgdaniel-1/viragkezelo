using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viragrendeles_kezelo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void viragfajtaBtn_Click(object sender, EventArgs e)
        {
            Viragfajtak viragfajtak = new Viragfajtak();
            viragfajtak.ShowDialog();
        }

        private void rendeleskezeloBtn_Click(object sender, EventArgs e)
        {
            Rendeleskezelo rendeleskezelo = new Rendeleskezelo();
            rendeleskezelo.ShowDialog();
        }
    }
}
