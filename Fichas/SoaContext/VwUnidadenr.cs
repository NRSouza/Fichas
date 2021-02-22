using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class VwUnidadenr
    {
        public string NomUsuario { get; set; }
        public byte CodUnidadenr { get; set; }
        public string DesUnidadenr { get; set; }
        public string DesMercado { get; set; }
        public string DesCep { get; set; }
        public string DesEndereco { get; set; }
        public string DesBairro { get; set; }
        public string DesCidade { get; set; }
        public string DesUf { get; set; }
        public string DesPais { get; set; }
        public string DesTelefone { get; set; }
        public string DesFax { get; set; }
        public string DesEmail { get; set; }
        public string DesContato { get; set; }
        public string FlgAtivo { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
    }
}
