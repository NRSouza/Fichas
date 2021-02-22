using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class BcVagasChale
    {
        public decimal VchCod { get; set; }
        public string VchNom { get; set; }
        public decimal? VchVag { get; set; }
        public string VchSex { get; set; }
        public decimal? VchMon { get; set; }
        public decimal? VchAca { get; set; }
        public int TemCod { get; set; }
        public decimal? VchAss { get; set; }
        public int? Indice { get; set; }
        public DateTime? DatCad { get; set; }
        public DateTime? DatAlt { get; set; }
        public int? UsuCad { get; set; }
        public int? UsuAlt { get; set; }
    }
}
