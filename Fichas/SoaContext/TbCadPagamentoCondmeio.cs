using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPagamentoCondmeio
    {
        public long CodPagamentoCondmeio { get; set; }
        public long? CodPagamento { get; set; }
        public int? CodCondpagto { get; set; }
        public byte? CodMeiopagto { get; set; }
        public string NumCartao { get; set; }
        public string NumTidCielo { get; set; }
        public string NumTransacaoCielo { get; set; }
        public byte? CodStatusCielo { get; set; }
        public string FlgPrincipal { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string DesDiaVencimento { get; set; }
        public byte? NumTentativaCielo { get; set; }
        public string FlgGateway { get; set; }
        public string NumNsu { get; set; }

        public virtual TbBasCondpagto CodCondpagtoNavigation { get; set; }
        public virtual TbBasMeiospagto CodMeiopagtoNavigation { get; set; }
        public virtual TbCadPagamento CodPagamentoNavigation { get; set; }
    }
}
