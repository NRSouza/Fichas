using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasTipoescola
    {
        public TbBasTipoescola()
        {
            TbCadEscola = new HashSet<TbCadEscola>();
        }

        public long CodTipoescola { get; set; }
        public string DesTipoescola { get; set; }
        public string FlgAtivo { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual ICollection<TbCadEscola> TbCadEscola { get; set; }
    }
}
