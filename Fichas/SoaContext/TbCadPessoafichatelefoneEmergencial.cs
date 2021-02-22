using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoafichatelefoneEmergencial
    {
        public long CodPessoafichatelefoneEmergencial { get; set; }
        public long? CodPessoa { get; set; }
        public byte? CodGrauparentesco { get; set; }
        public string DesContato { get; set; }
        public string DesDdi { get; set; }
        public string DesDdd { get; set; }
        public string NumTelefone { get; set; }
        public byte? FlgOrdem { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbBasGrauparentesco CodGrauparentescoNavigation { get; set; }
        public virtual TbCadPessoa CodPessoaNavigation { get; set; }
    }
}
