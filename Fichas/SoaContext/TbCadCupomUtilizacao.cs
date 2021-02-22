using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadCupomUtilizacao
    {
        public long CodCupomUtilizacao { get; set; }
        public long? CodCupom { get; set; }
        public long? CodCupomItem { get; set; }
        public string FlgModulo { get; set; }
        public long? CodPagamento { get; set; }
        public long? CodReserva { get; set; }
        public long? CodUsuario { get; set; }
        public string DesIp { get; set; }
        public DateTime? DatUtilizacao { get; set; }
    }
}
