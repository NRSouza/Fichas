using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadTemporadaequipePessoas
    {
        public long CodTemporadaequipePessoas { get; set; }
        public long? CodTemporadaequipe { get; set; }
        public byte? CodDistribuicaochale { get; set; }
        public long? CodPessoa { get; set; }
        public string DesObs { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public long? CodFormulario { get; set; }
        public long? CodItemformulario { get; set; }
        public long? CodTemporada { get; set; }
        public long? CodFormularioPeso { get; set; }
        public long? CodItemformularioPeso { get; set; }
        public long? CodFormularioAltura { get; set; }
        public long? CodItemformularioAltura { get; set; }
        public int? CodTurmanr { get; set; }

        public virtual TbBasDistribuicaochale CodDistribuicaochaleNavigation { get; set; }
        public virtual TbCadPessoa CodPessoaNavigation { get; set; }
        public virtual TbCadTemporadaequipe CodTemporadaequipeNavigation { get; set; }
        public virtual TbCadUsuario CodUsuarioNavigation { get; set; }
    }
}
