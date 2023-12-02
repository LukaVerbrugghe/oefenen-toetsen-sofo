using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Sofo_Oefeningen_2324_Sem1 {
    public partial class frmNavigatie : Form {
        public frmNavigatie() {
            InitializeComponent();
        }

        private void btnHoofdstuk1_Click(object sender, EventArgs e) {
            Hoofdstuk_1.frmNavigatieHoofdstuk1 frmNavigatieHoofdstuk1 = new Hoofdstuk_1.frmNavigatieHoofdstuk1();
            frmNavigatieHoofdstuk1.Show();
        }
        private void btnHoofdstuk2_Click(object sender, EventArgs e) {
            Hoofdstuk_2.frmNavigatieHoofdstuk2 frmNavigatieHoofdstuk2 = new Hoofdstuk_2.frmNavigatieHoofdstuk2();
            frmNavigatieHoofdstuk2.Show();
        }

        private void btnHoofdstuk3_Click(object sender, EventArgs e) {
            Hoofdstuk_3.frmNavigatieHoofdstuk3 frmNavigatieHoofdstuk3 = new Hoofdstuk_3.frmNavigatieHoofdstuk3();
            frmNavigatieHoofdstuk3.Show();
        }

        private void btnHoofdstuk4_Click(object sender, EventArgs e) {
            Hoofdstuk_4.frmNavigatieHoofdstuk4 frmNavigatieHoofdstuk4 = new Hoofdstuk_4.frmNavigatieHoofdstuk4();
            frmNavigatieHoofdstuk4.Show();
        }

        private void btnAfsluiten_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
