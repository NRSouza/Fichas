using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoapapelreservahist
    {
        public long CodPessoapapelreservahist { get; set; }
        public long? CodPessoapapelreserva { get; set; }
        public string DesHistorico { get; set; }
        public string FlgAutomatico { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbCadPessoapapelreserva CodPessoapapelreservaNavigation { get; set; }
    }
}
