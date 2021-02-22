using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadSmsComunicacaoTransportehist
    {
        public long CodSmsComunicacaoTransportehist { get; set; }
        public long? CodSmsComunicacaoTransporte { get; set; }
        public long? CodPessoapapelreserva { get; set; }
        public long? CodResponsavel { get; set; }
        public string NumCelular { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbCadPessoapapelreserva CodPessoapapelreservaNavigation { get; set; }
        public virtual TbCadPessoa CodResponsavelNavigation { get; set; }
        public virtual TbCadSmsComunicacaoTransporte CodSmsComunicacaoTransporteNavigation { get; set; }
    }
}
