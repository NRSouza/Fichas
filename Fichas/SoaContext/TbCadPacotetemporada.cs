using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPacotetemporada
    {
        public long CodPacotetemporada { get; set; }
        public long? CodTemporada { get; set; }
        public long? CodPacote { get; set; }

        public virtual TbCadPacote CodPacoteNavigation { get; set; }
        public virtual TbCadTemporada CodTemporadaNavigation { get; set; }
    }
}
