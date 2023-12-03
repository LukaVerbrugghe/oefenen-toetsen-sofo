using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Sofo_Oefeningen_2324_Sem1.Hoofdstuk_1 {
    public partial class frmOefening1 : Form {
        public frmOefening1() {
            InitializeComponent();
        }

        private void btnTekstkleur_Click(object sender, EventArgs e) {
            txtNaam.ForeColor = Color.Green;
        }

        private void btnClear_Click(object sender, EventArgs e) {
            txtNaam.Clear();
            txtNaam.Focus();
        }

        private void btnAchtergrondkleur_Click(object sender, EventArgs e) {
            txtNaam.BackColor = Color.Red;
        }

        private void btnSluit_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
