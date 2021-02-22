using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoarel20161220
    {
        public long CodPessoarel { get; set; }
        public long? CodPessoa { get; set; }
        public byte? CodGrauparentesco { get; set; }
        public long? CodPessoadep { get; set; }
        public byte? CodTipovinculopessoa { get; set; }
        public DateTime DatInicio { get; set; }
        public DateTime DatTermino { get; set; }
        public string DesObs { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
    }
}
