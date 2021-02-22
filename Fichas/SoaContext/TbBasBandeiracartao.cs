using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasBandeiracartao
    {
        public TbBasBandeiracartao()
        {
            TbBasBandeiracartaoAutomatico = new HashSet<TbBasBandeiracartaoAutomatico>();
        }

        public byte CodBandeiracartao { get; set; }
        public string DesBandeiracartao { get; set; }
        public string DesSiglabandeiracartao { get; set; }
        public string FlgCreditoavista { get; set; }
        public string FlgCreditoparcelado { get; set; }
        public string FlgDebito { get; set; }
        public string FlgGateway { get; set; }
        public string FlgAtivo { get; set; }
        public byte? NumCvc { get; set; }
        public byte? NumMaximoCartao { get; set; }

        public virtual ICollection<TbBasBandeiracartaoAutomatico> TbBasBandeiracartaoAutomatico { get; set; }
    }
}
