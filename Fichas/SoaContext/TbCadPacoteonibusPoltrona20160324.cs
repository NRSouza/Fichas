using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPacoteonibusPoltrona20160324
    {
        public long CodPacoteonibusPoltrona { get; set; }
        public long? CodPacoteonibus { get; set; }
        public long? CodPessoapapelreserva { get; set; }
        public byte? NumPoltrona { get; set; }
        public string FlgOperacao { get; set; }
        public string FlgNr { get; set; }

        public virtual TbCadPacoteonibus20160324 CodPacoteonibusNavigation { get; set; }
        public virtual TbCadPessoapapelreserva CodPessoapapelreservaNavigation { get; set; }
    }
}
