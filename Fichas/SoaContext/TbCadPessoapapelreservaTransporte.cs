using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoapapelreservaTransporte
    {
        public long CodPessoapapelreservaTransporte { get; set; }
        public long? CodPessoapapelreserva { get; set; }
        public long? CodPacoteonibusPoltronaIda { get; set; }
        public long? CodPacoteonibusPoltronaVolta { get; set; }
        public byte? CodMeiotransporteIda { get; set; }
        public byte? CodMeiotransporteVolta { get; set; }
        public string DesObstransporteIda { get; set; }
        public string DesObstransporteVolta { get; set; }
        public string DesCarroIda { get; set; }
        public string DesCarroVolta { get; set; }
        public string DesPlacaIda { get; set; }
        public string DesPlacaVolta { get; set; }
        public string DesCondutorIda { get; set; }
        public string DesCondutorVolta { get; set; }
        public DateTime? DatChegadacarroIda { get; set; }
        public DateTime? DatChegadacarroVolta { get; set; }
        public DateTime? DatAlocacao { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbBasMeiotransporte CodMeiotransporteIdaNavigation { get; set; }
        public virtual TbBasMeiotransporte CodMeiotransporteVoltaNavigation { get; set; }
        public virtual TbCadPessoapapelreserva CodPessoapapelreservaNavigation { get; set; }
    }
}
