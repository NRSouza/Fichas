using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasCategoria
    {
        public TbBasCategoria()
        {
            TbBasAssociacaoformulario = new HashSet<TbBasAssociacaoformulario>();
            TbBasCategoriaabati = new HashSet<TbBasCategoriaabati>();
            TbCadPessoapapel = new HashSet<TbCadPessoapapel>();
            TbCadPessoapapelCarga = new HashSet<TbCadPessoapapelCarga>();
        }

        public long CodCategoria { get; set; }
        public long CodTipopessoa { get; set; }
        public string DesCategoria { get; set; }
        public string FlgAtivo { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string FlgSistema { get; set; }
        public long? CodCategoriat { get; set; }

        public virtual TbBasTipopessoa CodTipopessoaNavigation { get; set; }
        public virtual ICollection<TbBasAssociacaoformulario> TbBasAssociacaoformulario { get; set; }
        public virtual ICollection<TbBasCategoriaabati> TbBasCategoriaabati { get; set; }
        public virtual ICollection<TbCadPessoapapel> TbCadPessoapapel { get; set; }
        public virtual ICollection<TbCadPessoapapelCarga> TbCadPessoapapelCarga { get; set; }
    }
}
