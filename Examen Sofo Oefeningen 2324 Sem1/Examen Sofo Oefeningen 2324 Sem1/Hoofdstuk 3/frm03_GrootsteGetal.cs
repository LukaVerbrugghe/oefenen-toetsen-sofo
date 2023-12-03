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
    public partial class frm03_GrootsteGetal : Form {
        public frm03_GrootsteGetal() {
            InitializeComponent();
        }

        private void btnZoekGrootste_Click(object sender, EventArgs e) {
            double dblGetal1, dblGetal2, dblGrootste;

            double.TryParse(txtGetal1.Text, out dblGetal1);
            double.TryParse(txtGetal2.Text, out dblGetal2);

            dblGrootste = Math.Max(dblGetal1, dblGetal2);

            lblGrootste.Text = Convert.ToString(dblGrootste);
        }
    }
}
