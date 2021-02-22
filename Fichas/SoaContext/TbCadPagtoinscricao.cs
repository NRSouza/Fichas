using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPagtoinscricao
    {
        public TbCadPagtoinscricao()
        {
            TbCadPagtoinscricaoParcela = new HashSet<TbCadPagtoinscricaoParcela>();
        }

        public long CodPagtoinscricao { get; set; }
        public long? CodInscricao { get; set; }
        public byte? CodMeiospagto { get; set; }
        public int? CodCondpagto { get; set; }
        public decimal? ValIntegral { get; set; }
        public decimal? ValDesconto { get; set; }
        public decimal? ValCantinaintegral { get; set; }
        public decimal? ValCantina { get; set; }
        public DateTime? DatEnviopagto { get; set; }
        public string FlgPago { get; set; }
        public DateTime? DatPago { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string FlgSapiens { get; set; }
        public DateTime? DatEnvioSapiens { get; set; }
        public int? NumpedSapiens { get; set; }
        public string NumTidCielo { get; set; }
        public byte? CodStatusCielo { get; set; }
        public string DesMensagemDobradinha { get; set; }
        public DateTime? DatMensagemDobradinha { get; set; }

        public virtual TbCadInscricao CodInscricaoNavigation { get; set; }
        public virtual ICollection<TbCadPagtoinscricaoParcela> TbCadPagtoinscricaoParcela { get; set; }
    }
}
