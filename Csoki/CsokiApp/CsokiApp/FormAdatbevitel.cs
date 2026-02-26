using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsokiApp
{
    public partial class FormAdatbevitel : Form
    {
        public Csokolade UjCsoki { get; private set; }
        public FormAdatbevitel()
        {
            InitializeComponent();

            comboBoxKateg.Items.AddRange(new string[]
            { 
                "Tejcsokoládé",
                "Étcsokoládé",
                "Fehér csokoládé",
                "Praliné"
            });

            buttonMentes.Enabled = false;

        }

        private void textBoxIz_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNev_TextChanged(object sender, EventArgs e)
        {
            buttonMentes.Enabled = !string.IsNullOrWhiteSpace(textBoxNev.Text);
        }

        private void buttonMentes_Click(object sender, EventArgs e)
        {
            UjCsoki = new Csokolade
            {
                Nev = textBoxNev.Text,
                Kategoria = comboBoxKateg.SelectedItem.ToString(),
                Iz = textBoxIz.Text,
                Tomeg = (int)numericUpDownTomeg.Value,
                Ar = (double)numericUpDownAr.Value,
                Alkoholos = checkBoxAlkoholos.Checked,
                Vegan = checkBoxVegan.Checked
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        

        private void checkBoxVegan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxAlkoholos_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
