using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public abstract class Test
    {
        protected static int id = 0;
        protected static double scoreMoyen;  //moyenne des scores des tests effectués par n utilisateurs

        public static string NomTest { get; set; }
        public static string Ennonce { get; set; }
        public static string Exemple { get; set; }
        public static int NbSerie { get; set; }   
        
        public int Score { get; set; }
        public Difficulte DifficulteTest { get; set; }
        
    }
}
