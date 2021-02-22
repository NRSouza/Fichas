using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasTipotelefone
    {
        public byte CodTipotelefone { get; set; }
        public string DesTipotelefone { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string FlgSistema { get; set; }
    }
}
