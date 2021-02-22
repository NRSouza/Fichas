using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class BcTemporada
    {
        public int TemCod { get; set; }
        public int UniCod { get; set; }
        public int? TemVmaMon { get; set; }
        public int? TemVmaAca { get; set; }
        public int? TemVma { get; set; }
        public int? TemVfe { get; set; }
        public int? TemVmaAss { get; set; }
        public int? TemImi { get; set; }
        public int? TemIma { get; set; }
        public int? TemVfeMon { get; set; }
        public int? TemVfeAca { get; set; }
        public decimal? TemBar { get; set; }
        public string TemLsa { get; set; }
        public int? TemVfeAss { get; set; }
        public DateTime? TemDsa { get; set; }
        public DateTime? TemHsa { get; set; }
        public string TemLch { get; set; }
        public int? UsuCad { get; set; }
        public int? UsuCod { get; set; }
        public DateTime? TemDch { get; set; }
        public DateTime? TemCad { get; set; }
        public DateTime? TemHch { get; set; }
        public DateTime? TemAtu { get; set; }
        public int? TemVmaAcaOcu { get; set; }
        public int? TemVmaMonOcu { get; set; }
        public int? TemVmaAssOcu { get; set; }
        public int? TemVfeAcaOcu { get; set; }
        public int? TemVfeMonOcu { get; set; }
        public int? TemVfeAssOcu { get; set; }
        public string TemNom { get; set; }
        public int TemSta { get; set; }
        public string TurAti { get; set; }
        public string DesTur { get; set; }
        public int? IdCalouro { get; set; }
    }
}
