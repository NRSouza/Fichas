using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoa
    {
        public TbCadPessoa()
        {
            TbCadLancatividades = new HashSet<TbCadLancatividades>();
            TbCadNrmail = new HashSet<TbCadNrmail>();
            TbCadPagamentoAcampante = new HashSet<TbCadPagamentoAcampante>();
            TbCadPessoaassistenteDisponibilidade = new HashSet<TbCadPessoaassistenteDisponibilidade>();
            TbCadPessoaassistenteEspcultura = new HashSet<TbCadPessoaassistenteEspcultura>();
            TbCadPessoaconveniomedico = new HashSet<TbCadPessoaconveniomedico>();
            TbCadPessoadiario = new HashSet<TbCadPessoadiario>();
            TbCadPessoadocdigitalizado = new HashSet<TbCadPessoadocdigitalizado>();
            TbCadPessoaexpprofissional = new HashSet<TbCadPessoaexpprofissional>();
            TbCadPessoafichatelefoneEmergencial = new HashSet<TbCadPessoafichatelefoneEmergencial>();
            TbCadPessoaidacampante = new HashSet<TbCadPessoaidacampante>();
            TbCadPessoanecessespec = new HashSet<TbCadPessoanecessespec>();
            TbCadPessoapapelCarga = new HashSet<TbCadPessoapapelCarga>();
            TbCadPessoapapelreservaCarga = new HashSet<TbCadPessoapapelreservaCarga>();
            TbCadPessoapapelreservaDobra = new HashSet<TbCadPessoapapelreservaDobra>();
            TbCadPessoapremiacao = new HashSet<TbCadPessoapremiacao>();
            TbCadPessoarel20161201 = new HashSet<TbCadPessoarel20161201>();
            TbCadSmsComunicacaoTransportehist = new HashSet<TbCadSmsComunicacaoTransportehist>();
            TbCadTemporadaequipePessoas = new HashSet<TbCadTemporadaequipePessoas>();
            TbCadTurmanrAcampante = new HashSet<TbCadTurmanrAcampante>();
        }

        public long CodPessoa { get; set; }
        public string CodDepositoidentificado { get; set; }
        public string NomPessoa { get; set; }
        public string DesEmaillogin { get; set; }
        public string DesSenha { get; set; }
        public string DesLembretesenha { get; set; }
        public string DesImagem { get; set; }
        public string FlgAtivo { get; set; }
        public DateTime? DatCadastro { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string FlgLiberado { get; set; }
        public DateTime? DatLiberacao { get; set; }
        public string DesMensagembloqueio { get; set; }
        public int? CodClienteSapiens { get; set; }
        public string FlgVideoPortal { get; set; }
        public string FlgExterior { get; set; }

        public virtual ICollection<TbCadLancatividades> TbCadLancatividades { get; set; }
        public virtual ICollection<TbCadNrmail> TbCadNrmail { get; set; }
        public virtual ICollection<TbCadPagamentoAcampante> TbCadPagamentoAcampante { get; set; }
        public virtual ICollection<TbCadPessoaassistenteDisponibilidade> TbCadPessoaassistenteDisponibilidade { get; set; }
        public virtual ICollection<TbCadPessoaassistenteEspcultura> TbCadPessoaassistenteEspcultura { get; set; }
        public virtual ICollection<TbCadPessoaconveniomedico> TbCadPessoaconveniomedico { get; set; }
        public virtual ICollection<TbCadPessoadiario> TbCadPessoadiario { get; set; }
        public virtual ICollection<TbCadPessoadocdigitalizado> TbCadPessoadocdigitalizado { get; set; }
        public virtual ICollection<TbCadPessoaexpprofissional> TbCadPessoaexpprofissional { get; set; }
        public virtual ICollection<TbCadPessoafichatelefoneEmergencial> TbCadPessoafichatelefoneEmergencial { get; set; }
        public virtual ICollection<TbCadPessoaidacampante> TbCadPessoaidacampante { get; set; }
        public virtual ICollection<TbCadPessoanecessespec> TbCadPessoanecessespec { get; set; }
        public virtual ICollection<TbCadPessoapapelCarga> TbCadPessoapapelCarga { get; set; }
        public virtual ICollection<TbCadPessoapapelreservaCarga> TbCadPessoapapelreservaCarga { get; set; }
        public virtual ICollection<TbCadPessoapapelreservaDobra> TbCadPessoapapelreservaDobra { get; set; }
        public virtual ICollection<TbCadPessoapremiacao> TbCadPessoapremiacao { get; set; }
        public virtual ICollection<TbCadPessoarel20161201> TbCadPessoarel20161201 { get; set; }
        public virtual ICollection<TbCadSmsComunicacaoTransportehist> TbCadSmsComunicacaoTransportehist { get; set; }
        public virtual ICollection<TbCadTemporadaequipePessoas> TbCadTemporadaequipePessoas { get; set; }
        public virtual ICollection<TbCadTurmanrAcampante> TbCadTurmanrAcampante { get; set; }
    }
}
