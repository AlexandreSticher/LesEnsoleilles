using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
      class JoueurClasse
    {
       private string nomJoueur_;
        private string couleurJoueur_;
       private int caseJoueur_;

     
        public string NomJoueur { get => nomJoueur_; set => nomJoueur_ = value; }
        public string CouleurJoueur { get => couleurJoueur_; set => couleurJoueur_ = value; }
        public int CaseJoueur { get => caseJoueur_; set => caseJoueur_ = value; }
       
        public JoueurClasse(string nomJoueur, string couleurJoueur)
        {
            nomJoueur = NomJoueur;
            couleurJoueur = CouleurJoueur;
        }
    }
}
