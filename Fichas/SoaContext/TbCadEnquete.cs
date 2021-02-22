using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadEnquete
    {
        public TbCadEnquete()
        {
            TbCadEnquetetemporada = new HashSet<TbCadEnquetetemporada>();
            TbCadPessoaassistenteDisponibilidade = new HashSet<TbCadPessoaassistenteDisponibilidade>();
        }

        public long CodEnquete { get; set; }
        public string DesNomeEnquete { get; set; }
        public string FlgExibePortal { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual ICollection<TbCadEnquetetemporada> TbCadEnquetetemporada { get; set; }
        public virtual ICollection<TbCadPessoaassistenteDisponibilidade> TbCadPessoaassistenteDisponibilidade { get; set; }
    }
}
