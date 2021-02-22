using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadBoletoacampanteInscricao
    {
        public long CodBoletoacampanteInscricao { get; set; }
        public long? CodBoletoacampante { get; set; }
        public long? CodPagtoinscricao { get; set; }

        public virtual TbCadBoletoacampante CodBoletoacampanteNavigation { get; set; }
    }
}
