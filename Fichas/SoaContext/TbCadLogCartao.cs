using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadLogCartao
    {
        public long CodLogCartao { get; set; }
        public long? CodPagamento { get; set; }
        public string NumCartao { get; set; }
        public string NumTid { get; set; }
        public string NumTransacao { get; set; }
        public byte? CodStatus { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public long? CodInscricao { get; set; }
        public string FlgGateway { get; set; }
        public string NumNsu { get; set; }
    }
}
