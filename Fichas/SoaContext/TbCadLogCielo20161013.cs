using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadLogCielo20161013
    {
        public long CodLogCielo { get; set; }
        public long? CodPagamento { get; set; }
        public string NumCartao { get; set; }
        public string NumTid { get; set; }
        public string NumTransacao { get; set; }
        public byte? CodStatus { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public long? CodInscricao { get; set; }
    }
}
