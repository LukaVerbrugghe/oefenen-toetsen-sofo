using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSofoVoorbereidingToets
{
    public partial class frmIngebouwdeFuncties : Form
    {
        public frmIngebouwdeFuncties()
        {
            InitializeComponent();
        }

        private void btnOef3_Click(object sender, EventArgs e) {
            //oefening 3 openen
            frmIngebouwdeFuncties_GrootsteGetal frmIngebouwdeFuncties_GrootsteGetal = new frmIngebouwdeFuncties_GrootsteGetal();
            frmIngebouwdeFuncties_GrootsteGetal.Show();
        }

        private void button1_Click(object sender, EventArgs e) {
            frmDatumVoluit frmDatumVoluit = new frmDatumVoluit();
            frmDatumVoluit.Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            frmGeboortejaar frmGeboortejaar = new frmGeboortejaar();
            frmGeboortejaar.Show();
        }

        private void button3_Click(object sender, EventArgs e) {
            frmOnderhoudAuto frmOnderhoudAuto = new frmOnderhoudAuto();
            frmOnderhoudAuto.Show();
        }
    }
}
