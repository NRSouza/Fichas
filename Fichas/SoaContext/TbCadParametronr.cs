using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadParametronr
    {
        public int CodParametronr { get; set; }
        public byte? CodUnidadenr { get; set; }
        public string DesChave { get; set; }
        public string ValParametro { get; set; }
        public string DesExplicacao { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string FlgSistema { get; set; }

        public virtual TbCadUnidadenr CodUnidadenrNavigation { get; set; }
    }
}
