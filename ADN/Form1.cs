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
    public partial class Form1 : Form {
        string versionNumber = "1.0";

        public Form1() {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e) {
            this.Close();
            Application.Exit();
        }

        private void cButton_Click(object sender, EventArgs e) {
            Replicare_Catena f = new Replicare_Catena();
            f.Show();
        }

        private void nButton_Click(object sender, EventArgs e) {
            Nucleotide f = new Nucleotide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e) {
            MessageBox.Show("Developer: Andrei David\nVersion: " + versionNumber, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e) {
            MessageBox.Show("Acest program are doua zone:\n1. \"Calcul Nucleotide\" unde se poate calcula număul " +
                "nucleotidelor dintr-o catenă de ADN.\n2. \"Replicare catenă\" unde se poate replica o catenă și se pot decoda " +
                "aminoacizii care alcatuiesc catena.", "Ajutor", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
