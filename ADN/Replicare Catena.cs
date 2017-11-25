using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADN {
    public partial class Replicare_Catena : Form {
        public Replicare_Catena() {
            InitializeComponent();
            this.ActiveControl = maskedTextBox1;
        }

        private char nucloeotida_adn (char input) {
            switch (input) {
                case 'A': return 'T';
                case 'T': return 'A';
                case 'C': return 'G';
                case 'G': return 'C';
                default: return input;
            }
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e) {
            if (maskedTextBox1.Text.Length == maskedTextBox1.Mask.Length - 1)
                maskedTextBox1.Mask += " AAA";
            string input = maskedTextBox1.Text, output_adn = "", output_arn = "";
            foreach (char c in input) {
                switch (c) {
                    case 'A':
                    case 'C':
                    case 'G':
                    case 'T':
                    case ' ': {
                            output_adn += nucloeotida_adn(c);
                            output_arn += (c == 'T' ? 'U' : c);
                        };
                        break;
                    default: MessageBox.Show("Text invalid", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            textBox2.Text = output_adn;
            textBox3.Text = output_arn;
        }

        private void calcButton_Click(object sender, EventArgs e) {
            if ((maskedTextBox1.Text.Length % 4 != 0 ||
                maskedTextBox1.Text.Length == 0) &&
                (comboBox.SelectedIndex == 0 ||
                comboBox.SelectedIndex == 1 ||
                comboBox.SelectedIndex == 2)) {
                MessageBox.Show("Catena este alcatuită din mai multe grupuri a câte 3 nucleotide.\nVerifică dacă ai introdus corect catena!",
                    "Catenă invalidă", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                string catena = "";
                switch (comboBox.SelectedIndex) {
                    case 0:
                        catena = maskedTextBox1.Text;
                        break;
                    case 1:
                        catena = textBox2.Text;
                        break;
                    case 2:
                        catena = textBox3.Text;
                        break;
                    case 3:
                        catena = "";
                        break;
                }
                Aminoacizi f = new Aminoacizi(catena);
                f.Show();
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e) {
            calcButton.Enabled = true;
        }
    }
}
