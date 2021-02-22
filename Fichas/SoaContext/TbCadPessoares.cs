using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoares
    {
        public long CodPessoares { get; set; }
        public long? CodPessoa { get; set; }
        public int? CodPais { get; set; }
        public string DesCep { get; set; }
        public string DesLogradouro { get; set; }
        public string DesNumero { get; set; }
        public string DesComplemento { get; set; }
        public string DesBairro { get; set; }
        public string DesCidade { get; set; }
        public string DesUf { get; set; }
        public string FlgReside { get; set; }
        public string FlgAtivo { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string EndExt { get; set; }
    }
}
