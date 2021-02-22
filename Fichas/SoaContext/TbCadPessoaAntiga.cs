using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoaAntiga
    {
        public long CodPessoaAntiga { get; set; }
        public string CodDepositoidentificado { get; set; }
        public string NomPessoa { get; set; }
        public string DesEmaillogin { get; set; }
        public string DesSenha { get; set; }
        public string DesLembretesenha { get; set; }
        public string DesImagem { get; set; }
        public string FlgAtivo { get; set; }
        public DateTime? DatCadastro { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string FlgLiberado { get; set; }
        public DateTime? DatLiberacao { get; set; }
        public string DesMensagembloqueio { get; set; }
        public int? CodClienteSapiens { get; set; }
        public string FlgVideoPortal { get; set; }
        public string FlgExterior { get; set; }
    }
}
