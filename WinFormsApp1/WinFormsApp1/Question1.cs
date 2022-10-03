using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Question1 : Form
    {
        string correctAnswer;
        int questionNumber = 0;
        Random random = new Random();

        public Question1()
        {
            InitializeComponent();
            questionNumber = random.Next(1,11);
            askQuestion(questionNumber);
        }

        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    lblQuestion.Text = "En quelle année, Louis 14 est mort ? ";

                    pictureBoxQuestion.Image = Properties.Resources.Louis14;
                    rdbResponse1.Text = "1 septembre 1715";
                    rdbResponse2.Text = "5 septembte 2716";
                    rdbResponse3.Text = "3 octobre 1725";

                    correctAnswer = "1 septembre 1715";

                    break;

                case 2:
                    lblQuestion.Text = "Quelle est la capitale de l’Islande ?";

                    pictureBoxQuestion.Image = Properties.Resources.capitale;
                    rdbResponse1.Text = "Grindavik";
                    rdbResponse2.Text = "Reykjavik";
                    rdbResponse3.Text = "Husavik";

                    correctAnswer = "Reykjavik";

                    break;

                case 3:
                    lblQuestion.Text = "Quelle est le nom de ce Personnage ?";

                    pictureBoxQuestion.Image= Properties.Resources.luffy;
                    rdbResponse1.Text = "Louffy";
                    rdbResponse2.Text = "Lucy";
                    rdbResponse3.Text = "Luffy";

                    correctAnswer= "Luffy";

                    break;

                case 4:

                    lblQuestion.Text = "Qui a inventé l'imprimante ?";

                    pictureBoxQuestion.Image = Properties.Resources.Gutenberg;
                    rdbResponse1.Text = "Johaes Gutenberg";
                    rdbResponse2.Text = "Johannes Gutenberg";
                    rdbResponse3.Text = "Johates Gutenberg";

                    correctAnswer = "Johannes Gutenberg";
                    break;

                case 5:
                    lblQuestion.Text = "Combien de ballon d'or CR7 a-t'il ?";

                    pictureBoxQuestion.Image = Properties.Resources.cr7;
                    rdbResponse1.Text = "6";
                    rdbResponse2.Text = "4";
                    rdbResponse3.Text = "5";

                    correctAnswer = "5";
                    break;

                case 6:
                    lblQuestion.Text = "Comment s'appelle ce personnage ?";

                    pictureBoxQuestion.Image = Properties.Resources.taz;
                    rdbResponse1.Text = "Bugs Bunny";
                    rdbResponse2.Text = "taz";
                    rdbResponse3.Text = "Garfield";

                    correctAnswer = "taz";
                    break;

                case 7:
                    lblQuestion.Text = "Quelle est la couleur du cheval blanc de Louis 4 ?";

                    pictureBoxQuestion.Image = Properties.Resources.cheval;
                    rdbResponse1.Text = "Cheval Noir";
                    rdbResponse2.Text = "Cheval Blanc";
                    rdbResponse3.Text = "pas de Cheval";

                    correctAnswer = "Cheval Blanc";
                    break;

                case 8:
                    lblQuestion.Text = "Quel est le nom de se catcheur MMA ?";

                    pictureBoxQuestion.Image = Properties.Resources.kabib;
                    rdbResponse1.Text = "Conor McGregor";
                    rdbResponse2.Text = "Cain Velasquez";
                    rdbResponse3.Text = "khabib nurmagomedov";

                    correctAnswer = "khabib nurmagomedov";
                    break;

                case 9:
                    lblQuestion.Text = "Qui est cette petite voiture ?";

                    pictureBoxQuestion.Image = Properties.Resources.mac;
                    rdbResponse1.Text = "Doc Hudson";
                    rdbResponse2.Text = "Flash Mac Queen";
                    rdbResponse3.Text = "Flash Mac King";

                    correctAnswer = "Flash Mac Queen";
                    break;

                case 10:
                    lblQuestion.Text = "Quelle couleur est le pelage de la Panthère Rose";

                    pictureBoxQuestion.Image = Properties.Resources.rose;
                    rdbResponse1.Text = "Noir";
                    rdbResponse2.Text = "Margenta";
                    rdbResponse3.Text = "Rose";

                    correctAnswer = "Rose";
                    break;

                case 11:
                    lblQuestion.Text = "Quelle est le nom de ce langage";

                    pictureBoxQuestion.Image = Properties.Resources.csharp;
                    rdbResponse1.Text = "Noir";
                    rdbResponse2.Text = "Margenta";
                    rdbResponse3.Text = "Rose";

                    correctAnswer = "Rose";
                    break;
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if(rdbResponse1.Checked == true)
            {
                if (rdbResponse1.Text == correctAnswer)
                {
                    lblReponse.Text = "Correct";
                }
                else
                {
                    lblReponse.Text = "Incorrect";
                }
            }
            else if(rdbResponse2.Checked == true)
            {
                if (rdbResponse2.Text == correctAnswer)
                {
                    lblReponse.Text = "Correct";
                }
                else
                {
                    lblReponse.Text = "Incorrect";
                }
            }
            else if(rdbResponse3.Checked == true)
            {
                if (rdbResponse3.Text == correctAnswer)
                {
                    lblReponse.Text = "Correct";
                }
                else
                {
                    lblReponse.Text = "Incorrect";
                }
            }
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            questionNumber = random.Next(1, 9);
            askQuestion(questionNumber);

            lblReponse.Text = "";
        }
    }
}
