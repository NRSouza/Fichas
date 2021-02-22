using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasNacionalidade
    {
        public TbBasNacionalidade()
        {
            TbCadPessoaficha = new HashSet<TbCadPessoaficha>();
        }

        public int CodNacionalidade { get; set; }
        public string DesNacionalidade { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string FlgSistema { get; set; }

        public virtual ICollection<TbCadPessoaficha> TbCadPessoaficha { get; set; }
    }
}
