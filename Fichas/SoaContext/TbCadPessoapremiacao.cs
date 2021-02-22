using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoapremiacao
    {
        public long CodPessoapremiacao { get; set; }
        public long? CodPessoa { get; set; }
        public long? CodPacote { get; set; }
        public long? CodTipopremiacao { get; set; }
        public DateTime? DatPremiacao { get; set; }
        public string DesComentarios { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbCadPacote CodPacoteNavigation { get; set; }
        public virtual TbCadPessoa CodPessoaNavigation { get; set; }
        public virtual TbBasTipopremiacao CodTipopremiacaoNavigation { get; set; }
    }
}
