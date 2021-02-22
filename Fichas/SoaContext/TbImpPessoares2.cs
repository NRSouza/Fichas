using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbImpPessoares2
    {
        public long? CodPessoares { get; set; }
        public long? CodPessoa { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string FlgAtualizado { get; set; }
    }
}
