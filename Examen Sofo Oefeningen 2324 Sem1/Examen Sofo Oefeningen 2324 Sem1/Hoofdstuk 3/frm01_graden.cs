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
    public partial class frm01_graden : Form {
        public frm01_graden() {
            InitializeComponent();
        }

        private void btnFahrenehit_Click(object sender, EventArgs e) {
            double dblCelsius, dblFahrenheit;

            dblCelsius = Convert.ToDouble(txtGraden.Text);

            dblFahrenheit = 1.8 * dblCelsius + 32;

            lblFahrenheit.Text = dblFahrenheit.ToString();
        }
    }
}
