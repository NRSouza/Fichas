using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadAgenciarepresentante
    {
        public int CodAgenciarepresentante { get; set; }
        public string DesAgenciarepresentante { get; set; }
        public string DesCep { get; set; }
        public string DesLogradouro { get; set; }
        public string DesNumero { get; set; }
        public string DesComplemento { get; set; }
        public string DesBairro { get; set; }
        public string DesCidade { get; set; }
        public string DesUf { get; set; }
        public string DesEmail { get; set; }
        public string DesLogin { get; set; }
        public string DesSenha { get; set; }
        public string DesUrl { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
    }
}
