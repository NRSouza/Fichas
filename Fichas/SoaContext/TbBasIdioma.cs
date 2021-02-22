using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbBasIdioma
    {
        public byte CodIdioma { get; set; }
        public string DesIdioma { get; set; }
        public byte? ValOrdem { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
    }
}
