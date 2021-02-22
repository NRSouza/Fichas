using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoaassistenteDisponibilidadeTemp
    {
        public long CodPessoaassistenteDisponibilidadeTemp { get; set; }
        public long? CodPessoaassistenteDisponibilidade { get; set; }
        public long? CodTemporada { get; set; }

        public virtual TbCadPessoaassistenteDisponibilidade CodPessoaassistenteDisponibilidadeNavigation { get; set; }
    }
}
