using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasPais
    {
        public TbBasPais()
        {
            TbCadEscola = new HashSet<TbCadEscola>();
            TbCadEscolaendereco = new HashSet<TbCadEscolaendereco>();
        }

        public int CodPais { get; set; }
        public string NomPais { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string FlgSistema { get; set; }

        public virtual ICollection<TbCadEscola> TbCadEscola { get; set; }
        public virtual ICollection<TbCadEscolaendereco> TbCadEscolaendereco { get; set; }
    }
}
