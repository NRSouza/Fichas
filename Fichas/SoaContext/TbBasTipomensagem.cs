using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasTipomensagem
    {
        public TbBasTipomensagem()
        {
            TbCadMensagensgerais = new HashSet<TbCadMensagensgerais>();
        }

        public byte CodTipomensagem { get; set; }
        public string DesTipomensagem { get; set; }

        public virtual ICollection<TbCadMensagensgerais> TbCadMensagensgerais { get; set; }
    }
}
