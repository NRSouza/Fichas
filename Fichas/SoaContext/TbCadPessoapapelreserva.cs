using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoapapelreserva
    {
        public TbCadPessoapapelreserva()
        {
            TbCadInscricao = new HashSet<TbCadInscricao>();
            TbCadOnibusAlocacao = new HashSet<TbCadOnibusAlocacao>();
            TbCadPacoteonibusPoltrona20160324 = new HashSet<TbCadPacoteonibusPoltrona20160324>();
            TbCadPessoapapelreservaDobra = new HashSet<TbCadPessoapapelreservaDobra>();
            TbCadPessoapapelreservaTicket = new HashSet<TbCadPessoapapelreservaTicket>();
            TbCadPessoapapelreservaTicketind = new HashSet<TbCadPessoapapelreservaTicketind>();
            TbCadPessoapapelreservaTransporte = new HashSet<TbCadPessoapapelreservaTransporte>();
            TbCadPessoapapelreservaent = new HashSet<TbCadPessoapapelreservaent>();
            TbCadPessoapapelreservahist = new HashSet<TbCadPessoapapelreservahist>();
            TbCadSmsComunicacaoTransportehist = new HashSet<TbCadSmsComunicacaoTransportehist>();
        }

        public long CodPessoapapelreserva { get; set; }
        public long? CodPessoapapel { get; set; }
        public byte? CodUnidadenr { get; set; }
        public long? CodPacote { get; set; }
        public long? CodMidia { get; set; }
        public byte? CodGrauparentescoresponsavel { get; set; }
        public long? CodResponsavel { get; set; }
        public string DesObs { get; set; }
        public DateTime? DatCadastro { get; set; }
        public DateTime? DatValidade { get; set; }
        public string DesIp { get; set; }
        public string FlgStatus { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public DateTime? DatLimiteinscricao { get; set; }
        public DateTime? DatKitcorreio { get; set; }
        public long? CodPessoa { get; set; }
        public DateTime? DatRetiradacamiseta { get; set; }
        public string DesObsRetiradacamiseta { get; set; }
        public long? CodTipoRetiradacamiseta { get; set; }
        public string FlgPendenciafinanceira { get; set; }
        public string FlgCantina { get; set; }
        public DateTime? DatContratocantina { get; set; }
        public string DesIndicado { get; set; }

        public virtual TbBasGrauparentesco CodGrauparentescoresponsavelNavigation { get; set; }
        public virtual TbBasMidia CodMidiaNavigation { get; set; }
        public virtual TbCadPacote CodPacoteNavigation { get; set; }
        public virtual TbCadPessoapapel CodPessoapapelNavigation { get; set; }
        public virtual TbCadUnidadenr CodUnidadenrNavigation { get; set; }
        public virtual ICollection<TbCadInscricao> TbCadInscricao { get; set; }
        public virtual ICollection<TbCadOnibusAlocacao> TbCadOnibusAlocacao { get; set; }
        public virtual ICollection<TbCadPacoteonibusPoltrona20160324> TbCadPacoteonibusPoltrona20160324 { get; set; }
        public virtual ICollection<TbCadPessoapapelreservaDobra> TbCadPessoapapelreservaDobra { get; set; }
        public virtual ICollection<TbCadPessoapapelreservaTicket> TbCadPessoapapelreservaTicket { get; set; }
        public virtual ICollection<TbCadPessoapapelreservaTicketind> TbCadPessoapapelreservaTicketind { get; set; }
        public virtual ICollection<TbCadPessoapapelreservaTransporte> TbCadPessoapapelreservaTransporte { get; set; }
        public virtual ICollection<TbCadPessoapapelreservaent> TbCadPessoapapelreservaent { get; set; }
        public virtual ICollection<TbCadPessoapapelreservahist> TbCadPessoapapelreservahist { get; set; }
        public virtual ICollection<TbCadSmsComunicacaoTransportehist> TbCadSmsComunicacaoTransportehist { get; set; }
    }
}
