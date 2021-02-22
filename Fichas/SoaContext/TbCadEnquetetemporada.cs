using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadEnquetetemporada
    {
        public long CodEnquetetemporada { get; set; }
        public long? CodEnquete { get; set; }
        public long? CodTemporada { get; set; }

        public virtual TbCadEnquete CodEnqueteNavigation { get; set; }
        public virtual TbCadTemporada CodTemporadaNavigation { get; set; }
    }
}
