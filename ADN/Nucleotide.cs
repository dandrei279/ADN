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
    public partial class Nucleotide : Form {

        private int selectedInfo = 1003;

        public Nucleotide() {
            InitializeComponent();
        }

        private void hide_show_All (TextBox t, bool v) {
            foreach (Control c in this.Controls) {
                var text = c as TextBox;
                if (text != null && text != adnTextBox && text != t) {
                    text.ReadOnly = v;
                }
            }
        }

        private void clear() {
            foreach (Control c in this.Controls) {
                var foo = c as TextBox;
                if (foo != null) {
                    foo.Text = "";
                }
            }
            this.ActiveControl = adnTextBox;
        }

        private void aTextBox_TextChanged(object sender, EventArgs e) {
            if (aTextBox.Text != "") {
                hide_show_All(aTextBox, true);
                selectedInfo = 1;
            }
            else {
                hide_show_All(aTextBox, false);
                selectedInfo = 1003;
            }
        }

        private void a2TextBox_TextChanged(object sender, EventArgs e) {
            if (a2TextBox.Text != "") {
                hide_show_All(a2TextBox, true);
                selectedInfo = 2;
            }
            else {
                hide_show_All(a2TextBox, false);
                selectedInfo = 1003;
            }
        }

        private void tTextBox_TextChanged(object sender, EventArgs e) {
            if (tTextBox.Text != "") {
                hide_show_All(tTextBox, true);
                selectedInfo = 3;
            }
            else {
                hide_show_All(tTextBox, false);
                selectedInfo = 1003;
            }
        }

        private void t2TextBox_TextChanged(object sender, EventArgs e) {
            if (t2TextBox.Text != "") {
                hide_show_All(t2TextBox, true);
                selectedInfo = 4;
            }
            else {
                hide_show_All(t2TextBox, false);
                selectedInfo = 1003;
            }
        }

        private void cTextBox_TextChanged(object sender, EventArgs e) {
            if (cTextBox.Text != "") {
                hide_show_All(cTextBox, true);
                selectedInfo = 5;
            }
            else {
                hide_show_All(cTextBox, false);
                selectedInfo = 1003;
            }
        }

        private void c2TextBox_TextChanged(object sender, EventArgs e) {
            if (c2TextBox.Text != "") {
                hide_show_All(c2TextBox, true);
                selectedInfo = 6;
            }
            else {
                hide_show_All(c2TextBox, false);
                selectedInfo = 1003;
            }
        }

        private void gTextBox_TextChanged(object sender, EventArgs e) {
            if (gTextBox.Text != "") {
                hide_show_All(gTextBox, true);
                selectedInfo = 7;
            }
            else {
                hide_show_All(gTextBox, false);
                selectedInfo = 1003;
            }
        }

        private void g2TextBox_TextChanged(object sender, EventArgs e) {
            if (g2TextBox.Text != "") {
                hide_show_All(g2TextBox, true);
                selectedInfo = 8;
            }
            else {
                hide_show_All(g2TextBox, false);
                selectedInfo = 1003;
            }
        }

        private void l2TextBox_TextChanged(object sender, EventArgs e) {
            if (l2TextBox.Text != "") {
                hide_show_All(l2TextBox, true);
                selectedInfo = 9;
            }
            else {
                hide_show_All(l2TextBox, false);
                selectedInfo = 1003;
            }
        }

        private void l3TextBox_TextChanged(object sender, EventArgs e) {
            if (l3TextBox.Text != "") {
                hide_show_All(l3TextBox, true);
                selectedInfo = 10;
            }
            else {
                hide_show_All(l3TextBox, false);
                selectedInfo = 1003;
            }
        }

        private void calcButton_Click(object sender, EventArgs e) {
            if (adnTextBox.Text == "") {
                MessageBox.Show("Introdu numărul nucleotidelor din ADN!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!aTextBox.ReadOnly && !a2TextBox.ReadOnly) {
                MessageBox.Show("Introdu cel puțin o informație referitoare la structura ADN-ului!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                int adn = Convert.ToInt32(adnTextBox.Text);
                switch (selectedInfo) {
                    case 1: {
                            int a = Convert.ToInt32(aTextBox.Text);
                            if (a > 50) {
                                MessageBox.Show("Date incorecte!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                clear();
                                break;
                            }
                            int c = 50 - a;
                            tTextBox.Text = aTextBox.Text;
                            cTextBox.Text = gTextBox.Text = c.ToString();
                            a2TextBox.Text = t2TextBox.Text = l2TextBox.Text = (a * adn / 100).ToString();
                            c2TextBox.Text = g2TextBox.Text = l3TextBox.Text = (c * adn / 100).ToString();
                        }
                        break;
                    case 2: {
                            int a = Convert.ToInt32(a2TextBox.Text);
                            if (a > adn / 2) {
                                MessageBox.Show("Date incorecte!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                clear();
                                break;
                            }
                            int c = adn / 2 - a;
                            l2TextBox.Text = t2TextBox.Text = a2TextBox.Text;
                            c2TextBox.Text = g2TextBox.Text = l3TextBox.Text = c.ToString();
                            aTextBox.Text = tTextBox.Text = (a * 100 / adn).ToString();
                            cTextBox.Text = gTextBox.Text = (c * 100 / adn).ToString();
                        }
                        break;
                    case 3: {
                            int t = Convert.ToInt32(tTextBox.Text);
                            if (t > 50) {
                                MessageBox.Show("Date incorecte!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                clear();
                                break;
                            }
                            int c = 50 - t;
                            aTextBox.Text = tTextBox.Text;
                            cTextBox.Text = gTextBox.Text = c.ToString();
                            a2TextBox.Text = t2TextBox.Text = l2TextBox.Text = (t * adn / 100).ToString();
                            c2TextBox.Text = g2TextBox.Text = l3TextBox.Text = (c * adn / 100).ToString();
                        }
                        break;
                    case 4: {
                            int a = Convert.ToInt32(t2TextBox.Text);
                            if (a > adn / 2) {
                                MessageBox.Show("Date incorecte!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                clear();
                                break;
                            }
                            int c = adn / 2 - a;
                            l2TextBox.Text = a2TextBox.Text = t2TextBox.Text;
                            c2TextBox.Text = g2TextBox.Text = l3TextBox.Text = c.ToString();
                            aTextBox.Text = tTextBox.Text = (a * 100 / adn).ToString();
                            cTextBox.Text = gTextBox.Text = (c * 100 / adn).ToString();
                        }
                        break;
                    case 5: {
                            int c = Convert.ToInt32(cTextBox.Text);
                            if (c > 50) {
                                MessageBox.Show("Date incorecte!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                clear();
                                break;
                            }
                            int a = 50 - c;
                            gTextBox.Text = cTextBox.Text;
                            aTextBox.Text = tTextBox.Text = a.ToString();
                            a2TextBox.Text = t2TextBox.Text = l2TextBox.Text = (a * adn / 100).ToString();
                            c2TextBox.Text = g2TextBox.Text = l3TextBox.Text = (c * adn / 100).ToString();
                        }
                        break;
                    case 6: {
                            int c = Convert.ToInt32(c2TextBox.Text);
                            if (c > adn / 2) {
                                MessageBox.Show("Date incorecte!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                clear();
                                break;
                            }
                            int a = adn / 2 - c;
                            l3TextBox.Text = g2TextBox.Text = c2TextBox.Text;
                            l2TextBox.Text = a2TextBox.Text = t2TextBox.Text = a.ToString();
                            aTextBox.Text = tTextBox.Text = (a * 100 / adn).ToString();
                            cTextBox.Text = gTextBox.Text = (c * 100 / adn).ToString();
                        }
                        break;
                    case 7: {
                            int g = Convert.ToInt32(gTextBox.Text);
                            if (g > 50) {
                                MessageBox.Show("Date incorecte!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                clear();
                                break;
                            }
                            int a = 50 - g;
                            cTextBox.Text = gTextBox.Text;
                            aTextBox.Text = tTextBox.Text = a.ToString();
                            a2TextBox.Text = t2TextBox.Text = l2TextBox.Text = (a * adn / 100).ToString();
                            c2TextBox.Text = g2TextBox.Text = l3TextBox.Text = (g * adn / 100).ToString();
                        }
                        break;
                    case 8: {
                            int c = Convert.ToInt32(g2TextBox.Text);
                            if (c > adn / 2) {
                                MessageBox.Show("Date incorecte!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                clear();
                                break;
                            }
                            int a = adn / 2 - c;
                            l3TextBox.Text = c2TextBox.Text = g2TextBox.Text;
                            l2TextBox.Text = a2TextBox.Text = t2TextBox.Text = a.ToString();
                            aTextBox.Text = tTextBox.Text = (a * 100 / adn).ToString();
                            cTextBox.Text = gTextBox.Text = (c * 100 / adn).ToString();
                        }
                        break;
                    case 9: {
                            int a = Convert.ToInt32(l2TextBox.Text);
                            if (a > adn / 2) {
                                MessageBox.Show("Date incorecte!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                clear();
                                break;
                            }
                            int c = adn / 2 - a;
                            t2TextBox.Text = a2TextBox.Text = l2TextBox.Text;
                            c2TextBox.Text = g2TextBox.Text = l3TextBox.Text = c.ToString();
                            aTextBox.Text = tTextBox.Text = (a * 100 / adn).ToString();
                            cTextBox.Text = gTextBox.Text = (c * 100 / adn).ToString();
                        }
                        break;
                    case 10: {
                            int c = Convert.ToInt32(l3TextBox.Text);
                            if (c > adn / 2) {
                                MessageBox.Show("Date incorecte!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                clear();
                                break;
                            }
                            int a = adn / 2 - c;
                            g2TextBox.Text = c2TextBox.Text = l3TextBox.Text;
                            l2TextBox.Text = a2TextBox.Text = t2TextBox.Text = a.ToString();
                            aTextBox.Text = tTextBox.Text = (a * 100 / adn).ToString();
                            cTextBox.Text = gTextBox.Text = (c * 100 / adn).ToString();
                        }
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            clear();
        }
    }
}
