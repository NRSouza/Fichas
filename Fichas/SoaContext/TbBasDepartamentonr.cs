using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasDepartamentonr
    {
        public byte CodDepto { get; set; }
        public string NomDepto { get; set; }
        public string FlgReserva { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string FlgSistema { get; set; }
    }
}
