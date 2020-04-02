using System;
using System.Collections.Generic;
using System.Text;

namespace AutorisationSortie.Data
{
    public class JustificatifResidence : Justificatif
    {
        public long ResidenceId { get; set; }
        public Residence Residence { get; set; }
    }
}
