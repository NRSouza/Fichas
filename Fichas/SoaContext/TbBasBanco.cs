using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasBanco
    {
        public TbBasBanco()
        {
            TbBasAgencia = new HashSet<TbBasAgencia>();
            TbCadPessoadoc = new HashSet<TbCadPessoadoc>();
        }

        public int CodBanco { get; set; }
        public string CodFebraban { get; set; }
        public string DesBanco { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual ICollection<TbBasAgencia> TbBasAgencia { get; set; }
        public virtual ICollection<TbCadPessoadoc> TbCadPessoadoc { get; set; }
    }
}
