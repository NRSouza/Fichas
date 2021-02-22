using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class VwBoletosSapiens
    {
        public short Codemp { get; set; }
        public int Codfil { get; set; }
        public int Codcli { get; set; }
        public string Numtit { get; set; }
        public string Codtpt { get; set; }
        public DateTime Datent { get; set; }
        public DateTime Datemi { get; set; }
        public string Obstcr { get; set; }
        public string Codtns { get; set; }
        public string Titban { get; set; }
        public decimal Vlrori { get; set; }
        public decimal? Vlrabe { get; set; }
        public DateTime Vctpro { get; set; }
        public int? UsuPedido { get; set; }
        public string Sittit { get; set; }
    }
}
