using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadEvento
    {
        public int CodEvento { get; set; }
        public byte? CodUnidadenr { get; set; }
        public string DesEvento { get; set; }
        public string CodTipoevento { get; set; }
        public DateTime? DatInicio { get; set; }
        public DateTime? DatTermino { get; set; }
        public int? DesQtdemin { get; set; }
        public int? DesQtdemax { get; set; }
        public string DesSeries { get; set; }
        public string DesInformacoes { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
    }
}
