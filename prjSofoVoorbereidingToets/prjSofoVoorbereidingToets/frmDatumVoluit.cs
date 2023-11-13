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
    public partial class frmDatumVoluit : Form {
        public frmDatumVoluit() {
            InitializeComponent();
        }

        private void btnDatumVoluit_Click(object sender, EventArgs e) {
            //var
            string strDatumKort, strLang;
            //opvang uit textbox
            //datetime.parse();
            DateTime dteIngegeven = DateTime.Parse(txtDatumKort.Text);

            //input

            //output
            lblDatumVoluit.Text = dteIngegeven.ToLongDateString();
        }
    }
}
