using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadEmailsCarga
    {
        public long CodEmail { get; set; }
        public long? CodFuncionalidade { get; set; }
        public int? CodUsuario { get; set; }
        public string DesAssunto { get; set; }
        public string DesPara { get; set; }
        public string DesCc { get; set; }
        public string DesCco { get; set; }
        public string DesEmail { get; set; }
        public DateTime? DatEmail { get; set; }
        public DateTime? DatEnviar { get; set; }
        public string FlgEmail { get; set; }
        public string FlgSms { get; set; }
        public string FlgAvaliaConteudo { get; set; }
        public string FlgStatus { get; set; }
        public DateTime? DatEnvio { get; set; }
        public int? CodUsuarioAprovacao { get; set; }
        public DateTime? DatAprovacao { get; set; }
        public string DesMotivo { get; set; }
        public byte? NumTentativas { get; set; }
        public string DesRemetente { get; set; }
        public string DesAnexos { get; set; }
    }
}
