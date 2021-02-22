using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadRemessa
    {
        public long CodRemessa { get; set; }
        public string DesRemessa { get; set; }
        public string DesArquivoremessa { get; set; }
        public DateTime? DatRemessa { get; set; }
    }
}
