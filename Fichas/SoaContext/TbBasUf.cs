using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasUf
    {
        public byte CodIdUf { get; set; }
        public string CodUf { get; set; }
        public string DesUf { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
    }
}
