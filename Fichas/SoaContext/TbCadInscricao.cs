using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadInscricao
    {
        public TbCadInscricao()
        {
            TbCadPagamentoAcampante = new HashSet<TbCadPagamentoAcampante>();
            TbCadPagtoinscricao = new HashSet<TbCadPagtoinscricao>();
        }

        public long CodInscricao { get; set; }
        public long? CodPessoapapelreserva { get; set; }
        public long? CodPessoa { get; set; }
        public long? CodPessoaCobranca { get; set; }
        public string DesSenhaturmanr { get; set; }
        public DateTime? DatInscricao { get; set; }
        public DateTime? DatConfirmacao { get; set; }
        public string FlgStatus { get; set; }
        public string FlgRepresentante { get; set; }
        public string FlgLiberacaoTurmanr { get; set; }
        public long? CodRepresentante { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string FlgAutorizacaoCobranca { get; set; }
        public byte? NumTentativasCielo { get; set; }
        public string DesContrato { get; set; }
        public DateTime? DatContrato { get; set; }
        public string FlgSapiens { get; set; }
        public DateTime? DatEnvioSapiens { get; set; }
        public int? NumPedSapiens { get; set; }
        public string FlgInterrompido { get; set; }
        public string DesMotivoInterrompido { get; set; }
        public int? CodUsuarioInterrompido { get; set; }
        public DateTime? DatInterrompido { get; set; }
        public string DesInformacaoInterrompido { get; set; }
        public DateTime? DatInicioInterrompido { get; set; }
        public string NomPessoaAlt { get; set; }
        public string EmailRespAlt { get; set; }
        public string ParentAlt { get; set; }

        public virtual TbCadPessoapapelreserva CodPessoapapelreservaNavigation { get; set; }
        public virtual TbCadRepresentante CodRepresentanteNavigation { get; set; }
        public virtual ICollection<TbCadPagamentoAcampante> TbCadPagamentoAcampante { get; set; }
        public virtual ICollection<TbCadPagtoinscricao> TbCadPagtoinscricao { get; set; }
    }
}
