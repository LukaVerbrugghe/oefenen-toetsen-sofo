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
    public partial class frmOnderhoudAuto : Form {
        public frmOnderhoudAuto() {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, EventArgs e) {
            //variabelen
            DateTime dteLaatsteControle, dteVolgendeControle;
            int intVolgendeControle;
            TimeSpan tmsNumberOfDays;

            //input
            dteLaatsteControle = Convert.ToDateTime(txtLaatsteControle.Text);
            
            //verwerking
            dteVolgendeControle = dteLaatsteControle.AddMonths(6);
            tmsNumberOfDays = DateTime.Today.Subtract(dteVolgendeControle);
            intVolgendeControle = tmsNumberOfDays.Days;

            //output
            lblControleDatum.Text = dteVolgendeControle.ToString();
            lblControleDagen.Text = intVolgendeControle.ToString();
        }
    }
}
