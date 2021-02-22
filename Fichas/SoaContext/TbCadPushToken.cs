using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPushToken
    {
        public TbCadPushToken()
        {
            TbCadPushMensagemToken = new HashSet<TbCadPushMensagemToken>();
        }

        public long CodPushToken { get; set; }
        public string CodIdPessoa { get; set; }
        public string DesToken { get; set; }
        public string NomPessoa { get; set; }
        public string DesEmail { get; set; }
        public string DesTelefone { get; set; }
        public string FlgPerfil { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string CodEscolaUrl { get; set; }
        public long? CodPedido { get; set; }
        public string FlgPushEvento { get; set; }
        public string FlgPushAniversario { get; set; }
        public DateTime? DatNascto { get; set; }
        public string DesLocalizacao { get; set; }

        public virtual ICollection<TbCadPushMensagemToken> TbCadPushMensagemToken { get; set; }
    }
}
