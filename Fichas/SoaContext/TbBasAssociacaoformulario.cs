using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasAssociacaoformulario
    {
        public long CodAssociacaoformulario { get; set; }
        public long? CodCategoria { get; set; }
        public long? CodFormulario { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string FlgCalouro { get; set; }
        public string FlgVeterano { get; set; }
        public byte? CodUnidadenr { get; set; }
        public long? CodPacote { get; set; }

        public virtual TbBasCategoria CodCategoriaNavigation { get; set; }
        public virtual TbCadFormulario CodFormularioNavigation { get; set; }
    }
}
