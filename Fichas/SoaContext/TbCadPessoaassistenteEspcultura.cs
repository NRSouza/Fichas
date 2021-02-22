using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoaassistenteEspcultura
    {
        public long CodPessoaassistenteEspcultura { get; set; }
        public long? CodPessoa { get; set; }
        public byte? CodEsportecultura { get; set; }

        public virtual TbCadPessoa CodPessoaNavigation { get; set; }
    }
}
