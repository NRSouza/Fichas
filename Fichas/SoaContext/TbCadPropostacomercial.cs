using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPropostacomercial
    {
        public long CodPropostacomercial { get; set; }
        public int? CodSolicitacaocontato { get; set; }
        public byte? CodUnidadenr { get; set; }
        public int? CodEvento { get; set; }
        public string DesEvento { get; set; }
        public int? CodDocumento { get; set; }
        public int? NumAlunos { get; set; }
        public decimal? ValAluno { get; set; }
        public string DesComentario { get; set; }
        public string DesComentarioaprovacao { get; set; }
        public DateTime? DatInicio { get; set; }
        public DateTime? DatTermino { get; set; }
        public DateTime? DatValidade { get; set; }
        public string DesDocumento { get; set; }
        public string NomArquivo { get; set; }
        public string FlgEnviado { get; set; }
        public string FlgAprovadonr { get; set; }
        public DateTime? DatAprovacaonr { get; set; }
        public string FlgAprovadocli { get; set; }
        public DateTime? DatAprovacaocli { get; set; }
        public string FlgSolicitaraprovacao { get; set; }
        public string FlgStatus { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbCadSolicitacaocontato CodSolicitacaocontatoNavigation { get; set; }
    }
}
