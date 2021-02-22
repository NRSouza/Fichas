using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbTempDescontoirmao
    {
        public string CodSession { get; set; }
        public long? CodPessoa { get; set; }
        public long? CodPessoapapelreserva { get; set; }
        public decimal? ValPacote { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public long? CodCategoria { get; set; }
        public byte? ValAbatimento { get; set; }
    }
}
