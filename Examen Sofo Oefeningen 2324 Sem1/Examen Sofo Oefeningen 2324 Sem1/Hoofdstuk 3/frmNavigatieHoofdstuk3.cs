using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Sofo_Oefeningen_2324_Sem1.Hoofdstuk_3 {
    public partial class frmNavigatieHoofdstuk3 : Form {
        public frmNavigatieHoofdstuk3() {
            InitializeComponent();
        }

        private void btnToegangscode_Click(object sender, EventArgs e) {
            frm07_Toegangscode frm07_Toegangscode = new frm07_Toegangscode();
            frm07_Toegangscode.Show();
        }

        private void btnGrootsteGetal_Click(object sender, EventArgs e) {
            frm03_GrootsteGetal frm03_GrootsteGetal = new frm03_GrootsteGetal();
            frm03_GrootsteGetal.Show();
        }

        private void btnGraden_Click(object sender, EventArgs e) {
            frm01_graden frm01_graden = new frm01_graden();
            frm01_graden.Show();
        }

        private void btnGeboortejaar_Click(object sender, EventArgs e) {
            frm05_Geboortejaar frm05_Geboortejaar = new frm05_Geboortejaar();
            frm05_Geboortejaar.Show();
        }
    }
}
