using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadUnidadenr
    {
        public TbCadUnidadenr()
        {
            TbBasFeriadounidadenr = new HashSet<TbBasFeriadounidadenr>();
            TbBasModalidadeUnidades = new HashSet<TbBasModalidadeUnidades>();
            TbBasVisibilidadeUnidades = new HashSet<TbBasVisibilidadeUnidades>();
            TbCadChale = new HashSet<TbCadChale>();
            TbCadChaleCarga = new HashSet<TbCadChaleCarga>();
            TbCadFormulario = new HashSet<TbCadFormulario>();
            TbCadLancatividades = new HashSet<TbCadLancatividades>();
            TbCadMensagem = new HashSet<TbCadMensagem>();
            TbCadPacote = new HashSet<TbCadPacote>();
            TbCadPacoteCarga = new HashSet<TbCadPacoteCarga>();
            TbCadParametronr = new HashSet<TbCadParametronr>();
            TbCadPessoapapelreserva = new HashSet<TbCadPessoapapelreserva>();
            TbCadPessoapapelreservaCarga = new HashSet<TbCadPessoapapelreservaCarga>();
            TbCadTemporada = new HashSet<TbCadTemporada>();
            TbCadTemporadaCarga = new HashSet<TbCadTemporadaCarga>();
            TbCadUsuario = new HashSet<TbCadUsuario>();
        }

        public byte CodUnidadenr { get; set; }
        public string DesUnidadenr { get; set; }
        public string DesMercado { get; set; }
        public string DesCep { get; set; }
        public string DesLogradouro { get; set; }
        public string DesLogradouroNumero { get; set; }
        public string DesComplemento { get; set; }
        public string DesBairro { get; set; }
        public string DesCidade { get; set; }
        public string DesUf { get; set; }
        public string DesPais { get; set; }
        public string DesDdd { get; set; }
        public string DesTelefone { get; set; }
        public string DesFax { get; set; }
        public string DesEmail { get; set; }
        public string DesContato { get; set; }
        public string FlgMatriz { get; set; }
        public string FlgAtivo { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string FlgSistema { get; set; }
        public short? CodFilialSapiens { get; set; }
        public short? CodEmpFilialSapiens { get; set; }
        public string CodEmpfilialSapiensCliente { get; set; }
        public string DesServidorEmail { get; set; }
        public string DesUsuarioEmail { get; set; }
        public string DesSenhaEmail { get; set; }
        public string DesPortaEmail { get; set; }

        public virtual ICollection<TbBasFeriadounidadenr> TbBasFeriadounidadenr { get; set; }
        public virtual ICollection<TbBasModalidadeUnidades> TbBasModalidadeUnidades { get; set; }
        public virtual ICollection<TbBasVisibilidadeUnidades> TbBasVisibilidadeUnidades { get; set; }
        public virtual ICollection<TbCadChale> TbCadChale { get; set; }
        public virtual ICollection<TbCadChaleCarga> TbCadChaleCarga { get; set; }
        public virtual ICollection<TbCadFormulario> TbCadFormulario { get; set; }
        public virtual ICollection<TbCadLancatividades> TbCadLancatividades { get; set; }
        public virtual ICollection<TbCadMensagem> TbCadMensagem { get; set; }
        public virtual ICollection<TbCadPacote> TbCadPacote { get; set; }
        public virtual ICollection<TbCadPacoteCarga> TbCadPacoteCarga { get; set; }
        public virtual ICollection<TbCadParametronr> TbCadParametronr { get; set; }
        public virtual ICollection<TbCadPessoapapelreserva> TbCadPessoapapelreserva { get; set; }
        public virtual ICollection<TbCadPessoapapelreservaCarga> TbCadPessoapapelreservaCarga { get; set; }
        public virtual ICollection<TbCadTemporada> TbCadTemporada { get; set; }
        public virtual ICollection<TbCadTemporadaCarga> TbCadTemporadaCarga { get; set; }
        public virtual ICollection<TbCadUsuario> TbCadUsuario { get; set; }
    }
}
