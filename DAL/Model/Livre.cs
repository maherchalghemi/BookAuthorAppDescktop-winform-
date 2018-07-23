using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Livre
    {
        public int LivreId { get; set; }

        public string NomLivre { get; set; }

        public DateTime date { get; set; }

        public int Auteur_Id { get; set; }

        public virtual Auteur auteur { get; set; }


    }
}
