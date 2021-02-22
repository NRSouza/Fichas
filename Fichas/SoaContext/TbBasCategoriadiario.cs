using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasCategoriadiario
    {
        public byte CodCategoriadiario { get; set; }
        public string DesCategoriadiario { get; set; }
        public string FlgAtivo { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string FlgSistema { get; set; }
    }
}
