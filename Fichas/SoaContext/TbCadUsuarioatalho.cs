using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadUsuarioatalho
    {
        public long CodUsuarioatalho { get; set; }
        public int? CodUsuario { get; set; }
        public long? CodFuncionalidade { get; set; }

        public virtual TbBasFuncionalidade CodFuncionalidadeNavigation { get; set; }
    }
}
