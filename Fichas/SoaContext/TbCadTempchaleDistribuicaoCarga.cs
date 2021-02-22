using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadTempchaleDistribuicaoCarga
    {
        public long CodTempchaleDistribuicao { get; set; }
        public long? CodTemporadachale { get; set; }
        public byte? CodDistribuicaochale { get; set; }
        public byte? DesQtde { get; set; }

        public virtual TbCadTemporadachaleCarga CodTemporadachaleNavigation { get; set; }
    }
}
