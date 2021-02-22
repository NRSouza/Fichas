using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasCategoriaCarga
    {
        public long CodCategoria { get; set; }
        public long CodTipopessoa { get; set; }
        public string DesCategoria { get; set; }
        public string FlgAtivo { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
    }
}
