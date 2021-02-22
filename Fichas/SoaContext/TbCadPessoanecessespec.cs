using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoanecessespec
    {
        public long CodPessoanecessespec { get; set; }
        public long? CodPessoa { get; set; }
        public byte? CodNecessespecial { get; set; }
        public string DesObs { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbBasNecessespecial CodNecessespecialNavigation { get; set; }
        public virtual TbCadPessoa CodPessoaNavigation { get; set; }
    }
}
