using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadOnibusPacote
    {
        public long CodOnibusPacote { get; set; }
        public long? CodOnibusSaida { get; set; }
        public long? CodPacote { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbCadOnibusSaida CodOnibusSaidaNavigation { get; set; }
        public virtual TbCadPacote CodPacoteNavigation { get; set; }
    }
}
