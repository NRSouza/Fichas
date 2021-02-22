using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasMidia
    {
        public TbBasMidia()
        {
            TbCadPessoapapelreserva = new HashSet<TbCadPessoapapelreserva>();
            TbCadPessoapapelreservaCarga = new HashSet<TbCadPessoapapelreservaCarga>();
        }

        public long CodMidia { get; set; }
        public string DesMidia { get; set; }
        public string DesComentario { get; set; }
        public string FlgAtivo { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual ICollection<TbCadPessoapapelreserva> TbCadPessoapapelreserva { get; set; }
        public virtual ICollection<TbCadPessoapapelreservaCarga> TbCadPessoapapelreservaCarga { get; set; }
    }
}
