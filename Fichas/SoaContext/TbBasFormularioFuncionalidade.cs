using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasFormularioFuncionalidade
    {
        public TbBasFormularioFuncionalidade()
        {
            TbCadFormulario = new HashSet<TbCadFormulario>();
        }

        public byte CodFormularioFuncionalidade { get; set; }
        public string DesFormularioFuncionalidade { get; set; }

        public virtual ICollection<TbCadFormulario> TbCadFormulario { get; set; }
    }
}
