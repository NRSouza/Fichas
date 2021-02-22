using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoaexpprofissional
    {
        public long CodPessoaexpprofissional { get; set; }
        public long? CodPessoa { get; set; }
        public string NomEmpresa { get; set; }
        public string DesLocal { get; set; }
        public string DesCargo { get; set; }
        public string DesAtividades { get; set; }
        public decimal? ValSalario { get; set; }
        public DateTime? DatInicio { get; set; }
        public DateTime? DatFim { get; set; }
        public string FlgAtivo { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string FlgCondicao { get; set; }

        public virtual TbCadPessoa CodPessoaNavigation { get; set; }
    }
}
