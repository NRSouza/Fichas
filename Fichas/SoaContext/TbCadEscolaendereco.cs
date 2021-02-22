using System;
using System.Collections.Generic;

namespace Fichas.SoaContext
{
    public partial class TbCadEscolaendereco
    {
        public long CodEscolaendereco { get; set; }
        public long? CodEscola { get; set; }
        public short? CodTipoendereco { get; set; }
        public int? CodPais { get; set; }
        public string DesLogradouro { get; set; }
        public string DesLogradouroNumero { get; set; }
        public string DesComplemento { get; set; }
        public string DesCep { get; set; }
        public string DesBairro { get; set; }
        public string DesCidade { get; set; }
        public string DesUf { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime? DatAtualizacao { get; set; }

        public virtual TbCadEscola CodEscolaNavigation { get; set; }
        public virtual TbBasPais CodPaisNavigation { get; set; }
        public virtual TbBasTipoendereco CodTipoenderecoNavigation { get; set; }
    }
}
