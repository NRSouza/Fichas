using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoaformacao
    {
        public long CodPessoaformacao { get; set; }
        public long? CodPessoa { get; set; }
        public byte? CodFormacaoescolar { get; set; }
        public int? CodFormacaoescolarcurso { get; set; }
        public byte? CodFormacaoescolarstatus { get; set; }
        public string DesInstituicao { get; set; }
        public string DesLocalidade { get; set; }
        public DateTime? DatInicio { get; set; }
        public DateTime? DatTermino { get; set; }
        public string DesAno { get; set; }
        public string DesSerie { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbBasFormacaoescolar CodFormacaoescolarNavigation { get; set; }
        public virtual TbBasFormacaoescolarcurso CodFormacaoescolarcursoNavigation { get; set; }
    }
}
