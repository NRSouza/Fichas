using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasNecessespecial
    {
        public TbBasNecessespecial()
        {
            TbCadPessoanecessespec = new HashSet<TbCadPessoanecessespec>();
        }

        public byte CodNecessespecial { get; set; }
        public string DesNecessespecial { get; set; }
        public byte? ValOrdem { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual ICollection<TbCadPessoanecessespec> TbCadPessoanecessespec { get; set; }
    }
}
