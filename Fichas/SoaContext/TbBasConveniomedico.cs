using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasConveniomedico
    {
        public int CodConveniomedico { get; set; }
        public string DesConveniomedico { get; set; }
        public string NumTelefone { get; set; }
        public string DesSite { get; set; }
        public string DesObs { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
    }
}
