using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSofoVoorbereidingToets {
    public partial class frmIngebouwdeFuncties_GrootsteGetal : Form {
        public frmIngebouwdeFuncties_GrootsteGetal() {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, EventArgs e) {
            //var
            double dblGetal1, dblGetal2, dblGrootsteGetal;

            //invoer
            dblGetal1 = Convert.ToDouble(txtGetal1.Text);
            dblGetal2 = Convert.ToDouble(txtGetal2.Text);

            //verwerking
            dblGrootsteGetal = Math.Max(dblGetal1, dblGetal2);

            //output
            lblGrootsteGetal.Text = dblGrootsteGetal.ToString();
        }
    }
}
