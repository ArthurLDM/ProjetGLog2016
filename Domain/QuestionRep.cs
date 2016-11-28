using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;


namespace Domain
{
    class QuestionRep
    {
        public static int Id = 0;

        public string EnnonceTexte {get; set;}
        public string Image {get; set;}

        public string[] TabReponse { get; set; }

        public Serie MaSerie { get; set; }

        //public Figure[] TabFigure { get; set; }

        public QuestionRep(string Ennonce, string image, string[] tabreponses, Serie serie)
        {
            EnnonceTexte = Ennonce;
            Image = image;
            TabReponse=tabreponses;
            MaSerie = serie;
        }

        public void Serialize()
        {
            XmlSerializer xs = new XmlSerializer(typeof(QuestionRep));
            using (StreamWriter wr = new StreamWriter("Question.xml"))
            {
                xs.Serialize(wr, this);
            }
        }


    }
}
