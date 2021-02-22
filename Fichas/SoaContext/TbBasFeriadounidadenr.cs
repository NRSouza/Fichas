using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasFeriadounidadenr
    {
        public long CodFeriadounidadenr { get; set; }
        public long CodFeriado { get; set; }
        public byte CodUnidadenr { get; set; }

        public virtual TbBasFeriado CodFeriadoNavigation { get; set; }
        public virtual TbCadUnidadenr CodUnidadenrNavigation { get; set; }
    }
}
