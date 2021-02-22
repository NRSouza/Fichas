using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadTemporadaturma
    {
        public long CodTemporadaturma { get; set; }
        public long CodTemporada { get; set; }
        public string DesTurma { get; set; }
        public string CodGenero { get; set; }
        public string DesObs { get; set; }
        public long? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
    }
}
