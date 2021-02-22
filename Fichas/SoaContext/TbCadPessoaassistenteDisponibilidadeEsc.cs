using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoaassistenteDisponibilidadeEsc
    {
        public long CodPessoaassistenteDisponibilidadeEsc { get; set; }
        public long? CodPessoa { get; set; }
        public string CodEvento { get; set; }
        public string DesUnidadenr { get; set; }
        public string DesModulo { get; set; }
        public string DesSerie { get; set; }
        public string PedPara { get; set; }
        public string PedApos { get; set; }
        public string DesObs { get; set; }
        public string FlgDisponibilidade { get; set; }
        public DateTime? DatInicio { get; set; }
        public DateTime? DatTermino { get; set; }
        public DateTime? DatAtualizacao { get; set; }
    }
}
