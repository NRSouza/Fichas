using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadBoletoacampante
    {
        public TbCadBoletoacampante()
        {
            TbCadBoletoacampanteInscricao = new HashSet<TbCadBoletoacampanteInscricao>();
        }

        public long CodBoletoacampante { get; set; }
        public DateTime? DatEnviopagto { get; set; }

        public virtual ICollection<TbCadBoletoacampanteInscricao> TbCadBoletoacampanteInscricao { get; set; }
    }
}
