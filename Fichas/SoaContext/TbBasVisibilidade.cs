using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasVisibilidade
    {
        public TbBasVisibilidade()
        {
            TbBasVisibilidadeUnidades = new HashSet<TbBasVisibilidadeUnidades>();
        }

        public byte CodVisibilidade { get; set; }
        public string DesVisibilidade { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual ICollection<TbBasVisibilidadeUnidades> TbBasVisibilidadeUnidades { get; set; }
    }
}
