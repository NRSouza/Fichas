using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasFormacaoescolarcurso
    {
        public TbBasFormacaoescolarcurso()
        {
            TbCadPessoaformacao = new HashSet<TbCadPessoaformacao>();
        }

        public int CodFormacaoescolarcurso { get; set; }
        public byte? CodFormacaoescolar { get; set; }
        public string NomCurso { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbBasFormacaoescolar CodFormacaoescolarNavigation { get; set; }
        public virtual ICollection<TbCadPessoaformacao> TbCadPessoaformacao { get; set; }
    }
}
