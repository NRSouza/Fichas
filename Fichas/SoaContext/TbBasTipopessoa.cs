using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasTipopessoa
    {
        public TbBasTipopessoa()
        {
            TbBasCategoria = new HashSet<TbBasCategoria>();
        }

        public long CodTipopessoa { get; set; }
        public string DesTipopessoa { get; set; }
        public string DesIconegrande { get; set; }
        public string DesIconepequeno { get; set; }
        public string DesUrl { get; set; }
        public string FlgAtivo { get; set; }

        public virtual ICollection<TbBasCategoria> TbBasCategoria { get; set; }
    }
}
