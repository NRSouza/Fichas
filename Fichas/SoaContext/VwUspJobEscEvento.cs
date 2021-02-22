using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class VwUspJobEscEvento
    {
        public decimal CodPedido { get; set; }
        public int CodEscola { get; set; }
        public string CodUnidadenr { get; set; }
        public string CodEvento { get; set; }
        public string DesEvento { get; set; }
        public string DesEscola { get; set; }
        public int? QtdParcela { get; set; }
        public DateTime? DatEntrada { get; set; }
        public DateTime? DatSaida { get; set; }
        public decimal? CodRepresentante { get; set; }
        public string DesRepresentante { get; set; }
        public string DesCidade { get; set; }
        public string DesUf { get; set; }
    }
}
