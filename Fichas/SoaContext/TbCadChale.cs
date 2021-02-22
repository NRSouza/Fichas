using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadChale
    {
        public TbCadChale()
        {
            TbCadTemporadachale = new HashSet<TbCadTemporadachale>();
        }

        public long CodChale { get; set; }
        public byte? CodUnidadenr { get; set; }
        public string DesChale { get; set; }
        public string DesDetalhes { get; set; }
        public string DesGenero { get; set; }
        public string DesImagem { get; set; }
        public byte? NumVagas { get; set; }
        public string FlgAtivo { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbCadUnidadenr CodUnidadenrNavigation { get; set; }
        public virtual ICollection<TbCadTemporadachale> TbCadTemporadachale { get; set; }
    }
}
