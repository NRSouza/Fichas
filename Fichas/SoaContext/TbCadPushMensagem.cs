using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPushMensagem
    {
        public TbCadPushMensagem()
        {
            TbCadPushMensagemToken = new HashSet<TbCadPushMensagemToken>();
        }

        public long CodPushMensagem { get; set; }
        public string DesLote { get; set; }
        public string DesMensagem { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public DateTime? DatEnviar { get; set; }
        public string FlgEnviado { get; set; }
        public string DesImgUrl { get; set; }
        public string DesLinkUrl { get; set; }
        public string DesTipo { get; set; }

        public virtual ICollection<TbCadPushMensagemToken> TbCadPushMensagemToken { get; set; }
    }
}
