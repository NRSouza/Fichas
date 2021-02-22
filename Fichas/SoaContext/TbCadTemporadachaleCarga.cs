using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadTemporadachaleCarga
    {
        public TbCadTemporadachaleCarga()
        {
            TbCadTempchaleDistribuicaoCarga = new HashSet<TbCadTempchaleDistribuicaoCarga>();
        }

        public long CodTemporadachale { get; set; }
        public long? CodTemporada { get; set; }
        public long? CodChale { get; set; }
        public string CodGenero { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbCadChaleCarga CodChaleNavigation { get; set; }
        public virtual TbBasGenero CodGeneroNavigation { get; set; }
        public virtual TbCadTemporadaCarga CodTemporadaNavigation { get; set; }
        public virtual ICollection<TbCadTempchaleDistribuicaoCarga> TbCadTempchaleDistribuicaoCarga { get; set; }
    }
}
