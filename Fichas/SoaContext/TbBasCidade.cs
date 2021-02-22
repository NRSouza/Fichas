using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasCidade
    {
        public int CodCidade { get; set; }
        public int? CodMunicipio { get; set; }
        public string CodUf { get; set; }
        public string DesCidade { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
    }
}
