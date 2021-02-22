using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadSmsComunicacaoTransporte
    {
        public TbCadSmsComunicacaoTransporte()
        {
            TbCadSmsComunicacaoTransportehist = new HashSet<TbCadSmsComunicacaoTransportehist>();
        }

        public long CodSmsComunicacaoTransporte { get; set; }
        public long? CodPacote { get; set; }
        public byte? CodMeiotransporte { get; set; }
        public string DesMensagem { get; set; }
        public string FlgOperacao { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbBasMeiotransporte CodMeiotransporteNavigation { get; set; }
        public virtual TbCadPacote CodPacoteNavigation { get; set; }
        public virtual ICollection<TbCadSmsComunicacaoTransportehist> TbCadSmsComunicacaoTransportehist { get; set; }
    }
}
