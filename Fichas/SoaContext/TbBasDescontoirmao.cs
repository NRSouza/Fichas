using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasDescontoirmao
    {
        public int CodDescontoirmao { get; set; }
        public int? NumFilho { get; set; }
        public int? DesDesconto { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
    }
}
