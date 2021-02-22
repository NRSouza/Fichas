using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadEscVinculo
    {
        public long CodEscVinculo { get; set; }
        public long? CodEscPessoa { get; set; }
        public byte? CodGrauparentesco { get; set; }
        public long? CodEscPessoaDep { get; set; }
        public byte? CodGrauparentescoDep { get; set; }

        public virtual TbCadEscPessoa CodEscPessoaNavigation { get; set; }
        public virtual TbBasGrauparentesco CodGrauparentescoNavigation { get; set; }
    }
}
