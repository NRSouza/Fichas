using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadAlocacaoonibusPacote
    {
        public long CodAlocacaoonibusPacote { get; set; }
        public long? CodAlocacaoonibus { get; set; }
        public long? CodPacote { get; set; }

        public virtual TbCadAlocacaoonibus CodAlocacaoonibusNavigation { get; set; }
        public virtual TbCadPacote CodPacoteNavigation { get; set; }
    }
}
