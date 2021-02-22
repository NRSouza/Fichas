using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadLancatividades
    {
        public long CodLancatividades { get; set; }
        public long CodPessoa { get; set; }
        public byte CodUnidadenr { get; set; }
        public long? CodPacote { get; set; }
        public byte? CodModalidade { get; set; }
        public long? CodPeriodoatividades { get; set; }
        public DateTime? DatAtividade { get; set; }
        public string DesComentario { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbBasModalidade CodModalidadeNavigation { get; set; }
        public virtual TbCadPacote CodPacoteNavigation { get; set; }
        public virtual TbBasPeriodoatividades CodPeriodoatividadesNavigation { get; set; }
        public virtual TbCadPessoa CodPessoaNavigation { get; set; }
        public virtual TbCadUnidadenr CodUnidadenrNavigation { get; set; }
    }
}
