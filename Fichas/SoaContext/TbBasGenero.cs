using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasGenero
    {
        public TbBasGenero()
        {
            TbCadTemporadachale = new HashSet<TbCadTemporadachale>();
            TbCadTemporadachaleCarga = new HashSet<TbCadTemporadachaleCarga>();
        }

        public string CodGenero { get; set; }
        public string DesGeneroRed { get; set; }
        public string DesGenero { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string FlgSistema { get; set; }

        public virtual ICollection<TbCadTemporadachale> TbCadTemporadachale { get; set; }
        public virtual ICollection<TbCadTemporadachaleCarga> TbCadTemporadachaleCarga { get; set; }
    }
}
