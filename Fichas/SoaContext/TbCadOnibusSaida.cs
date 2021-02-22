using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadOnibusSaida
    {
        public TbCadOnibusSaida()
        {
            TbCadOnibusAlocacao = new HashSet<TbCadOnibusAlocacao>();
            TbCadOnibusPacote = new HashSet<TbCadOnibusPacote>();
        }

        public long CodOnibusSaida { get; set; }
        public long? CodOnibus { get; set; }
        public DateTime? DatSaida { get; set; }
        public string FlgOperacao { get; set; }
        public string FlgExibeportal { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string FlgExibesoa { get; set; }

        public virtual TbCadOnibus CodOnibusNavigation { get; set; }
        public virtual ICollection<TbCadOnibusAlocacao> TbCadOnibusAlocacao { get; set; }
        public virtual ICollection<TbCadOnibusPacote> TbCadOnibusPacote { get; set; }
    }
}
