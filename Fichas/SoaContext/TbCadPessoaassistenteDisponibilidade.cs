using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoaassistenteDisponibilidade
    {
        public TbCadPessoaassistenteDisponibilidade()
        {
            TbCadPessoaassistenteDisponibilidadeTemp = new HashSet<TbCadPessoaassistenteDisponibilidadeTemp>();
        }

        public long CodPessoaassistenteDisponibilidade { get; set; }
        public long? CodPessoaassistente { get; set; }
        public long? CodPessoa { get; set; }
        public long? CodEnquete { get; set; }
        public long? CodTipocamiseta { get; set; }
        public string FlgSetorArtistico { get; set; }
        public string FlgSetorRecreativo { get; set; }
        public string FlgSetorAnimacao { get; set; }
        public string FlgAtividadeMarcenaria { get; set; }
        public string FlgAtividadeCulinaria { get; set; }
        public string FlgAtividadeDanca { get; set; }
        public string FlgAtividadeRevistanr { get; set; }
        public string FlgAtividadeTeatro { get; set; }
        public string FlgAtividadeSalaartes { get; set; }
        public string FlgAtividadeSofttenis { get; set; }
        public string FlgOficinaAcaoaventura { get; set; }
        public string FlgOficinaAlpinismo { get; set; }
        public string FlgFaixaetaria1 { get; set; }
        public string FlgFaixaetaria2 { get; set; }
        public string FlgFaixaetaria3 { get; set; }
        public string FlgFaixaetaria4 { get; set; }
        public string FlgEstagNaoremunerado { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbCadEnquete CodEnqueteNavigation { get; set; }
        public virtual TbCadPessoa CodPessoaNavigation { get; set; }
        public virtual TbCadPessoaassistente CodPessoaassistenteNavigation { get; set; }
        public virtual TbBasTipocamiseta CodTipocamisetaNavigation { get; set; }
        public virtual ICollection<TbCadPessoaassistenteDisponibilidadeTemp> TbCadPessoaassistenteDisponibilidadeTemp { get; set; }
    }
}
