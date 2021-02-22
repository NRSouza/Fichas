using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadTemporadaequipeFoto
    {
        public long CodTemporadaequipeFoto { get; set; }
        public long? CodTemporadaequipe { get; set; }
        public string DesImagem { get; set; }
        public string DesObs { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbCadTemporadaequipe CodTemporadaequipeNavigation { get; set; }
        public virtual TbCadUsuario CodUsuarioNavigation { get; set; }
    }
}
