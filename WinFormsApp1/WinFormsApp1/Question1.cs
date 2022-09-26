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
    public partial class Question1 : Form
    {

        int questionNumber = 4;

        public Question1()
        {
            InitializeComponent();
            askQuestion(questionNumber);
        }

        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    lblQuestion.Text = "Qui est MrPixel";

                    rdbResponse1.Text = "un cheater sur Warzone";
                    rdbResponse2.Text = "Un développeur rust";
                    rdbResponse3.Text = "le nom d'un airbnb";

                    break;

                case 2:
                    lblQuestion.Text = "Comment s'appelle le lion";

                    rdbResponse1.Text = "lion";
                    rdbResponse2.Text = "Lion";
                    rdbResponse3.Text = "lioon";

                    break;

                case 3:
                    lblQuestion.Text = "Quelle age a Elisabeth";

                    rdbResponse1.Text = "Morte";
                    rdbResponse2.Text = "98";
                    rdbResponse3.Text = "102";

                    break;

                case 4:
                    lblQuestion.Text = "hercule poireau est vivant ou Mort ?";

                    rdbResponse1.Text = "Oui";
                    rdbResponse2.Text = "Non";
                    rdbResponse3.Text = "Mort vivant";

                    break;
            }
        }
    }
}
