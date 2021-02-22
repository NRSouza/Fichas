using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadTicket
    {
        public long CodTicket { get; set; }
        public string NomTicket { get; set; }
        public string DesTicket { get; set; }
        public decimal? ValTicket { get; set; }
        public string FlgTipo { get; set; }
        public string FlgAtivo { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
    }
}
