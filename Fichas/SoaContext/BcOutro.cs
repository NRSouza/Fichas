using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class BcOutro
    {
        public int OutCod { get; set; }
        public string OutNom { get; set; }
        public string CpfOut { get; set; }
        public string OutPar { get; set; }
        public string OutEmp { get; set; }
        public string OutFun { get; set; }
        public string OutMail { get; set; }
        public int? OutMailAti { get; set; }
        public string OutMer { get; set; }
        public string OutTel1 { get; set; }
        public string OutTel2 { get; set; }
        public string OutTel3 { get; set; }
        public string OutTel4 { get; set; }
        public string OutObs { get; set; }
        public string OutVet { get; set; }
        public int? OutVetfer { get; set; }
        public int? OutVetitu { get; set; }
        public int? OutVetfaz { get; set; }
        public int? OutVetagu { get; set; }
        public int? OutVetsao { get; set; }
        public int? OutVetsap { get; set; }
        public int? OutVetgua { get; set; }
        public int? OutFal { get; set; }
        public DateTime? DatCad { get; set; }
        public int? UsuCad { get; set; }
        public DateTime? DatAlt { get; set; }
        public int? UsuAlt { get; set; }
        public string RgOut { get; set; }
        public string OemOut { get; set; }
        public string GrauParentesco { get; set; }
    }
}
