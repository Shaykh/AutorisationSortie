using System;
using System.Collections.Generic;
using System.Text;

namespace AutorisationSortie.Data
{
    public class Justificatif
    {
        public long Id { get; set;  }
        public byte[] Donnees { get; set; }
        public string Extension { get; set; }
    }
}
