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

                case 12:
                    lblQuestion.Text = "Quel animal est l’emblème du Royaume Uni ?";

                    pictureBoxQuestion.Image = Properties.Resources.drapeau_gb;
                    rdbResponse1.Text = "La Pie";
                    rdbResponse2.Text = "Le lion";
                    rdbResponse3.Text = "Le Castor";

                    correctAnswer = "Le lion";
                    break;

                case 13:
                    lblQuestion.Text = "Qui est l’inventeur de la pile électrique ?";

                    pictureBoxQuestion.Image = Properties.Resources.Alessandro_Volta;
                    rdbResponse1.Text = "Peter Duracell";
                    rdbResponse2.Text = "Regiani Varta";
                    rdbResponse3.Text = "Alessandro Volta";

                    correctAnswer = "Alessandro Volta";
                    break;

                case 14:
                    lblQuestion.Text = "De quelle région est originaire le saucisson brioché ?";

                    pictureBoxQuestion.Image = Properties.Resources.Alessandro_Volta;
                    rdbResponse1.Text = "Rhône-Alpes";
                    rdbResponse2.Text = "Ile-de-France";
                    rdbResponse3.Text = "Alsace";

                    correctAnswer = "Rhône-Alpes";
                    break;

                case 15:
                    lblQuestion.Text = "De quelle région est originaire le saucisson brioché ?";

                    pictureBoxQuestion.Image = Properties.Resources.saucisson;
                    rdbResponse1.Text = "Rhône-Alpes";
                    rdbResponse2.Text = "Ile-de-France";
                    rdbResponse3.Text = "Alsace";

                    correctAnswer = "Rhône-Alpes";
                    break;

                case 16:
                    lblQuestion.Text = "Quel surnom est souvent donné au footballeur Karim Benzema ?";

                    pictureBoxQuestion.Image = Properties.Resources.ben;
                    rdbResponse1.Text = "Les pieds d'Or";
                    rdbResponse2.Text = "Benzebut";
                    rdbResponse3.Text = "Ben le Terrible";

                    correctAnswer = "Benzebut";
                    break;

                case 17:
                    lblQuestion.Text = "Combien de secondes constituent une journée ?";

                    pictureBoxQuestion.Image = Properties.Resources.temps;
                    rdbResponse1.Text = "21600";
                    rdbResponse2.Text = "86400";
                    rdbResponse3.Text = "604800";

                    correctAnswer = "86400";
                    break;

                case 18:
                    lblQuestion.Text = "Quelle est le nom de ces deux personnages ?";

                    pictureBoxQuestion.Image = Properties.Resources.corneille;
                    rdbResponse1.Text = "Pouf et Pafout";
                    rdbResponse2.Text = "Corneille et Bernie";
                    rdbResponse3.Text = "Tom et Jerry";

                    correctAnswer = "Corneille et Bernie";
                    break;

                case 19:
                    lblQuestion.Text = "En quelle année le paquebot Titanic a-t-il sombré ?";

                    pictureBoxQuestion.Image = Properties.Resources.titanic;
                    rdbResponse1.Text = "1912";
                    rdbResponse2.Text = "1923";
                    rdbResponse3.Text = "1934";

                    correctAnswer = "1912";
                    break;

                case 20:
                    lblQuestion.Text = "Quel animal est aussi appelé goupil ?";

                    pictureBoxQuestion.Image = Properties.Resources.goupil;
                    rdbResponse1.Text = "Un escargot";
                    rdbResponse2.Text = "Un écurueil";
                    rdbResponse3.Text = "Un renard";

                    correctAnswer = "Un renard";
                    break;

                case 21:
                    lblQuestion.Text = "Quelle est la monnaie du Vietnam ?";

                    pictureBoxQuestion.Image = Properties.Resources.dong;
                    rdbResponse1.Text = "Dong";
                    rdbResponse2.Text = "Ding";
                    rdbResponse3.Text = "Deng";

                    correctAnswer = "Dong";
                    break;

                case 22:
                    lblQuestion.Text = "Que tient la Statue de la Liberté dans sa main droite ?";

                    pictureBoxQuestion.Image = Properties.Resources.status;
                    rdbResponse1.Text = "Un flambeau";
                    rdbResponse2.Text = "Un Livre";
                    rdbResponse3.Text = "Une épée";

                    correctAnswer = "Dong";
                    break;

                case 23:
                    lblQuestion.Text = "Quelle est la part d’eau douce sur Terre ?";

                    pictureBoxQuestion.Image = Properties.Resources.eau;
                    rdbResponse1.Text = "Moins de 5%";
                    rdbResponse2.Text = "40%";
                    rdbResponse3.Text = "65%";

                    correctAnswer = "Moins de 5%";
                    break;

                case 24:
                    lblQuestion.Text = "Quel est le plus long fleuve au monde ?";

                    pictureBoxQuestion.Image = Properties.Resources.Amazone;
                    rdbResponse1.Text = "Le Nil";
                    rdbResponse2.Text = "L'Amazone";
                    rdbResponse3.Text = "Le Missisippi";

                    correctAnswer = "Moins de 5%";
                    break;

                case 25:
                    lblQuestion.Text = "Sous quel nom est plus connu l'acide désoxyribonucléique ?";

                    pictureBoxQuestion.Image = Properties.Resources.adn;
                    rdbResponse1.Text = "Le doliprane";
                    rdbResponse2.Text = "L'ADN";
                    rdbResponse3.Text = "Le dentifrice";

                    correctAnswer = "L'ADN";
                    break;

                case 26:
                    lblQuestion.Text = "Dans quel pays a débuté le Tour de France 2022 ?";

                    pictureBoxQuestion.Image = Properties.Resources.tour;
                    rdbResponse1.Text = "Danemark";
                    rdbResponse2.Text = "Maroc";
                    rdbResponse3.Text = "Espagne";

                    correctAnswer = "Danemark";
                    break;

                case 27:
                    lblQuestion.Text = "Quel est le nom de ce type de dinosaure ?";

                    pictureBoxQuestion.Image = Properties.Resources.stego;
                    rdbResponse1.Text = "Platéosaure";
                    rdbResponse2.Text = "Tricératops";
                    rdbResponse3.Text = "Stégosaure";

                    correctAnswer = "Stégosaure";
                    break;

                case 28:
                    lblQuestion.Text = "Quel est le nom de ce poisson présent en Méditerranée ?";

                    pictureBoxQuestion.Image = Properties.Resources.poisson;
                    rdbResponse1.Text = "Une castagnole rouge";
                    rdbResponse2.Text = "Un poisson tigre";
                    rdbResponse3.Text = "Une rascasse volante";

                    correctAnswer = "Une rascasse volante";
                    break;

                case 29:
                    lblQuestion.Text = "Quel groupe sanguin est considéré comme donneur univesel ?";

                    pictureBoxQuestion.Image = Properties.Resources.sang;
                    rdbResponse1.Text = "AB+";
                    rdbResponse2.Text = "O-";
                    rdbResponse3.Text = "O+";

                    correctAnswer = "O-";
                    break;

                case 30:
                    lblQuestion.Text = "Quel fruit est aussi appelé “groseille de Chine” ?";

                    pictureBoxQuestion.Image = Properties.Resources.Prune;
                    rdbResponse1.Text = "Le kiwi";
                    rdbResponse2.Text = "La mangue";
                    rdbResponse3.Text = "La prune";

                    correctAnswer = "Le kiwi";
                    break;

                case 31:
                    lblQuestion.Text = "Quel est l'utilité de cette ustensile ?";

                    pictureBoxQuestion.Image = Properties.Resources.ps;
                    rdbResponse1.Text = "Concasser des noix";
                    rdbResponse2.Text = "Attendrisseur à viande";
                    rdbResponse3.Text = "Battre les oeufs";

                    correctAnswer = "Attendrisseur à viande";
                    break;

                case 32:
                    lblQuestion.Text = "Comment s'appellait le Manchester United à la fondation";

                    pictureBoxQuestion.Image = Properties.Resources.man;
                    rdbResponse1.Text = "West Gorton";
                    rdbResponse2.Text = "Newton Heath";
                    rdbResponse3.Text = "St. Mark's";

                    correctAnswer = "Newton Heath";
                    break;

                case 33:
                    lblQuestion.Text = "Quel est le résultat de cette opération : 278 + 146 + 23";

                    pictureBoxQuestion.Image = Properties.Resources.calcul;
                    rdbResponse1.Text = "437";
                    rdbResponse2.Text = "447";
                    rdbResponse3.Text = "450";

                    correctAnswer = "447";
                    break;

                case 34:
                    lblQuestion.Text = "Quel fleuve traverse la ville hongroise de Budapest ?";

                    pictureBoxQuestion.Image = Properties.Resources.danube;  
                    rdbResponse1.Text = "Le Tibre";
                    rdbResponse2.Text = "Le Danube";
                    rdbResponse3.Text = "L'Elbe";

                    correctAnswer = "Le Danube";
                    break;

                case 35:
                    lblQuestion.Text = "En quelle année est arrivé le cinéma parlant ?";

                    pictureBoxQuestion.Image = Properties.Resources.cinema;
                    rdbResponse1.Text = "1921";
                    rdbResponse2.Text = "1927";
                    rdbResponse3.Text = "1934";

                    correctAnswer = "1927";
                    break;

                case 36:
                    lblQuestion.Text = "Quel fromage est familièrement appelé “calendos” ?";

                    pictureBoxQuestion.Image = Properties.Resources.fromage;
                    rdbResponse1.Text = "Le Coulommiers";
                    rdbResponse2.Text = "La Mimolette";
                    rdbResponse3.Text = "Le Camembert";

                    correctAnswer = "Le Camembert";
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
