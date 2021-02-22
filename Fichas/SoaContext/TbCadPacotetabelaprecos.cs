using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPacotetabelaprecos
    {
        public TbCadPacotetabelaprecos()
        {
            TbCadPacoteprecos = new HashSet<TbCadPacoteprecos>();
        }

        public long CodPacotetabelaprecos { get; set; }
        public long? CodPacote { get; set; }
        public string DesPacotetabelaprecos { get; set; }
        public DateTime? DatInicio { get; set; }
        public DateTime? DatFim { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string FlgCalouro { get; set; }
        public string FlgVeterano { get; set; }

        public virtual ICollection<TbCadPacoteprecos> TbCadPacoteprecos { get; set; }
    }
}
