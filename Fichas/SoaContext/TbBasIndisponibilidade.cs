using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasIndisponibilidade
    {
        public int CodIndisponibilidade { get; set; }
        public long? CodEntrevistador { get; set; }
        public DateTime? DatInicio { get; set; }
        public DateTime? DatTermino { get; set; }
        public string DesMotivo { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
    }
}
