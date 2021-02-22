using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadLogCupom
    {
        public long CodLogCupom { get; set; }
        public string DesSistema { get; set; }
        public string DesFuncionalidade { get; set; }
        public string DesAcao { get; set; }
        public string DesMensagem { get; set; }
        public long? CodCupom { get; set; }
        public long? CodCupomItem { get; set; }
        public long? CodUsuario { get; set; }
        public string DesIp { get; set; }
        public DateTime? DatTentativa { get; set; }
        public long? CodReferencia { get; set; }
    }
}
