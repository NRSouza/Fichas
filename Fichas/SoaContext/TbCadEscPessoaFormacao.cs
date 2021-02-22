using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadEscPessoaFormacao
    {
        public long CodEscPessoaFormacao { get; set; }
        public long? CodEscPessoa { get; set; }
        public int? CodSerie { get; set; }
        public string DesSerieOutro { get; set; }
        public string DesTurma { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
    }
}
