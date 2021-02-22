using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoaidioma
    {
        public long CodPessoaidioma { get; set; }
        public long? CodPessoa { get; set; }
        public byte? CodIdioma { get; set; }
        public byte? ValDominio { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
    }
}
