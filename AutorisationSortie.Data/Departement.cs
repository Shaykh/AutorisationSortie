using System;
using System.Collections.Generic;
using System.Text;

namespace AutorisationSortie.Data
{
    public class Departement
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public string Description { get; set; }
        public string Commentaire { get; set; }
        public ICollection<Localite> Localites { get; set; }

        public Departement()
        {
            Localites = new HashSet<Localite>();
        }
    }
}
