using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasModalidade
    {
        public TbBasModalidade()
        {
            TbBasModalidadeUnidades = new HashSet<TbBasModalidadeUnidades>();
            TbCadLancatividades = new HashSet<TbCadLancatividades>();
        }

        public byte CodModalidade { get; set; }
        public string DesModalidade { get; set; }
        public string FlgAtivo { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual ICollection<TbBasModalidadeUnidades> TbBasModalidadeUnidades { get; set; }
        public virtual ICollection<TbCadLancatividades> TbCadLancatividades { get; set; }
    }
}
