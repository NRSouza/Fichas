using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadInscricaoCarga
    {
        public long CodInscricao { get; set; }
        public long? CodPessoapapelreserva { get; set; }
        public long? CodPessoa { get; set; }
        public long? CodPessoaCobranca { get; set; }
        public byte? CodMeiotransporteIda { get; set; }
        public byte? CodMeiotransporteVolta { get; set; }
        public string DesObsTransporteida { get; set; }
        public string DesObsTransportevolta { get; set; }
        public string DesSenhaturmanr { get; set; }
        public DateTime? DatInscricao { get; set; }
        public DateTime? DatConfirmacao { get; set; }
        public string FlgStatus { get; set; }
        public string FlgRepresentante { get; set; }
        public string FlgLiberacaoTurmanr { get; set; }
        public long? CodRepresentante { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbCadPessoapapelreservaCarga CodPessoapapelreservaNavigation { get; set; }
        public virtual TbCadRepresentante CodRepresentanteNavigation { get; set; }
    }
}
