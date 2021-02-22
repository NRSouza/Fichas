using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadRepresentanteagencia
    {
        public long CodRepresentanteagencia { get; set; }
        public int? CodAgenciarepresentante { get; set; }
        public int? CodUsuario { get; set; }

        public virtual TbCadUsuario CodUsuarioNavigation { get; set; }
    }
}
