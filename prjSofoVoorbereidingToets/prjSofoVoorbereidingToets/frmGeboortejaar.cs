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
    public partial class frmGeboortejaar : Form {
        public frmGeboortejaar() {
            InitializeComponent();
        }

        private void btnGeboortejaar_Click(object sender, EventArgs e) {
            //var
            int intLeeftijd, intJaar, intGeboortejaar;
            DateTime today = DateTime.Today;

            //input
            intLeeftijd = Convert.ToInt16(txtLeeftijd.Text);
            intJaar = today.Year;
            intGeboortejaar = intJaar - intLeeftijd;

            //output
            lblGeboortejaar.Text = intGeboortejaar.ToString();
        }
    }
}
