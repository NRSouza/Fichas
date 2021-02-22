using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasTipoendereco
    {
        public TbBasTipoendereco()
        {
            TbCadEscolaendereco = new HashSet<TbCadEscolaendereco>();
        }

        public short CodTipoendereco { get; set; }
        public string DesTipoendereco { get; set; }
        public string FlgAtivo { get; set; }
        public int? ValOrdem { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual ICollection<TbCadEscolaendereco> TbCadEscolaendereco { get; set; }
    }
}
