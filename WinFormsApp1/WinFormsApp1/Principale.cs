using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Principale : Form
    {
        List<JoueurClasse> joueurs;
        Random rnd = new Random();
        public Principale(string j1,string j2,string j3,string j4)
        {
            InitializeComponent();
        }
        

        private void btnDe_Click(object sender, EventArgs e)
        {
            int nombreDe = rnd.Next(1, 7);
            if (nombreDe == 1)
            {
                pctDe.Image = Properties.Resources.DeN1;
            }
            if (nombreDe == 2)
            {
                pctDe.Image = Properties.Resources.DeN2;
            }
            if (nombreDe == 3)
            {
                pctDe.Image = Properties.Resources.DeN3;
            }
            if (nombreDe == 4)
            {
                pctDe.Image = Properties.Resources.DeN4;
            }
            if (nombreDe == 5)
            {
                pctDe.Image = Properties.Resources.DeN5;
            }
            if (nombreDe == 6)
            {
                pctDe.Image = Properties.Resources.DeN6;
            }
        }

        private void Principale_Load(object sender, EventArgs e)
        {

        }
    }
}
