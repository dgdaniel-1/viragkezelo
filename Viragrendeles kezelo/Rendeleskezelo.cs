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
    public partial class Rendeleskezelo : Form
    {
        public Rendeleskezelo()
        {
            InitializeComponent();
            if (File.Exists("rendelesek.csv"))
            {
                StreamReader reader = new StreamReader("rendelesek.csv");
                for (int i = 0; i < File.ReadAllLines("rendelesek.csv").Length; i++)
                {
                    string[] sor = reader.ReadLine().Split(';');
                    rendelesekLbx.Items.Add($"{sor[0]};{sor[1]};{sor[2]}");
                }
                reader.Close();
            }
        }
        private void rendelesBtn_Click(object sender, EventArgs e)
        {
            Rendelesleadas rendelesleadas = new Rendelesleadas();
            if (rendelesleadas.ShowDialog() == DialogResult.OK)
            {
                rendelesekLbx.Items.Add(rendelesleadas.Rendeles());
            }
        }

        private void rendelestorlesBtn_Click(object sender, EventArgs e)
        {
            if (rendelesekLbx.SelectedIndex != -1 && MessageBox.Show("Biztosan törli a kijelölt elemet?", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                rendelesekLbx.Items.RemoveAt(rendelesekLbx.SelectedIndex);
            }
        }

        private void Rendeleskezelo_FormClosing(object sender, FormClosingEventArgs e)
        {
            {
                if (File.Exists("rendelesek.csv"))
                {
                    File.Delete("rendelesek.csv");
                }
                foreach (var item in rendelesekLbx.Items)
                {
                    File.AppendAllText("rendelesek.csv", (string)item + Environment.NewLine);
                }
            }
        }
    }
}
