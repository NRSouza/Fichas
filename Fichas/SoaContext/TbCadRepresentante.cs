using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadRepresentante
    {
        public TbCadRepresentante()
        {
            TbCadInscricao = new HashSet<TbCadInscricao>();
            TbCadInscricaoCarga = new HashSet<TbCadInscricaoCarga>();
        }

        public long CodRepresentante { get; set; }
        public int? CodCidade { get; set; }
        public string CodUf { get; set; }
        public string DesRepresentante { get; set; }
        public string DesEmail { get; set; }
        public string DesTelefone { get; set; }
        public string DesInfoadicional { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string FlgAtivo { get; set; }

        public virtual ICollection<TbCadInscricao> TbCadInscricao { get; set; }
        public virtual ICollection<TbCadInscricaoCarga> TbCadInscricaoCarga { get; set; }
    }
}
