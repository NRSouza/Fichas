using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPagamentoAcampante
    {
        public TbCadPagamentoAcampante()
        {
            TbCadPagamentoAcampanteTicket = new HashSet<TbCadPagamentoAcampanteTicket>();
            TbCadPagamentoAcampanteTicketind = new HashSet<TbCadPagamentoAcampanteTicketind>();
        }

        public long CodPagamentoAcampante { get; set; }
        public long? CodPagamento { get; set; }
        public long? CodInscricao { get; set; }
        public long? CodPessoa { get; set; }
        public decimal? ValIntegral { get; set; }
        public decimal? ValTickets { get; set; }
        public decimal? ValTotal { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public decimal? ValCupom { get; set; }
        public decimal? ValPorcentagem { get; set; }

        public virtual TbCadInscricao CodInscricaoNavigation { get; set; }
        public virtual TbCadPagamento CodPagamentoNavigation { get; set; }
        public virtual TbCadPessoa CodPessoaNavigation { get; set; }
        public virtual ICollection<TbCadPagamentoAcampanteTicket> TbCadPagamentoAcampanteTicket { get; set; }
        public virtual ICollection<TbCadPagamentoAcampanteTicketind> TbCadPagamentoAcampanteTicketind { get; set; }
    }
}
