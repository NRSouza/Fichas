using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPacotetemporadaCarga
    {
        public long CodPacotetemporada { get; set; }
        public long? CodTemporada { get; set; }
        public long? CodPacote { get; set; }

        public virtual TbCadPacoteCarga CodPacoteNavigation { get; set; }
        public virtual TbCadTemporadaCarga CodTemporadaNavigation { get; set; }
    }
}
