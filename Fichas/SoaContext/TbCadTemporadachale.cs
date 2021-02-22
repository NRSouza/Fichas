using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadTemporadachale
    {
        public TbCadTemporadachale()
        {
            TbCadTempchaleDistribuicao = new HashSet<TbCadTempchaleDistribuicao>();
        }

        public long CodTemporadachale { get; set; }
        public long? CodTemporada { get; set; }
        public long? CodChale { get; set; }
        public string CodGenero { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbCadChale CodChaleNavigation { get; set; }
        public virtual TbBasGenero CodGeneroNavigation { get; set; }
        public virtual TbCadTemporada CodTemporadaNavigation { get; set; }
        public virtual ICollection<TbCadTempchaleDistribuicao> TbCadTempchaleDistribuicao { get; set; }
    }
}
