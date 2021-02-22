using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadCupom
    {
        public TbCadCupom()
        {
            TbCadCupomItem = new HashSet<TbCadCupomItem>();
        }

        public long CodCupom { get; set; }
        public string DesCupom { get; set; }
        public string FlgModulo { get; set; }
        public string FlgTirounico { get; set; }
        public string FlgTipo { get; set; }
        public decimal? ValCupomDinheiro { get; set; }
        public int? ValCupomPorcentagem { get; set; }
        public DateTime? DatInicio { get; set; }
        public DateTime? DatTermino { get; set; }
        public string DesDescricao { get; set; }
        public string FlgAtivo { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual ICollection<TbCadCupomItem> TbCadCupomItem { get; set; }
    }
}
