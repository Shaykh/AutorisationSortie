using System;
using System.Collections.Generic;
using System.Text;

namespace AutorisationSortie.Data
{
    public class JustificatifIdentite : Justificatif
    {
        public long RequerantId { get; set; }
        public Requerant Requerant { get; set; }
    }
}
