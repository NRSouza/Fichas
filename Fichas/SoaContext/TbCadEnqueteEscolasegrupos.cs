using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadEnqueteEscolasegrupos
    {
        public long CodEnqueteEscolasegrupos { get; set; }
        public string DesEnquete { get; set; }
        public string FlgExibePortal { get; set; }
        public DateTime? DatInicio { get; set; }
        public DateTime? DatFinal { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
    }
}
