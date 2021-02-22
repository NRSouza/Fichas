using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasFuncionalidade
    {
        public TbBasFuncionalidade()
        {
            TbCadEmails = new HashSet<TbCadEmails>();
            TbCadUsuarioatalho = new HashSet<TbCadUsuarioatalho>();
        }

        public long CodFuncionalidade { get; set; }
        public string DesFuncionalidade { get; set; }
        public int? DesOrdem { get; set; }
        public string FlgAtivo { get; set; }
        public string DesMenu { get; set; }
        public string DesImg { get; set; }
        public string DesLink { get; set; }

        public virtual ICollection<TbCadEmails> TbCadEmails { get; set; }
        public virtual ICollection<TbCadUsuarioatalho> TbCadUsuarioatalho { get; set; }
    }
}
