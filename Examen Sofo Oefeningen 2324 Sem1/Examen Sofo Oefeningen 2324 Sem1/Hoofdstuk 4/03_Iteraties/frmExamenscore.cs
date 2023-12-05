using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Examen_Sofo_Oefeningen_2324_Sem1.Hoofdstuk_4._03_Iteraties
{
    public partial class frmExamenscore : Form
    {
        int intTotal;
        public frmExamenscore()
        {
            InitializeComponent();

            //ask for how many students
            int intStudenten = Convert.ToInt32(Interaction.InputBox("Hoeveel studenten gaat u ingeven jaja nenen fisjh."));

            for (int i = 0; i < intStudenten; i++)
            {
                int student = i + 1;
                intTotal += Convert.ToInt32(Interaction.InputBox("Wat is de score van student " + Convert.ToString(student) + "?"));
            }
            int intGemiddelde = intTotal / intStudenten;

            lblResultaat.Text = "U heeft " + intStudenten + " studented ingegeven met een gemiddelde van " + intGemiddelde;
        }
    }
}
