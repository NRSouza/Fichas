using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadCamisetaTemporada
    {
        public long CodCamisetaTemporada { get; set; }
        public long? CodCamiseta { get; set; }
        public long? CodTemporada { get; set; }

        public virtual TbCadCamiseta CodCamisetaNavigation { get; set; }
        public virtual TbCadTemporada CodTemporadaNavigation { get; set; }
    }
}
