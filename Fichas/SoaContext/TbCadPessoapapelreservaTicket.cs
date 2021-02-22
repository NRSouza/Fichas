using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoapapelreservaTicket
    {
        public TbCadPessoapapelreservaTicket()
        {
            TbCadPagamentoAcampanteTicket = new HashSet<TbCadPagamentoAcampanteTicket>();
        }

        public long CodPessoapapelreservaTicket { get; set; }
        public long CodPessoapapelreserva { get; set; }
        public long CodTicket { get; set; }
        public DateTime? DatValidade { get; set; }
        public string FlgObrigatorio { get; set; }
        public string FlgUtilizado { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbCadPessoapapelreserva CodPessoapapelreservaNavigation { get; set; }
        public virtual ICollection<TbCadPagamentoAcampanteTicket> TbCadPagamentoAcampanteTicket { get; set; }
    }
}
