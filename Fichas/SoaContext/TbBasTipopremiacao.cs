using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasTipopremiacao
    {
        public TbBasTipopremiacao()
        {
            TbCadPessoapremiacao = new HashSet<TbCadPessoapremiacao>();
        }

        public long CodTipopremiacao { get; set; }
        public string DesTipopremiacao { get; set; }
        public string FlgAtivo { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual ICollection<TbCadPessoapremiacao> TbCadPessoapremiacao { get; set; }
    }
}
