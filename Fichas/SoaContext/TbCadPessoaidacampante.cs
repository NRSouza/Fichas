using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoaidacampante
    {
        public long CodPessoaidacampante { get; set; }
        public long CodPessoa { get; set; }
        public long? CodPessoaidacampantet { get; set; }

        public virtual TbCadPessoa CodPessoaNavigation { get; set; }
    }
}
