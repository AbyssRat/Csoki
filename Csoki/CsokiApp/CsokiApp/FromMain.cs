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

namespace CsokiApp
{
    public partial class FormMain : Form
    {
        BindingList<Csokolade> csokiLista = new BindingList<Csokolade>();
        public FormMain()
        {
            InitializeComponent();
            ListBoxCsokik.DataSource = csokiLista;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void csokikSzerzéseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV fájl|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                csokiLista.Clear();

                var sorok = File.ReadAllLines(ofd.FileName).Skip(1);

                foreach (var sor in sorok)
                {
                    var adatok = sor.Split(' ');

                    Csokolade csoki = new Csokolade
                    {
                        Nev = adatok[0],
                        Kategoria = adatok[1],
                        Iz = adatok[2],
                        Tomeg = int.Parse(adatok[3]),
                        Ar = double.Parse(adatok[4]),
                        Alkoholos = bool.Parse(adatok[5]),
                        Vegan = bool.Parse(adatok[6])
                    };

                    csokiLista.Add(csoki);
                }
                FrissitStatisztika();
            }
        }

        private void újCsokiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdatbevitel adatbevitel = new FormAdatbevitel();
            if(adatbevitel.ShowDialog() == DialogResult.OK)
            {
                csokiLista.Add(adatbevitel.UjCsoki);
                FrissitStatisztika();
            }
        }

        private void FrissitStatisztika()
        {
            label1.Text = $"Átlagár: {csokiLista.Average(c => c.Ar):0.00} EUR";
            label2.Text = $"Összesen: {csokiLista.Count} db";
        }
}
}
