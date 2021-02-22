﻿using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadOnibusAlocacao
    {
        public long CodOnibusAlocacao { get; set; }
        public long? CodOnibusSaida { get; set; }
        public long? CodPessoapapelreserva { get; set; }
        public byte? NumPoltrona { get; set; }
        public string FlgNr { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string NomPessoaNr { get; set; }
        public string DesPessoargNr { get; set; }
        public string DesPessoacpfNr { get; set; }

        public virtual TbCadOnibusSaida CodOnibusSaidaNavigation { get; set; }
        public virtual TbCadPessoapapelreserva CodPessoapapelreservaNavigation { get; set; }
    }
}
