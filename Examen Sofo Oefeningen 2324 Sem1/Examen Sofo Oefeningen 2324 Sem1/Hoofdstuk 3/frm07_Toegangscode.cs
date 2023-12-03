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
    public partial class frm07_Toegangscode : Form {
        public frm07_Toegangscode() {
            InitializeComponent();
        }

        private void btnCode_Click(object sender, EventArgs e) {
            string strNaam, strLetter1, strLetter2, strPascode, strZonenummer, strPostcode;
            double intPostcode;

            strNaam = txtNaam.Text;
            strZonenummer = txtZonenr.Text;
            strPostcode = txtPostcode.Text;

            strLetter1 = strNaam.Substring(strNaam.Length - 2, 1);
            strLetter2 = strNaam.Substring(strNaam.Length - 1, 1);

            strLetter1 = strLetter1.ToUpper();
            strLetter2 = strLetter2.ToLower();

            strZonenummer = strZonenummer.Substring(1 ,strZonenummer.Length - 1);

            intPostcode = Convert.ToDouble(strPostcode.Substring(0,1));
            intPostcode = Math.Pow(intPostcode, 2);

            strPascode = strLetter2 + strLetter1 + strZonenummer + intPostcode.ToString();

            lblWachtwoord.Text = "Uw wachtwoord is " + strPascode;
        }
    }
}
