using System;
using System.Collections.Generic;
using System.Text;

namespace AutorisationSortie.Data
{
    public class EtatSante
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public string Description { get; set; }
        public string Commentaire { get; set; }
        public ICollection<Requerant> Requerants { get; set; }

        public EtatSante()
        {
            Requerants = new HashSet<Requerant>();
        }
    }
}
