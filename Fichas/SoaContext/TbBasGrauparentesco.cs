using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasGrauparentesco
    {
        public TbBasGrauparentesco()
        {
            TbCadEscVinculo = new HashSet<TbCadEscVinculo>();
            TbCadPessoafichatelefoneEmergencial = new HashSet<TbCadPessoafichatelefoneEmergencial>();
            TbCadPessoapapelreserva = new HashSet<TbCadPessoapapelreserva>();
            TbCadPessoapapelreservaCarga = new HashSet<TbCadPessoapapelreservaCarga>();
            TbCadPessoarel20161201 = new HashSet<TbCadPessoarel20161201>();
        }

        public byte CodGrauparentesco { get; set; }
        public byte? CodGrauparentescoinverso { get; set; }
        public string CodGrauparentescoRed { get; set; }
        public string DesGrauparentesco { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string FlgSistema { get; set; }

        public virtual ICollection<TbCadEscVinculo> TbCadEscVinculo { get; set; }
        public virtual ICollection<TbCadPessoafichatelefoneEmergencial> TbCadPessoafichatelefoneEmergencial { get; set; }
        public virtual ICollection<TbCadPessoapapelreserva> TbCadPessoapapelreserva { get; set; }
        public virtual ICollection<TbCadPessoapapelreservaCarga> TbCadPessoapapelreservaCarga { get; set; }
        public virtual ICollection<TbCadPessoarel20161201> TbCadPessoarel20161201 { get; set; }
    }
}
