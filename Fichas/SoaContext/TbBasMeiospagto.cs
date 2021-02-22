using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasMeiospagto
    {
        public TbBasMeiospagto()
        {
            TbCadPagamentoCondmeio = new HashSet<TbCadPagamentoCondmeio>();
        }

        public byte CodMeiospagto { get; set; }
        public string CodMeiossapiens { get; set; }
        public string DesMeiospagto { get; set; }
        public string DesObs { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string FlgSistema { get; set; }

        public virtual ICollection<TbCadPagamentoCondmeio> TbCadPagamentoCondmeio { get; set; }
    }
}
