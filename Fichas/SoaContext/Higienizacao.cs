using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class Higienizacao
    {
        public double? CodPessoares { get; set; }
        public double? CodPessoa { get; set; }
        public string Logradouro { get; set; }
        public string NovoLogradouro { get; set; }
        public string NovoNumero { get; set; }
        public string NovoComplemento { get; set; }
        public string FlgAtualizado { get; set; }
    }
}
