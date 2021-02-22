using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadMensagemcoletiva
    {
        public long CodMensagemcoletiva { get; set; }
        public string DesTitulo { get; set; }
        public string DesMensagem { get; set; }
        public string DesPopulacao { get; set; }
        public int NumEmail { get; set; }
        public DateTime? DatEnvio { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
    }
}
