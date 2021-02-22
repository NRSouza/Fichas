using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadEscolacontato
    {
        public long CodEscolacontato { get; set; }
        public long? CodEscola { get; set; }
        public string NomContato { get; set; }
        public string DesCargo { get; set; }
        public string DesDdd { get; set; }
        public string DesTelefone { get; set; }
        public string DesDddCelular { get; set; }
        public string DesCelular { get; set; }
        public string DesEmail { get; set; }
        public string DatAniversario { get; set; }
        public string DesInfoadicionais { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbCadEscola CodEscolaNavigation { get; set; }
    }
}
