using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoaformulariores
    {
        public long CodPessoaformulariores { get; set; }
        public long? CodPessoaformulario { get; set; }
        public long? CodItemformulario { get; set; }
        public string DesResposta { get; set; }
        public string DesComentario { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbCadPessoaformulario CodPessoaformularioNavigation { get; set; }
    }
}
