using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasVisibilidadeUnidades
    {
        public int CodVisibilidadeUnidade { get; set; }
        public byte? CodVisibilidade { get; set; }
        public byte? CodUnidadenr { get; set; }

        public virtual TbCadUnidadenr CodUnidadenrNavigation { get; set; }
        public virtual TbBasVisibilidade CodVisibilidadeNavigation { get; set; }
    }
}
