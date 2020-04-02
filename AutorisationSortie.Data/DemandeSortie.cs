using System;
using System.Collections.Generic;

namespace AutorisationSortie.Data
{
    public class DemandeSortie
    {
        public long Id { get; set; }
        public long RequerantId { get; set; }
        public int MotifSortieId { get; set; }
        public int EtatTraitementId { get; set; }
        public DateTime DateDemande { get; set; }
        public DateTime DateDecision { get; set; }
        public string NumeroDemande { get; set; }
        public string Description { get; set; }
        public string Commentaire { get; set; }
        public EtatTraitement Traitement { get; set; }
        public Requerant Requerant { get; set; }
        public MotifSortie Motif { get; set; }
        public ICollection<JustificatifSortie> Justificatifs { get; set; }
        public ICollection<DestinationSortie> Destinations { get; set; }
        public DemandeSortie()
        {
            Justificatifs = new HashSet<JustificatifSortie>();
            Destinations = new HashSet<DestinationSortie>();
        }
    }
}
