using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadTurmanr
    {
        public TbCadTurmanr()
        {
            TbCadTurmanrAcampante = new HashSet<TbCadTurmanrAcampante>();
        }

        public long CodTurmanr { get; set; }
        public long? CodPacote { get; set; }
        public long? CodTurmanrUnif1 { get; set; }
        public long? CodTurmanrUnif2 { get; set; }
        public DateTime? DatAbertura { get; set; }
        public long? CodTemporada { get; set; }

        public virtual ICollection<TbCadTurmanrAcampante> TbCadTurmanrAcampante { get; set; }
    }
}
