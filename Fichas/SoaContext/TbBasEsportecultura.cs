using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasEsportecultura
    {
        public byte CodEsportecultura { get; set; }
        public string DesTipo { get; set; }
        public string DesItem { get; set; }
        public string FlgAtivo { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
    }
}
