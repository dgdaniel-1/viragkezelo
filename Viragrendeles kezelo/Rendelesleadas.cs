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
    public partial class Rendelesleadas : Form
    {
        internal Virag[] viragok = new Virag[File.ReadAllLines("adat.csv").Length];
        internal string Rendeles()
        {
            return $"Virag: {viragvalasztoCbx.Text}; Darab: {hanydarabCbx.Text}; Ar: {aktualisarLbl.Text}";
        }
        public Rendelesleadas()
        { 
            InitializeComponent();
            string[] source = new string[File.Exists("adat.csv") ? File.ReadAllLines("adat.csv").Length : 0];
            if (File.Exists("adat.csv"))
            {
                StreamReader reader = new StreamReader("adat.csv");
                for (int i = 0; i < File.ReadAllLines("adat.csv").Length; i++)
                {
                    string[] sor = reader.ReadLine().Split(';');
                    Virag virag = new Virag(sor[0], Convert.ToInt32(sor[1]));
                    viragok[i] = virag;
                    source[i] = sor[0];
                }
                reader.Close();
            }
            viragvalasztoCbx.DataSource = source;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            
            string rendeles = $"Virag: {viragvalasztoCbx.Text}";
        }

        private void hanydarabCbx_TextChanged(object sender, EventArgs e)
        {
            if (hanydarabCbx.Text != "")
            {
                int osszeg = viragok[viragvalasztoCbx.SelectedIndex].Rendelesar(Convert.ToInt32(hanydarabCbx.Text));
                aktualisarLbl.Text = $"{osszeg} Ft";
            }
            else
            {
                aktualisarLbl.Text = "";
            }
        }

        private void viragvalasztoCbx_SelectedValueChanged(object sender, EventArgs e)
        {
            if (hanydarabCbx.Text != "")
            {
                int osszeg = viragok[viragvalasztoCbx.SelectedIndex].Rendelesar(Convert.ToInt32(hanydarabCbx.Text));
                aktualisarLbl.Text = $"{osszeg} Ft";
            }
            else
            {
                aktualisarLbl.Text = "";
            }
        }

        private void hanydarabCbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }
    }
}
