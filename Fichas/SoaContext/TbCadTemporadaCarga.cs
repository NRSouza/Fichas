using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadTemporadaCarga
    {
        public TbCadTemporadaCarga()
        {
            TbCadPacotetemporadaCarga = new HashSet<TbCadPacotetemporadaCarga>();
            TbCadTemporadachaleCarga = new HashSet<TbCadTemporadachaleCarga>();
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

        public virtual TbCadUnidadenr CodUnidadenrNavigation { get; set; }
        public virtual ICollection<TbCadPacotetemporadaCarga> TbCadPacotetemporadaCarga { get; set; }
        public virtual ICollection<TbCadTemporadachaleCarga> TbCadTemporadachaleCarga { get; set; }
    }
}
