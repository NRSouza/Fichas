using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasModalidadeUnidades
    {
        public int CodModalidadeUnidade { get; set; }
        public byte? CodModalidade { get; set; }
        public byte? CodUnidadenr { get; set; }

        public virtual TbBasModalidade CodModalidadeNavigation { get; set; }
        public virtual TbCadUnidadenr CodUnidadenrNavigation { get; set; }
    }
}
