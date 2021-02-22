using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPushMensagemToken
    {
        public long CodPushMensagemToken { get; set; }
        public long? CodPushToken { get; set; }
        public long? CodPushMensagem { get; set; }
        public string FlgEnviado { get; set; }
        public string FlgRecebido { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbCadPushMensagem CodPushMensagemNavigation { get; set; }
        public virtual TbCadPushToken CodPushTokenNavigation { get; set; }
    }
}
