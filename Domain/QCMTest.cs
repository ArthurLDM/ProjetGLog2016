using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    class QCMTest : Test
    {
        public string Matiere { get; set; }

        public QCMTest(bool niveauDiffuculte, string matiere)
        {
            NomTest="Problèmes mathématiques";
            Ennonce= "à compléter";
            Exemple="à compléter";
            NbSerie=1;

            //Création du test
            id++;
            Score=0;
            scoreMoyen = 0;
            Matiere = matiere;
                //création de la variable difficulté du test
            DifficulteTest = new Difficulte(niveauDiffuculte);
            DifficulteTest.TempsAffichageQ = 0; //pas de limite de temps
            DifficulteTest.TempsReponse = 0; //pas de limite de temps
                    //si le niveau = facile
            if (niveauDiffuculte)
                DifficulteTest.RegleDifficulte = "Les questions sont de niveau facile";     
                    //si le niveau = difficile
            else
                DifficulteTest.RegleDifficulte = "Les questions sont de niveau facile";

            //Création des séries

            //Création des questions : 10 questions/série
            //if matiere=maths, importer questions maths et pareil pour phys
        }
    }
}
