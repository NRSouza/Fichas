using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasPalavrarestrita
    {
        public int CodPalavrarestrita { get; set; }
        public string DesPalavrarestrita { get; set; }
        public string FlgAtivo { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
    }
}
