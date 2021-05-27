using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viragrendeles_kezelo
{
    public partial class Viraghozzaadas : Form
    {
        Virag virag;
        internal Virag Virag 
        { 
            get => virag;
            set
            {
                virag = value;
            } 
        }
        public Viraghozzaadas()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (viragarTxb.Text.Trim() != "" && viragnevTxb.Text.Trim() != "")
            {
                virag = new Virag(viragnevTxb.Text, Convert.ToInt32(viragarTxb.Text));
            }
            else
            {
                MessageBox.Show("A Megnevezés es/vagy ar kitöltése kötelező!", "Figyelmeztetés!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                viragnevTxb.Focus();
                DialogResult = DialogResult.None;
            }
        }

        private void viragarTxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8))
            {
                e.Handled = true; 
            }
        }
    }
}
