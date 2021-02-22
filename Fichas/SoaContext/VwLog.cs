using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class VwLog
    {
        public string NomUsuario { get; set; }
        public string DesFuncionalidade { get; set; }
        public string DesMensagem { get; set; }
        public DateTime? DatAtualizacao { get; set; }
    }
}
