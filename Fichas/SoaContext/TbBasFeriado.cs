using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasFeriado
    {
        public TbBasFeriado()
        {
            TbBasFeriadounidadenr = new HashSet<TbBasFeriadounidadenr>();
        }

        public long CodFeriado { get; set; }
        public string DesFeriado { get; set; }
        public DateTime? DatFeriado { get; set; }
        public string FlgFacultativo { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual ICollection<TbBasFeriadounidadenr> TbBasFeriadounidadenr { get; set; }
    }
}
