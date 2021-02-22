using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadTemporadaequipeFotopessoa
    {
        public long CodTemporadaequipeFotopessoa { get; set; }
        public long? CodTemporadaequipeFoto { get; set; }
        public long? CodPessoa { get; set; }
        public string DesIdentificacao { get; set; }
        public int? DesTop { get; set; }
        public int? DesLeft { get; set; }
        public int? ValOrdem { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
    }
}
