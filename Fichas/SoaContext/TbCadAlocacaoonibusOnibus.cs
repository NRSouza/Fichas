using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadAlocacaoonibusOnibus
    {
        public long CodAlocacaoonibusOnibus { get; set; }
        public long? CodAlocacaoonibus { get; set; }
        public long? CodOnibus { get; set; }
        public int? NumVagas { get; set; }
        public int? NumAlocadas { get; set; }

        public virtual TbCadAlocacaoonibus CodAlocacaoonibusNavigation { get; set; }
        public virtual TbCadOnibus CodOnibusNavigation { get; set; }
    }
}
