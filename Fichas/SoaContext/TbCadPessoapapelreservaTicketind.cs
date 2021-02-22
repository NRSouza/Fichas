using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoapapelreservaTicketind
    {
        public TbCadPessoapapelreservaTicketind()
        {
            TbCadPagamentoAcampanteTicketind = new HashSet<TbCadPagamentoAcampanteTicketind>();
        }

        public long CodPessoapapelreservaTicketind { get; set; }
        public long CodPessoapapelreserva { get; set; }
        public string DesTicketind { get; set; }
        public decimal? PorTicketind { get; set; }
        public decimal? ValTicketind { get; set; }
        public string FlgObrigatorio { get; set; }
        public string FlgTipo { get; set; }
        public string FlgAutomatico { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string FlgTipoDesconto { get; set; }
        public long? CodCategoria { get; set; }

        public virtual TbCadPessoapapelreserva CodPessoapapelreservaNavigation { get; set; }
        public virtual ICollection<TbCadPagamentoAcampanteTicketind> TbCadPagamentoAcampanteTicketind { get; set; }
    }
}
