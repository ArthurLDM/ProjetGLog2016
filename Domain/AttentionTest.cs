using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    class AttentionTest : Test
    {
        public AttentionTest(bool niveauDiffuculte)
        {
            NomTest="Attention et concentration";
            Ennonce= "à compléter";
            Exemple="à compléter";
            NbSerie=3;

            //Création du test
            id++;
            Score=0;
            scoreMoyen = 0;
                //création de la variable difficulté du test
            DifficulteTest = new Difficulte(niveauDiffuculte);
            DifficulteTest.TempsAffichageQ = 0; //pas de limite de temps, mais ok/erreur s'affiche 3 sec
                    //si le niveau = facile
            if (niveauDiffuculte)
            {
                DifficulteTest.RegleDifficulte = "Il n'y a pas de limite de temps pour répondre";     
                DifficulteTest.TempsReponse = 0; //pas de limite de temps
            }
                    //si le niveau = difficile
            else
            {
                DifficulteTest.RegleDifficulte = "Vous avez 5 secondes pour répondre";
                DifficulteTest.TempsReponse = 5; 
            }     

            //Création des séries

            //Création des questions : 5 questions/série
        }
    }
}
