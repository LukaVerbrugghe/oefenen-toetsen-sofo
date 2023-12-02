using Examen_Sofo_Oefeningen_2324_Sem1.Hoofdstuk_4._02_Selectie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Sofo_Oefeningen_2324_Sem1.Hoofdstuk_4 {
    public partial class frmNavigatieHoofdstuk4 : Form {
        public frmNavigatieHoofdstuk4() {
            InitializeComponent();
        }

        private void btnSequentie_Click(object sender, EventArgs e) {
            Hoofdstuk_4.Sequentie.frmSequentie frmSequentie = new Sequentie.frmSequentie();
            frmSequentie.Show();
        }

        private void btnSelectie_Click(object sender, EventArgs e) {
            Hoofdstuk_4._02_Selectie.frmSelectie frmSelectie = new _02_Selectie.frmSelectie();
            frmSelectie.Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            Hoofdstuk_4._03_Iteraties.frmIteraties frmIteraties = new _03_Iteraties.frmIteraties();
            frmIteraties.Show();
        }
    }
}
