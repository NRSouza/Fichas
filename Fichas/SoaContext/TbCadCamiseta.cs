using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadCamiseta
    {
        public TbCadCamiseta()
        {
            TbCadCamisetaTemporada = new HashSet<TbCadCamisetaTemporada>();
        }

        public long CodCamiseta { get; set; }
        public long? CodTipocamiseta { get; set; }
        public int? DesQtde { get; set; }
        public string DesObs { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual ICollection<TbCadCamisetaTemporada> TbCadCamisetaTemporada { get; set; }
    }
}
