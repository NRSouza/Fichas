using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadPessoafichatelefone
    {
        public long CodPessoafichatelefone { get; set; }
        public long? CodPessoa { get; set; }
        public int? CodTipotelefone { get; set; }
        public int? CodOperadora { get; set; }
        public string DesDdd { get; set; }
        public string NumTelefone { get; set; }
        public string DesContato { get; set; }
        public string DesHorarioatendimento { get; set; }
        public string DesLocalidade { get; set; }
        public string DesObs { get; set; }
        public string FlgSmsmkt { get; set; }
        public string FlgPrincipal { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }
        public string DesDdi { get; set; }
    }
}
