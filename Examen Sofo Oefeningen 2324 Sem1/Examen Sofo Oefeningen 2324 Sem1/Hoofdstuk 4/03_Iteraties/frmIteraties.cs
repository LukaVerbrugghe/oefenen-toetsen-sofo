using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Sofo_Oefeningen_2324_Sem1.Hoofdstuk_4._03_Iteraties {
    public partial class frmIteraties : Form {
        public frmIteraties() {
            InitializeComponent();
        }

        private void btnOef3_Click(object sender, EventArgs e)
        {
            frm03_Sterren frm03_Sterren = new frm03_Sterren();
            frm03_Sterren.Show();
        }

        private void btnOef1_Click(object sender, EventArgs e)
        {
            frmExamenscore frmExamenscore = new frmExamenscore();
            frmExamenscore.Show();
        }
    }
}
