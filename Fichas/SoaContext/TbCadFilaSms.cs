using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadFilaSms
    {
        public long CodFilaSms { get; set; }
        public string DesSistema { get; set; }
        public string DesOperadora { get; set; }
        public string NumCelular { get; set; }
        public string DesMensagem { get; set; }
        public string FlgEnviado { get; set; }
        public string DesIp { get; set; }
        public DateTime? DatAgendadoEnvio { get; set; }
        public DateTime? DatEnviado { get; set; }
        public DateTime? DatCadastro { get; set; }
        public string DesMensagemErro { get; set; }
        public DateTime? DatMensagemErro { get; set; }
    }
}
