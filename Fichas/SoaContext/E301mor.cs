using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class E301mor
    {
        public short CodEmp { get; set; }
        public int CodFil { get; set; }
        public string NumTit { get; set; }
        public string CodTpt { get; set; }
        public short SeqMov { get; set; }
        public string TipObs { get; set; }
        public string ObsTit { get; set; }
        public long UsuMov { get; set; }
        public DateTime? DatMov { get; set; }
        public int? HorMov { get; set; }
    }
}
