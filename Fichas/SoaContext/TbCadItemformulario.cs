using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadItemformulario
    {
        public long CodItemformulario { get; set; }
        public long? CodFormulario { get; set; }
        public string DesPergunta { get; set; }
        public string DesParametros { get; set; }
        public string DesExplicacao { get; set; }
        public int? DesOrdem { get; set; }
        public string FlgTipo { get; set; }
        public string FlgObservacoes { get; set; }
        public string FlgAtivo { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string FlgOrientacao { get; set; }
        public string FlgTamanho { get; set; }

        public virtual TbCadFormulario CodFormularioNavigation { get; set; }
    }
}
