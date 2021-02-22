using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoapapelreservaDobra
    {
        public long CodPessoapapelreservaDobra { get; set; }
        public long? CodPessoa { get; set; }
        public long? CodPessoapapelreserva { get; set; }
        public long? CodDobra { get; set; }
        public DateTime? DatDobra { get; set; }

        public virtual TbCadPessoa CodPessoaNavigation { get; set; }
        public virtual TbCadPessoapapelreserva CodPessoapapelreservaNavigation { get; set; }
    }
}
