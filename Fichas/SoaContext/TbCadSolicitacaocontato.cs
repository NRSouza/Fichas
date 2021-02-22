using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadSolicitacaocontato
    {
        public TbCadSolicitacaocontato()
        {
            TbCadPropostacomercial = new HashSet<TbCadPropostacomercial>();
        }

        public int CodSolicitacaocontato { get; set; }
        public int? CodPermanencia { get; set; }
        public int? CodAgenciarepresentante { get; set; }
        public int? CodUsuarioalocado { get; set; }
        public string NomContato { get; set; }
        public string DesCargo { get; set; }
        public long? CodEscola { get; set; }
        public string DesEmail { get; set; }
        public string DesDddTelefone1 { get; set; }
        public string DesDddTelefone2 { get; set; }
        public string DesDddCelular { get; set; }
        public string DesTelefone1 { get; set; }
        public string DesTelefone2 { get; set; }
        public string DesCelular { get; set; }
        public string DesSeries { get; set; }
        public int? NumAlunos { get; set; }
        public string DesEvento { get; set; }
        public byte? DatMesevento { get; set; }
        public DateTime? DatEvento { get; set; }
        public string DesComentarios { get; set; }
        public string CodTipoevento { get; set; }
        public string FlgStatus { get; set; }
        public DateTime? DatCadastro { get; set; }
        public DateTime? DatValidade { get; set; }
        public DateTime? DatAssociacao { get; set; }
        public DateTime? DatPrimeiraproposta { get; set; }
        public DateTime? DatUltimaproposta { get; set; }
        public DateTime? DatPropostanr { get; set; }
        public DateTime? DatPropostacliente { get; set; }
        public DateTime? DatFechamento { get; set; }
        public string DesMotivofechamento { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual ICollection<TbCadPropostacomercial> TbCadPropostacomercial { get; set; }
    }
}
