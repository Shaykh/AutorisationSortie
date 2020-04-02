using System;
using System.Collections.Generic;
using System.Text;

namespace AutorisationSortie.Data
{
    public class DestinationSortie
    {
        public long Id { get; set; }
        public long DemandeSortieId { get; set; }
        public int LocaliteId { get; set; }
        public DateTime DateDepart { get; set; }
        public DateTime? DateRetour { get; set; }
        public Localite Localite { get; set; }
        public DemandeSortie Demande { get; set; }
    }
}
