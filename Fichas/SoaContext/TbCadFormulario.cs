using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadFormulario
    {
        public TbCadFormulario()
        {
            TbBasAssociacaoformulario = new HashSet<TbBasAssociacaoformulario>();
            TbCadItemformulario = new HashSet<TbCadItemformulario>();
            TbCadPessoaformulario = new HashSet<TbCadPessoaformulario>();
        }

        public long CodFormulario { get; set; }
        public byte? CodUnidadenr { get; set; }
        public byte? CodFormularioFuncionalidade { get; set; }
        public string NomFormulario { get; set; }
        public string DesExplicacao { get; set; }
        public int? DesTempomaximo { get; set; }
        public string FlgAtivo { get; set; }
        public string FlgCancelar { get; set; }
        public string FlgTermoAutorizacao { get; set; }
        public string DesTermoAutorizacao { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbBasFormularioFuncionalidade CodFormularioFuncionalidadeNavigation { get; set; }
        public virtual TbCadUnidadenr CodUnidadenrNavigation { get; set; }
        public virtual ICollection<TbBasAssociacaoformulario> TbBasAssociacaoformulario { get; set; }
        public virtual ICollection<TbCadItemformulario> TbCadItemformulario { get; set; }
        public virtual ICollection<TbCadPessoaformulario> TbCadPessoaformulario { get; set; }
    }
}
