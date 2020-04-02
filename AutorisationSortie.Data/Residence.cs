using System;
using System.Collections.Generic;
using System.Text;

namespace AutorisationSortie.Data
{
    public class Residence
    {
        public long Id { get; set; }
        public long RequerantId { get; set; }
        public int LocaliteId { get; set; }
        public DateTime DateResidence { get; set; }
        public string Commentaire { get; set; }
        public Localite Localite { get; set; }
        public Requerant Requerant { get; set; }
        public ICollection<JustificatifResidence> Justificatifs { get; set; }

        public Residence()
        {
            Justificatifs = new HashSet<JustificatifResidence>();
        }
    }
}
