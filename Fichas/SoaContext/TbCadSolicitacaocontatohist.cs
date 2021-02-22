using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadSolicitacaocontatohist
    {
        public long CodSolicitacaocontatohist { get; set; }
        public int? CodSolicitacaocontato { get; set; }
        public string DesHistorico { get; set; }
        public DateTime? DatHistorico { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
    }
}
