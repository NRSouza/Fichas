using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadDocumento
    {
        public int CodDocumento { get; set; }
        public byte? CodTipodoctemplate { get; set; }
        public string DesTitulo { get; set; }
        public string DesConteudo { get; set; }
        public string FlgAtivo { get; set; }
        public DateTime? DatCriacao { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string CodSendgrid { get; set; }

        public virtual TbBasTipodoctemplate CodTipodoctemplateNavigation { get; set; }
    }
}
