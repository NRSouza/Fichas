using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPacote
    {
        public TbCadPacote()
        {
            TbCadAlocacaoonibusPacote = new HashSet<TbCadAlocacaoonibusPacote>();
            TbCadLancatividades = new HashSet<TbCadLancatividades>();
            TbCadOnibusPacote = new HashSet<TbCadOnibusPacote>();
            TbCadPacotetemporada = new HashSet<TbCadPacotetemporada>();
            TbCadPessoapapelreserva = new HashSet<TbCadPessoapapelreserva>();
            TbCadPessoapremiacao = new HashSet<TbCadPessoapremiacao>();
            TbCadSmsComunicacaoTransporte = new HashSet<TbCadSmsComunicacaoTransporte>();
        }

        public long? CodPacote { get; set; }
        public byte? CodUnidadenr { get; set; }
        public string CodServico { get; set; }
        public string DesPacote { get; set; }
        public int? NumDiarias { get; set; }
        public string FlgAtivo { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public decimal? ValCantina { get; set; }
        public DateTime? DatLimiteinscricao { get; set; }
        public int? DatLimitereserva { get; set; }
        public string DesTermocontrato { get; set; }
        public string DesPortal { get; set; }
        public string FlgCantina { get; set; }

        public virtual TbCadUnidadenr CodUnidadenrNavigation { get; set; }
        public virtual ICollection<TbCadAlocacaoonibusPacote> TbCadAlocacaoonibusPacote { get; set; }
        public virtual ICollection<TbCadLancatividades> TbCadLancatividades { get; set; }
        public virtual ICollection<TbCadOnibusPacote> TbCadOnibusPacote { get; set; }
        public virtual ICollection<TbCadPacotetemporada> TbCadPacotetemporada { get; set; }
        public virtual ICollection<TbCadPessoapapelreserva> TbCadPessoapapelreserva { get; set; }
        public virtual ICollection<TbCadPessoapremiacao> TbCadPessoapremiacao { get; set; }
        public virtual ICollection<TbCadSmsComunicacaoTransporte> TbCadSmsComunicacaoTransporte { get; set; }
    }
}
