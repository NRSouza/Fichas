using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadTurmanrAcampante
    {
        public long CodTurmanrAcampante { get; set; }
        public long? CodTurmanr { get; set; }
        public long? CodPessoa { get; set; }
        public long? CodPessoaConvite { get; set; }
        public string FlgAceito { get; set; }
        public DateTime? DatAceitacao { get; set; }
        public long? CodInscricao { get; set; }
        public long? CodInscricaoConvite { get; set; }
        public long? CodTemporada { get; set; }
        public long? CodTemporadaConvite { get; set; }

        public virtual TbCadPessoa CodPessoaNavigation { get; set; }
        public virtual TbCadTurmanr CodTurmanrNavigation { get; set; }
    }
}
