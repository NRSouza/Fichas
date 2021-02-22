using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasMeiotransporte
    {
        public TbBasMeiotransporte()
        {
            TbCadPessoapapelreservaTransporteCodMeiotransporteIdaNavigation = new HashSet<TbCadPessoapapelreservaTransporte>();
            TbCadPessoapapelreservaTransporteCodMeiotransporteVoltaNavigation = new HashSet<TbCadPessoapapelreservaTransporte>();
            TbCadSmsComunicacaoTransporte = new HashSet<TbCadSmsComunicacaoTransporte>();
        }

        public byte CodMeiotransporte { get; set; }
        public string DesMeiotransporte { get; set; }
        public string FlgInformacoes { get; set; }
        public string FlgPortal { get; set; }
        public string DesObs { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string FlgSistema { get; set; }

        public virtual ICollection<TbCadPessoapapelreservaTransporte> TbCadPessoapapelreservaTransporteCodMeiotransporteIdaNavigation { get; set; }
        public virtual ICollection<TbCadPessoapapelreservaTransporte> TbCadPessoapapelreservaTransporteCodMeiotransporteVoltaNavigation { get; set; }
        public virtual ICollection<TbCadSmsComunicacaoTransporte> TbCadSmsComunicacaoTransporte { get; set; }
    }
}
