using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPagamento
    {
        public TbCadPagamento()
        {
            TbCadPagamentoAcampante = new HashSet<TbCadPagamentoAcampante>();
            TbCadPagamentoAcampanteTicket = new HashSet<TbCadPagamentoAcampanteTicket>();
            TbCadPagamentoAcampanteTicketind = new HashSet<TbCadPagamentoAcampanteTicketind>();
            TbCadPagamentoCondmeio = new HashSet<TbCadPagamentoCondmeio>();
            TbCadPagamentoParcela = new HashSet<TbCadPagamentoParcela>();
        }

        public long CodPagamento { get; set; }
        public decimal? ValIntegral { get; set; }
        public decimal? ValTickets { get; set; }
        public decimal? ValTotal { get; set; }
        public DateTime? DatEnviopagto { get; set; }
        public string FlgPago { get; set; }
        public DateTime? DatPago { get; set; }
        public string FlgSapiens { get; set; }
        public DateTime? DatEnvioSapiens { get; set; }
        public int? NumPedSapiens { get; set; }
        public string DesMsgDobra { get; set; }
        public DateTime? DatMsgDobra { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string FlgLiberado { get; set; }
        public long? CodCupomItem { get; set; }
        public DateTime? DatUtilizacaoCupom { get; set; }
        public decimal? ValTotalCupom { get; set; }
        public string FlgCantina { get; set; }

        public virtual TbCadCupomItem CodCupomItemNavigation { get; set; }
        public virtual ICollection<TbCadPagamentoAcampante> TbCadPagamentoAcampante { get; set; }
        public virtual ICollection<TbCadPagamentoAcampanteTicket> TbCadPagamentoAcampanteTicket { get; set; }
        public virtual ICollection<TbCadPagamentoAcampanteTicketind> TbCadPagamentoAcampanteTicketind { get; set; }
        public virtual ICollection<TbCadPagamentoCondmeio> TbCadPagamentoCondmeio { get; set; }
        public virtual ICollection<TbCadPagamentoParcela> TbCadPagamentoParcela { get; set; }
    }
}
