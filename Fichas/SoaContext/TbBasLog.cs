using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasLog
    {
        public long CodLog { get; set; }
        public long? CodUsuario { get; set; }
        public string DesFuncionalidade { get; set; }
        public string DesMensagem { get; set; }
        public DateTime? DatAtualizacao { get; set; }
    }
}
