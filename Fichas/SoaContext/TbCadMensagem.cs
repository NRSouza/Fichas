using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadMensagem
    {
        public byte CodMensagem { get; set; }
        public byte? CodUnidadenr { get; set; }
        public string DesAssunto { get; set; }
        public string FlgAtivo { get; set; }
        public string DesMensagem { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbCadUnidadenr CodUnidadenrNavigation { get; set; }
    }
}
