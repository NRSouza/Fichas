using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoanrmail
    {
        public TbCadPessoanrmail()
        {
            TbCadNrmail = new HashSet<TbCadNrmail>();
        }

        public long CodPessoanrmail { get; set; }
        public string DesPessoanrmail { get; set; }
        public string DesEmail { get; set; }
        public string DesSenha { get; set; }
        public DateTime? DatCadastro { get; set; }

        public virtual ICollection<TbCadNrmail> TbCadNrmail { get; set; }
    }
}
