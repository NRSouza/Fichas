using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPacoteCarga
    {
        public TbCadPacoteCarga()
        {
            TbCadPacotetemporadaCarga = new HashSet<TbCadPacotetemporadaCarga>();
            TbCadPessoapapelreservaCarga = new HashSet<TbCadPessoapapelreservaCarga>();
        }

        public long CodPacote { get; set; }
        public byte? CodUnidadenr { get; set; }
        public string CodServico { get; set; }
        public string DesPacote { get; set; }
        public int? NumDiarias { get; set; }
        public string FlgAtivo { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public decimal? ValCantina { get; set; }
        public DateTime? DatLimiteinscricao { get; set; }
        public DateTime? DatLimitereserva { get; set; }

        public virtual TbCadUnidadenr CodUnidadenrNavigation { get; set; }
        public virtual ICollection<TbCadPacotetemporadaCarga> TbCadPacotetemporadaCarga { get; set; }
        public virtual ICollection<TbCadPessoapapelreservaCarga> TbCadPessoapapelreservaCarga { get; set; }
    }
}
