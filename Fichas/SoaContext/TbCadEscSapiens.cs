using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadEscSapiens
    {
        public long CodEscSapiens { get; set; }
        public long? CodEscPagamento { get; set; }
        public string NumTitulo { get; set; }
        public byte? NumParcela { get; set; }
        public decimal? ValParcela { get; set; }
        public DateTime? DatParcela { get; set; }
        public string DesEmitente { get; set; }
        public string FlgEmitenteSapiens { get; set; }
        public string FlgStatus { get; set; }
        public DateTime? DatEnvio { get; set; }
        public string DesRetorno { get; set; }
        public string DesRetornoSapiens { get; set; }
        public string NumNsu { get; set; }
        public string NumCat { get; set; }
        public string NumTid { get; set; }
    }
}
