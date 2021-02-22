using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadEscCategoria
    {
        public long CodEscCategoria { get; set; }
        public int? CodCategoriaSistema { get; set; }
        public string DesCategoria { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
    }
}
