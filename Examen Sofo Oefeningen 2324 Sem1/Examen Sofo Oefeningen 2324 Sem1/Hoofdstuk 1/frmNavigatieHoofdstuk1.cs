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
    public partial class frmNavigatieHoofdstuk1 : Form {
        public frmNavigatieHoofdstuk1() {
            InitializeComponent();
        }

        private void btnOefening1_Click(object sender, EventArgs e) {
            frmOefening1 frmOefening1 = new frmOefening1();
            frmOefening1.Show();
        }
    }
}
