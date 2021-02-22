using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasAgencia
    {
        public TbBasAgencia()
        {
            TbCadPessoadoc = new HashSet<TbCadPessoadoc>();
        }

        public int IdAgencia { get; set; }
        public int? CodBanco { get; set; }
        public string CodAgencia { get; set; }
        public string DesNomeagencia { get; set; }
        public int? CodMunicipio { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbBasBanco CodBancoNavigation { get; set; }
        public virtual ICollection<TbCadPessoadoc> TbCadPessoadoc { get; set; }
    }
}
