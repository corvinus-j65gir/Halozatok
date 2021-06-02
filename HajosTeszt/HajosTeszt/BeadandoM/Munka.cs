using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszt.BeadandoM
{
    public partial class Munka
    {
        public int MunkaId { get; set; }
        public int? MhelyId { get; set; }
        public int? DiakAz { get; set; }
        public string Allas { get; set; }
        public DateTime? Datum { get; set; }
        public int? Oradij { get; set; }
        public int? Oraszam { get; set; }
        public bool Kozepiskolas { get; set; }
    }
}
