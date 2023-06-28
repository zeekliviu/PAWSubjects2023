using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sub5PAW
{
    public class Carte : Publicatie
    {
        private readonly string ISBN;
        private string categorie;
        private List<Autor> autori;

        public List<Autor> Autori { get => autori; set => autori = value; }
        public string isbn => ISBN;
        public string Categorie => categorie;

        public Carte()
        {
            autori = new List<Autor>();
        }

        public Carte(string ISBN, string categorie): this()
        {
            this.ISBN = ISBN;
            this.categorie = categorie;
        }

        public Carte(string iSBN, string categorie, List<Autor> autori):this(iSBN, categorie)
        {
            ISBN = iSBN;
            this.categorie = categorie;
            this.autori = autori;
        }

        public override string genereazaReferinta()
        {
            var sb = new StringBuilder();
            foreach(Autor autor in autori)
            {
                sb.Append($"{autor.Nume}, ");
            }
            sb.Remove(sb.Length - 2, 2 );
            sb.Append($" - {Titlu}, {ISBN}");
            return sb.ToString();
        }

        public static Carte operator +(Carte a, Autor b)
        {
            a.autori.Add(b);
            return a;
        }
    }
}
