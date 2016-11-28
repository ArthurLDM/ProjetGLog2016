using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    class PerceptionTest : Test
    {
        public PerceptionTest(bool niveauDiffuculte)
        {
            NomTest="Perception et mémoire associative";
            Ennonce= "à compléter";
            Exemple="à compléter";
            NbSerie=1;

            //Création du test
            id++;
            Score=0;
            scoreMoyen = 0;
                //création de la variable difficulté du test
            DifficulteTest = new Difficulte(niveauDiffuculte);
            DifficulteTest.TempsReponse = 0; //pas de limite de temps
                    //si le niveau = facile
            if (niveauDiffuculte)
            {
                DifficulteTest.RegleDifficulte = "Les figures s'affichent 4 secondes";
                DifficulteTest.TempsAffichageQ = 4;
            }
                    //si le niveau = difficile
            else
            {
                DifficulteTest.RegleDifficulte = "Les figures s'affichent 2 secondes";
                DifficulteTest.TempsAffichageQ = 2;
            }     

            //Création des séries

            //Création des questions : 10 questions/série
        }
    }
}
