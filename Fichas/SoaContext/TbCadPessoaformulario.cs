using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoaformulario
    {
        public TbCadPessoaformulario()
        {
            TbCadPessoaformulariores = new HashSet<TbCadPessoaformulariores>();
        }

        public long CodPessoaformulario { get; set; }
        public long? CodPessoa { get; set; }
        public long? CodFormulario { get; set; }
        public long? CodPessoaformularioOrigem { get; set; }
        public DateTime? DatLiberacao { get; set; }
        public DateTime? DatLimite { get; set; }
        public DateTime? DatInicio { get; set; }
        public DateTime? DatTermino { get; set; }
        public string FlgStatus { get; set; }
        public string FlgOculto { get; set; }
        public string DesTermoAutorizacao { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbCadFormulario CodFormularioNavigation { get; set; }
        public virtual ICollection<TbCadPessoaformulariores> TbCadPessoaformulariores { get; set; }
    }
}
