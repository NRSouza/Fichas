using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasTipodoctemplate
    {
        public TbBasTipodoctemplate()
        {
            TbCadDocumento = new HashSet<TbCadDocumento>();
        }

        public byte CodTipodoctemplate { get; set; }
        public string DesTipodoctemplate { get; set; }

        public virtual ICollection<TbCadDocumento> TbCadDocumento { get; set; }
    }
}
