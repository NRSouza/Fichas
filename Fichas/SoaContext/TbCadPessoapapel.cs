﻿using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoapapel
    {
        public TbCadPessoapapel()
        {
            TbCadPessoapapelreserva = new HashSet<TbCadPessoapapelreserva>();
        }

        public long CodPessoapapel { get; set; }
        public long? CodPessoa { get; set; }
        public long? CodCategoria { get; set; }
        public DateTime? DatInicio { get; set; }
        public DateTime? DatTermino { get; set; }
        public string FlgIndefinido { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string DesObs { get; set; }

        public virtual TbBasCategoria CodCategoriaNavigation { get; set; }
        public virtual ICollection<TbCadPessoapapelreserva> TbCadPessoapapelreserva { get; set; }
    }
}
