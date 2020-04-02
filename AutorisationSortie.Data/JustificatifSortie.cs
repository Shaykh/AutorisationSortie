using System;
using System.Collections.Generic;
using System.Text;

namespace AutorisationSortie.Data
{
    public class JustificatifSortie : Justificatif
    {
        public long DemandeSortieId { get; set; }
        public DemandeSortie DemandeSortie { get; set; }
    }
}
