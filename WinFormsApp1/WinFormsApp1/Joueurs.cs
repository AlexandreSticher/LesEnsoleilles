using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Joueurs : Form
    {
        List<JoueurClasse> joueurs;
        

        public Joueurs()
        {
            InitializeComponent();
            joueurs = new List<JoueurClasse>();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Joueurs_Load(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                joueurs.Add(new JoueurClasse(textBox1.Text, "rouge"));
            }
            else if(textBox4.Text != "")
            {
                joueurs.Add(new JoueurClasse(textBox4.Text, "bleu"));
            }
            else if (textBox3.Text != "")
            {
                joueurs.Add(new JoueurClasse(textBox3.Text, "vert"));
            }
            else if (textBox2.Text != "")
            {
                joueurs.Add(new JoueurClasse(textBox2.Text, "violet"));
            }
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string j1 = textBox1.Text;
            string j2 = textBox4.Text;
            string j3 = textBox3.Text;
            string j4 = textBox2.Text;

           string j1_ = btnRed.Text;
            string j2_= btnBlue.Text;
          string  j3_ = btnGreen.Text;
            string j4_ = btnPurple.Text;

            if (rdbJoueurs2.Checked)
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Veuillez rentrer minimum 2 joueur dans les premières cases");
                }
                else if (textBox1.Text != "" && textBox2.Text != "")
                {
                    Principale principal = new Principale(j1, j2, j3, j4);
                    principal.Show();
                }
            }
            else if (rdbJoueurs3.Checked)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                {
                    MessageBox.Show("Veuillez rentrer minimum 3 joueur dans les premières cases");
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {
                    Principale principal = new Principale(j1, j2, j3, j4);
                    principal.Show();
                }
            }
            else if (rdbJoueurs4.Checked)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("Veuillez rentrer minimum 4 joueur dans les premières cases");
                }
                else if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
                {
                    Principale principal = new Principale(j1, j2, j3, j4);
                    principal.Show();
                }
            }
     

  
          
           
          
        }

        private void Joueurs_Load(object sender, EventArgs e)
        {

        }
    }
}
