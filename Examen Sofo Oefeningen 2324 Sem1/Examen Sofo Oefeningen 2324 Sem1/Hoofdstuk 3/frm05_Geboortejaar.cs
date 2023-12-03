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
    public partial class frm05_Geboortejaar : Form {
        public frm05_Geboortejaar() {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, EventArgs e) {
            int intLeeftijd = Convert.ToInt16(txtLeeftijd.Text);

            int intGeboortejaar = DateTime.Now.Year - intLeeftijd;

            lblGeboortejaar.Text = intGeboortejaar.ToString();
        }
    }
}
