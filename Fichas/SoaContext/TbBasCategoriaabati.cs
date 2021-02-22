using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasCategoriaabati
    {
        public long CodCategoriaabati { get; set; }
        public long? CodCategoria { get; set; }
        public string DesAbatimento { get; set; }
        public byte? ValAbatimento { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbBasCategoria CodCategoriaNavigation { get; set; }
    }
}
