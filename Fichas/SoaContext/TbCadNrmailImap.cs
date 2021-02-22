using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadNrmailImap
    {
        public long CodNrmailImap { get; set; }
        public int? CodUnidadenr { get; set; }
        public long? CodUid { get; set; }
        public string DesDe { get; set; }
        public string DesPara { get; set; }
        public string DesAssunto { get; set; }
        public string DesMensagem { get; set; }
        public string FlgStatus { get; set; }
        public DateTime? DatEmail { get; set; }
        public DateTime? DatImpressao { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
    }
}
