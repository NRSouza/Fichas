using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadTemporada
    {
        public TbCadTemporada()
        {
            TbCadCamisetaTemporada = new HashSet<TbCadCamisetaTemporada>();
            TbCadEnquetetemporada = new HashSet<TbCadEnquetetemporada>();
            TbCadPacotetemporada = new HashSet<TbCadPacotetemporada>();
            TbCadTemporadachale = new HashSet<TbCadTemporadachale>();
        }

        public long CodTemporada { get; set; }
        public byte? CodUnidadenr { get; set; }
        public long? CodCalouro { get; set; }
        public string DesTemporada { get; set; }
        public int? DesIdadeinicial { get; set; }
        public int? DesIdadefinal { get; set; }
        public string DesSaida { get; set; }
        public string DesEndsaida { get; set; }
        public string DesChegada { get; set; }
        public string DesEndchegada { get; set; }
        public DateTime? DatSaida { get; set; }
        public DateTime? DatChegada { get; set; }
        public DateTime? DatInicio { get; set; }
        public DateTime? DatTermino { get; set; }
        public string FlgTurmanr { get; set; }
        public string DesTurmanr { get; set; }
        public string FlgAtivo { get; set; }
        public string FlgIdade { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public DateTime? DatValidade { get; set; }
        public string FlgListaespera { get; set; }
        public string DesGuiaacampante { get; set; }
        public string FlgIndicacao { get; set; }

        public virtual TbCadUnidadenr CodUnidadenrNavigation { get; set; }
        public virtual ICollection<TbCadCamisetaTemporada> TbCadCamisetaTemporada { get; set; }
        public virtual ICollection<TbCadEnquetetemporada> TbCadEnquetetemporada { get; set; }
        public virtual ICollection<TbCadPacotetemporada> TbCadPacotetemporada { get; set; }
        public virtual ICollection<TbCadTemporadachale> TbCadTemporadachale { get; set; }
    }
}
