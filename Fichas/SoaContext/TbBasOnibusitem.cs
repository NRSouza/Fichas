using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasOnibusitem
    {
        public TbBasOnibusitem()
        {
            TbBasOnibusopcaoitem = new HashSet<TbBasOnibusopcaoitem>();
        }

        public byte CodOnibusitem { get; set; }
        public string DesOnibusitem { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual ICollection<TbBasOnibusopcaoitem> TbBasOnibusopcaoitem { get; set; }
    }
}
