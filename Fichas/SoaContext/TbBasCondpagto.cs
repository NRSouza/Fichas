using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasCondpagto
    {
        public TbBasCondpagto()
        {
            TbCadPacoteprecos = new HashSet<TbCadPacoteprecos>();
            TbCadPagamentoCondmeio = new HashSet<TbCadPagamentoCondmeio>();
        }

        public int CodCondpagto { get; set; }
        public byte? CodMeiospagto { get; set; }
        public string CodSapiens { get; set; }
        public string DesCondpagto { get; set; }
        public string DesAbreviatura { get; set; }
        public string FlgAtivo { get; set; }
        public byte? NumParcelas { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual ICollection<TbCadPacoteprecos> TbCadPacoteprecos { get; set; }
        public virtual ICollection<TbCadPagamentoCondmeio> TbCadPagamentoCondmeio { get; set; }
    }
}
