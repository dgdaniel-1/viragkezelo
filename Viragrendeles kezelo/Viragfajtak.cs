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
    public partial class Viragfajtak : Form
    {
        public Viragfajtak()
        {
            InitializeComponent();
            if (File.Exists("adat.csv"))
            {
                StreamReader reader = new StreamReader("adat.csv");
                for (int i = 0; i < File.ReadAllLines("adat.csv").Length; i++)
                {
                    string[] sor = reader.ReadLine().Split(';');
                    Virag virag = new Virag(sor[0], Convert.ToInt32(sor[1]));
                    viragokLbx.Items.Add(virag);

                }
                reader.Close();
            }
        }

        private void hozzaadasBtn_Click(object sender, EventArgs e)
        {
            Viraghozzaadas viraghozzaadas = new Viraghozzaadas();
            if (viraghozzaadas.ShowDialog() == DialogResult.OK)
            {
                viragokLbx.Items.Add(viraghozzaadas.Virag);
            }
        }

        private void eltavolitBtn_Click(object sender, EventArgs e)
        {
            if (viragokLbx.SelectedIndex != -1 && MessageBox.Show("Bistosan torli az elemet?", "Torles", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                viragokLbx.Items.RemoveAt(viragokLbx.SelectedIndex);
            }
        }

        private void Viragfajtak_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists("adat.csv"))
            {
                File.Delete("adat.csv");
            }
            foreach (var item in viragokLbx.Items)
            {
                File.AppendAllText("adat.csv", Virag.CSVFormatum((Virag)item));
            }
        }
    }
}
