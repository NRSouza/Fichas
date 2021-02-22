using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoamidiasocial
    {
        public long CodPessoamidiasocial { get; set; }
        public long? CodPessoa { get; set; }
        public int? CodMidiasocial { get; set; }
        public string DesIdentificacao { get; set; }
        public string DesObs { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbBasMidiassociais CodMidiasocialNavigation { get; set; }
    }
}
