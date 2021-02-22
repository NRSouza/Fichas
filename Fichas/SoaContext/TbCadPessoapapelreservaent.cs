using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoapapelreservaent
    {
        public long CodPessoapapelreservaent { get; set; }
        public long? CodPessoapapelreserva { get; set; }
        public long? CodEntrevistador { get; set; }
        public DateTime? DatEntrevista { get; set; }
        public string DesDuracao { get; set; }
        public string DesLocalentrevista { get; set; }
        public string DesObs { get; set; }
        public string FlgCancelada { get; set; }
        public string FlgRemarcacao { get; set; }
        public string FlgRealizada { get; set; }
        public string FlgAvisar { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbCadPessoapapelreserva CodPessoapapelreservaNavigation { get; set; }
    }
}
