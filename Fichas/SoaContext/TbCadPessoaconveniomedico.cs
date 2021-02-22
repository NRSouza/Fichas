using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoaconveniomedico
    {
        public long CodPessoaconveniomedico { get; set; }
        public long? CodPessoa { get; set; }
        public string DesConveniomedico { get; set; }
        public string DesCategoriaconvenio { get; set; }
        public string NumCarteirinha { get; set; }
        public DateTime? DatValidade { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbCadPessoa CodPessoaNavigation { get; set; }
    }
}
