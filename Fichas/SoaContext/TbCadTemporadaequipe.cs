using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadTemporadaequipe
    {
        public TbCadTemporadaequipe()
        {
            TbCadTemporadaequipeFoto = new HashSet<TbCadTemporadaequipeFoto>();
            TbCadTemporadaequipePessoas = new HashSet<TbCadTemporadaequipePessoas>();
        }

        public long CodTemporadaequipe { get; set; }
        public long CodTemporadaturma { get; set; }
        public long? CodChale { get; set; }
        public string DesEquipe { get; set; }
        public string DesObs { get; set; }
        public long? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public long? CodResponsavelchale { get; set; }

        public virtual ICollection<TbCadTemporadaequipeFoto> TbCadTemporadaequipeFoto { get; set; }
        public virtual ICollection<TbCadTemporadaequipePessoas> TbCadTemporadaequipePessoas { get; set; }
    }
}
