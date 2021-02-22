using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPagamentoAcampanteTicketind
    {
        public long CodPagamentoAcampanteTicketind { get; set; }
        public long? CodPagamento { get; set; }
        public long? CodPagamentoAcampante { get; set; }
        public long? CodTicketind { get; set; }

        public virtual TbCadPagamentoAcampante CodPagamentoAcampanteNavigation { get; set; }
        public virtual TbCadPagamento CodPagamentoNavigation { get; set; }
        public virtual TbCadPessoapapelreservaTicketind CodTicketindNavigation { get; set; }
    }
}
