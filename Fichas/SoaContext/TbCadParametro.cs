using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadParametro
    {
        public int CodParametro { get; set; }
        public byte? CodGrupoparametro { get; set; }
        public string DesChave { get; set; }
        public string ValParametro { get; set; }
        public string DesExplicacao { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string FlgSistema { get; set; }
    }
}
