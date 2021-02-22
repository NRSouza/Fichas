using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasOperadora
    {
        public byte CodOperadora { get; set; }
        public string DesOperadora { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
    }
}
