using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoadocdigitalizado
    {
        public long CodPessoadocdigitalizado { get; set; }
        public long? CodPessoa { get; set; }
        public byte? CodTipodocsdigitalizados { get; set; }
        public string NomArquivo { get; set; }
        public string DesArquivo { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbCadPessoa CodPessoaNavigation { get; set; }
    }
}
