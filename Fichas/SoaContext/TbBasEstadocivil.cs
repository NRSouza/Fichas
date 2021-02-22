using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasEstadocivil
    {
        public TbBasEstadocivil()
        {
            TbCadPessoaficha = new HashSet<TbCadPessoaficha>();
        }

        public byte CodEstadocivil { get; set; }
        public string DesEstadocivil { get; set; }
        public string DesEstadocivilAbrev { get; set; }
        public byte? ValOrdem { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string FlgSistema { get; set; }

        public virtual ICollection<TbCadPessoaficha> TbCadPessoaficha { get; set; }
    }
}
