using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadAcessoCantina
    {
        public long CodAcessoCantina { get; set; }
        public long? CodResponsavel { get; set; }
        public DateTime? DatAcesso { get; set; }
        public string DesToken { get; set; }
    }
}
