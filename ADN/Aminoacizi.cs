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
    public partial class Aminoacizi : Form {
        private string[,,] AA = new string[4, 4, 4] { { { "Phe", "Phe", "Leu", "Leu"},
                                                       { "Ser", "Ser", "Ser", "Ser"},
                                                       { "Tyr", "Tyr", "Stop", "Stop"},
                                                       { "Cys", "Cys", "Stop", "Trp"}
                                                     } ,
                                                     { { "Leu", "Leu", "Leu", "Leu"},
                                                       { "Pro", "Pro", "Pro", "Pro"},
                                                       { "His", "His", "Glu", "Glu"},
                                                       { "Arg", "Arg", "Arg", "Arg"}
                                                     },
                                                     { { "Ile", "Ile", "Ile", "Met"},
                                                       { "Thr", "Thr", "Thr", "Thr"},
                                                       { "Asp", "Asp", "Lys", "Lys"},
                                                       { "Ser", "Ser", "Arg", "Arg"}
                                                     },
                                                     { { "Val", "Val", "Val", "Val"},
                                                       { "Ala", "Ala", "Ala", "Ala"},
                                                       { "AAsp", "AAsp", "AGlu", "AGlu"},
                                                       { "Gly", "Gly", "Gly", "Gly"}
                                                     }
                                                   };

        private string denumire (string input) {
            switch (input) {
                case "Ala": return "Alanina";
                case "Cys": return "Cisteina";
                case "AAsp": return "Acid aspartic";
                case "AGlu": return "Acid glutamic";
                case "Phe": return "Fenilalanina";
                case "Gly": return "Glicina";
                case "His": return "Histidina";
                case "Ile": return "Izoleucina";
                case "Lys": return "Lisina";
                case "Leu": return "Leucina";
                case "Met": return "Metionina";
                case "Asp": return "Asparagina";
                case "Pro": return "Prolina";
                case "Glu": return "Glutamina";
                case "Arg": return "Arginina";
                case "Ser": return "Serina";
                case "Thr": return "Treonina";
                case "Val": return "Valina";
                case "Trp": return "Triptofan";
                case "Tyr": return "Tirosina";
                case "Stop": return "Stop";

                default: return "";
            }
        }

        private int getNr (char c) {
            switch (c) {
                case 'U':
                case 'T': return 0;
                case 'C': return 1;
                case 'A': return 2;
                case 'G': return 3;

                default: return 9;
            }
        }

        private void create (string input) {
            var grupuri = input.Split(' ');
            string s = "";
            foreach (string a in grupuri) {
                if (a != "") {
                    s += denumire(AA[getNr(a[0]), getNr(a[1]), getNr(a[2])]) + " ";
                }
            }
            richTextBox1.Text = s;
        }
        
        public Aminoacizi(string input) {
            InitializeComponent();
            this.ActiveControl = maskedTextBox1;
            if (input != "") {
                maskedTextBox1.Mask = "";
                maskedTextBox1.Text = input;
                maskedTextBox1.ReadOnly = true;
                try {
                    create(input);
                }
                catch (Exception e) {
                    MessageBox.Show("Ups...\nO eroare neașteptată.\n\n" + e.Message);
                }
            }
            else {
                maskedTextBox1.SetBounds(maskedTextBox1.Location.X, maskedTextBox1.Location.Y, maskedTextBox1.Size.Width - 25, maskedTextBox1.Size.Height);
                button1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                create(maskedTextBox1.Text);
            }
            catch (Exception ex) {
                MessageBox.Show("Ups...\nO eroare neașteptată.\n\n" + ex.Message);
            }
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e) {
            if (maskedTextBox1.Text.Length == maskedTextBox1.Mask.Length - 1)
                maskedTextBox1.Mask += " AAA";
            if (maskedTextBox1.Text.Length > 0) {
                char c = maskedTextBox1.Text[maskedTextBox1.Text.Length - 1];
                if (c != 'A' && c != 'T' && c != 'U' && c != 'C' && c != 'G' && c != ' ') {
                    MessageBox.Show("Text invalid", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
