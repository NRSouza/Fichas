using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasRacacor
    {
        public TbBasRacacor()
        {
            TbCadPessoaficha = new HashSet<TbCadPessoaficha>();
        }

        public byte CodRacacor { get; set; }
        public string DesRacacor { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual ICollection<TbCadPessoaficha> TbCadPessoaficha { get; set; }
    }
}
