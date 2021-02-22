using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasTipocamiseta
    {
        public TbBasTipocamiseta()
        {
            TbCadPessoaassistenteDisponibilidade = new HashSet<TbCadPessoaassistenteDisponibilidade>();
        }

        public long CodTipocamiseta { get; set; }
        public string DesTipocamiseta { get; set; }
        public string FlgAtivo { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string DesReduzida { get; set; }

        public virtual ICollection<TbCadPessoaassistenteDisponibilidade> TbCadPessoaassistenteDisponibilidade { get; set; }
    }
}
