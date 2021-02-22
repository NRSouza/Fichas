using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPacoteprecos
    {
        public long CodPacoteprecos { get; set; }
        public long? CodPacotetabelaprecos { get; set; }
        public int? CodCondpagto { get; set; }
        public decimal? ValParcela { get; set; }
        public string DesComentario { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string FlgExibePortal { get; set; }

        public virtual TbBasCondpagto CodCondpagtoNavigation { get; set; }
        public virtual TbCadPacotetabelaprecos CodPacotetabelaprecosNavigation { get; set; }
    }
}
