using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadCupomItem
    {
        public TbCadCupomItem()
        {
            TbCadEscPagamento = new HashSet<TbCadEscPagamento>();
            TbCadPagamento = new HashSet<TbCadPagamento>();
        }

        public long CodCupomItem { get; set; }
        public long CodCupom { get; set; }
        public string DesCodCupom { get; set; }
        public string FlgUtilizado { get; set; }
        public int? NumUtilizado { get; set; }
        public DateTime? DatUtilizacao { get; set; }
        public string FlgPago { get; set; }
        public DateTime? DatPago { get; set; }

        public virtual TbCadCupom CodCupomNavigation { get; set; }
        public virtual ICollection<TbCadEscPagamento> TbCadEscPagamento { get; set; }
        public virtual ICollection<TbCadPagamento> TbCadPagamento { get; set; }
    }
}
