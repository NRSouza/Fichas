using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasFormacaoescolar
    {
        public TbBasFormacaoescolar()
        {
            TbBasFormacaoescolarcurso = new HashSet<TbBasFormacaoescolarcurso>();
            TbCadPessoaformacao = new HashSet<TbCadPessoaformacao>();
        }

        public byte CodFormacaoescolar { get; set; }
        public byte? NumGrau { get; set; }
        public string DesFormacaoescolar { get; set; }
        public byte? ValOrdem { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual ICollection<TbBasFormacaoescolarcurso> TbBasFormacaoescolarcurso { get; set; }
        public virtual ICollection<TbCadPessoaformacao> TbCadPessoaformacao { get; set; }
    }
}
