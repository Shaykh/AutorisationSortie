using System;
using System.Collections.Generic;
using System.Text;

namespace AutorisationSortie.Data
{
    public class MotifSortie
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public string Description { get; set; }
        public string Conditions { get; set; }
        public string Commentaire { get; set; }
        public ICollection<DemandeSortie> Demandes { get; set; }

        public MotifSortie()
        {
            Demandes = new HashSet<DemandeSortie>();
        }
    }
}
