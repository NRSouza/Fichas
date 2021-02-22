using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPagamentoAcampanteTicket
    {
        public long CodPagamentoAcampanteTicket { get; set; }
        public long? CodPagamento { get; set; }
        public long? CodPagamentoAcampante { get; set; }
        public long? CodTicket { get; set; }

        public virtual TbCadPagamentoAcampante CodPagamentoAcampanteNavigation { get; set; }
        public virtual TbCadPagamento CodPagamentoNavigation { get; set; }
        public virtual TbCadPessoapapelreservaTicket CodTicketNavigation { get; set; }
    }
}
