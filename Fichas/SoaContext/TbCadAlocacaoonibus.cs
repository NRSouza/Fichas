using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadAlocacaoonibus
    {
        public TbCadAlocacaoonibus()
        {
            TbCadAlocacaoonibusOnibus = new HashSet<TbCadAlocacaoonibusOnibus>();
            TbCadAlocacaoonibusPacote = new HashSet<TbCadAlocacaoonibusPacote>();
        }

        public long CodAlocacaoonibus { get; set; }
        public DateTime? DatAlocacaoonibus { get; set; }
        public string FlgTipo { get; set; }

        public virtual ICollection<TbCadAlocacaoonibusOnibus> TbCadAlocacaoonibusOnibus { get; set; }
        public virtual ICollection<TbCadAlocacaoonibusPacote> TbCadAlocacaoonibusPacote { get; set; }
    }
}
