using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasPeriodoatividades
    {
        public TbBasPeriodoatividades()
        {
            TbCadLancatividades = new HashSet<TbCadLancatividades>();
        }

        public long CodPeriodoatividades { get; set; }
        public byte? CodUnidadenr { get; set; }
        public string DesPeriodo { get; set; }
        public string DesInicio { get; set; }
        public string DesTermino { get; set; }
        public string FlgDomingo { get; set; }
        public string FlgSegunda { get; set; }
        public string FlgTerca { get; set; }
        public string FlgQuarta { get; set; }
        public string FlgQuinta { get; set; }
        public string FlgSexta { get; set; }
        public string FlgSabado { get; set; }
        public string FlgFeriado { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual ICollection<TbCadLancatividades> TbCadLancatividades { get; set; }
    }
}
