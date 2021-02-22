using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasDistribuicaochale
    {
        public TbBasDistribuicaochale()
        {
            TbCadTemporadaequipePessoas = new HashSet<TbCadTemporadaequipePessoas>();
        }

        public byte CodDistribuicaochale { get; set; }
        public string DesDistribuicaochale { get; set; }
        public string DesIcone { get; set; }

        public virtual ICollection<TbCadTemporadaequipePessoas> TbCadTemporadaequipePessoas { get; set; }
    }
}
