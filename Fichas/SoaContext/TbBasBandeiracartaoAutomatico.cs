using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasBandeiracartaoAutomatico
    {
        public long CodBandeiracartaoAutomatico { get; set; }
        public byte? CodBandeiracartao { get; set; }
        public string NumCartaoComecacom { get; set; }

        public virtual TbBasBandeiracartao CodBandeiracartaoNavigation { get; set; }
    }
}
