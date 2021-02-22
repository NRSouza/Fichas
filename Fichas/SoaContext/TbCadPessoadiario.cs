using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoadiario
    {
        public long CodPessoadiario { get; set; }
        public long? CodPessoa { get; set; }
        public byte? CodCategoriadiario { get; set; }
        public string DesDiario { get; set; }
        public string FlgAutomatico { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbCadPessoa CodPessoaNavigation { get; set; }
    }
}
