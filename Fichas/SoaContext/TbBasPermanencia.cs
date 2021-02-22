using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasPermanencia
    {
        public int CodPermanencia { get; set; }
        public string DesPermanencia { get; set; }
        public byte? NumDias { get; set; }
        public string FlgAtivo { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
    }
}
