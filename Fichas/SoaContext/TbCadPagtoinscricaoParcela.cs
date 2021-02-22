using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPagtoinscricaoParcela
    {
        public long CodPagtoinscricaoParcela { get; set; }
        public long? CodPagtoinscricao { get; set; }
        public int? NumParcela { get; set; }
        public decimal? ValParcela { get; set; }
        public DateTime? DatParcela { get; set; }
        public DateTime? DatPagtoparcela { get; set; }
        public decimal? ValPagtoparcela { get; set; }
        public string NumBoleto { get; set; }
        public int? CodBancoCheque { get; set; }
        public int? CodAgenciaCheque { get; set; }
        public string DesEmitenteCheque { get; set; }
        public string DesCcCheque { get; set; }
        public string DesNumeroCheque { get; set; }

        public virtual TbCadPagtoinscricao CodPagtoinscricaoNavigation { get; set; }
    }
}
