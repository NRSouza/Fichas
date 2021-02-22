using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadNrmail
    {
        public long CodNrmail { get; set; }
        public long? CodPessoanrmail { get; set; }
        public long? CodPessoa { get; set; }
        public long? CodEmail { get; set; }
        public string DesMensagem { get; set; }
        public DateTime? DatEmail { get; set; }
        public string DesEmail { get; set; }
        public long? CodResposta { get; set; }
        public string DesResposta { get; set; }
        public DateTime? DatResposta { get; set; }
        public long? CodPacote { get; set; }
        public string FlgEnvio { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbCadEmails CodEmailNavigation { get; set; }
        public virtual TbCadPessoa CodPessoaNavigation { get; set; }
        public virtual TbCadPessoanrmail CodPessoanrmailNavigation { get; set; }
    }
}
