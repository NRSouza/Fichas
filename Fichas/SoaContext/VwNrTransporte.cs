using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class VwNrTransporte
    {
        public int? CodigoAcampante { get; set; }
        public string NomeAcampante { get; set; }
        public string OninusIda { get; set; }
        public byte? PoltronaIda { get; set; }
        public string OnibusVolta { get; set; }
        public byte? PoltronaVolta { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string DataNascimento { get; set; }
        public string Pacote { get; set; }
        public string Unidade { get; set; }
    }
}
