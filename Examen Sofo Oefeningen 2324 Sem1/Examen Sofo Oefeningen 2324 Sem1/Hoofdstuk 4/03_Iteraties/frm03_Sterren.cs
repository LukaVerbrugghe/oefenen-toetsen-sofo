using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Sofo_Oefeningen_2324_Sem1.Hoofdstuk_4._03_Iteraties
{
    public partial class frm03_Sterren : Form
    {
        public frm03_Sterren()
        {
            InitializeComponent();
        }

        private void txtAantalSterren_TextChanged(object sender, EventArgs e)
        {
            lblSterren.Text = "";

            int intSterren = Convert.ToInt32(txtAantalSterren.Text);

            for (int i = 0; i < intSterren; i++)
            {
                lblSterren.Text += "*";
            }
        }
    }
}
