using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    class CalculTest : Test
    {
       

        public CalculTest(bool niveauDiffuculte)
        {
            NomTest="Calcul Mental";
            Ennonce= "à compléter";
            Exemple="à compléter";
            NbSerie=1;

            //Création du test
            id++;
            Score=0;
            scoreMoyen = 0;
                //création de la variable difficulté du test
            DifficulteTest = new Difficulte(niveauDiffuculte);
            DifficulteTest.TempsAffichageQ = 0; //pas de limite de temps
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

            //Création des questions : 10 questions/série
        }
    }
}
