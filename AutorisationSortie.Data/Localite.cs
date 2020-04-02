using System;
using System.Collections.Generic;
using System.Text;

namespace AutorisationSortie.Data
{
    public class Localite
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public string Description { get; set; }
        public string Commentaire { get; set; }
        public int DepartementId { get; set; }
        public Departement Departement { get; set; }
        public ICollection<Residence> Residences { get; set; }
        public ICollection<DestinationSortie> Arrivees { get; set; }

        public Localite()
        {
            Residences = new HashSet<Residence>();
            Arrivees = new HashSet<DestinationSortie>();
        }
    }
}
