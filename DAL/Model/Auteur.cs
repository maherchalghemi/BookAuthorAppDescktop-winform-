using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Auteur
    {
        public Auteur()
        {
            this.livres = new List<Livre>();
        }
        public int AuteurId { get; set; }
        public string NomAuteur { get; set; }
        public string prenomAuteur { get; set; }

        public virtual ICollection<Livre> livres { get; set; }

    }
}
