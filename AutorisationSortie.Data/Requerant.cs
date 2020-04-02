using System;
using System.Collections.Generic;

namespace AutorisationSortie.Data
{
    public class Requerant
    {
        public long Id { get; set; }
        public string CodeRequerant { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Profession { get; set; }
        public string NumeroPiece { get; set; }
        public int TypePieceId { get; set; }
        public int EtatSanteId { get; set; }
        public string LieuNaissance { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Commentaire { get; set; }
        public TypePiece TypePiece { get; set; }
        public EtatSante EtatSante { get; set; }
        public Residence Residence { get; set; }
        public ICollection<JustificatifIdentite> Justificatifs { get; set; }
        public ICollection<DemandeSortie> Demandes { get; set; }

        public Requerant()
        {
            Justificatifs = new HashSet<JustificatifIdentite>();
            Demandes = new HashSet<DemandeSortie>();
        }
    }
}
