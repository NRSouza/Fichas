using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadMensagensgerais
    {
        public int CodMensagensgerais { get; set; }
        public byte? CodTipomensagem { get; set; }
        public string DesMensagem { get; set; }
        public string DesIdioma { get; set; }
        public string FlgAtivo { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbBasTipomensagem CodTipomensagemNavigation { get; set; }
    }
}
