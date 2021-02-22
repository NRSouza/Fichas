using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbTempEquipeacampante
    {
        public long CodEquipeacampante { get; set; }
        public long? CodTemporadaequipe { get; set; }
        public long? CodPessoa { get; set; }
        public string DesBeliche { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
    }
}
